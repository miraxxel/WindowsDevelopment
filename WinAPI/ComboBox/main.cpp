#define _CRT_SECURE_NO_WARNINGS
#include<Windows.h>
#include<cstdio>
#include"resource.h"

CONST CHAR* g_COMBO_BOX_ITEMS[] = { "This", "is", "my", "first", "Combo", "Box" }; // массив строк

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//											NULL - т.к. родительского окна нет, DlgProc - процедура окна - мы её написали, передаем имя функции (указатель на функцию)
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	return 0;
}

// процедура окна (по сути один большой switch который по сообщению выбирает, что ему делать)
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

		HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1); // получили hwnd дочернего элемента окна

		//				чтобы получ. размер массива -  размер массива в байтах / на размер первого эл-та массива в байтах
		for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS)/sizeof(g_COMBO_BOX_ITEMS[0]); i++)
		{
			SendMessage(hCombo, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
			// CB_ - префикс для элемента окна ComboBox
			// если эл-ты в ComboBox загрузились на китайском, меняем кодировку: project -> properties -> advansed -> character set -> Use Multi-Byte Character Set
		}
		SendMessage(hCombo, CB_SETCURSEL, 0, 0);
		// CB_SETCURSEL - ComboBox Set Current Selection
	}
		break;
	case WM_COMMAND: // здесь обрабатываем кнопки
		switch (LOWORD(wParam))
		{
		case IDOK:
		{ // область видимости - фигурные скобки, чтобы объявить переменную, нужно указать область видимости у нужного нам case
			HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);
			// любой эл-т интерфейса виндовс является окном, обращаемся к окну мы через SendMessage
			INT i = SendMessage(hCombo, CB_GETCURSEL, 0, 0);

			// чтобы прочитать строку из списка, нужно куда-то её записать
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage(hCombo, CB_GETLBTEXT, i, (LPARAM)sz_buffer);
			CHAR sz_message[SIZE]{};
			sprintf(sz_message, "Вы выбрали пункт №%i со значением \"%s\".", i, sz_buffer);
				// функция sprintf() выполняет форматирование строк, т.е. позволяет вставить в строку переменные значения (имеет произвольное кол-во аргументов)
				// спецификатор %i - целое число
				// спецификатор %s - строка
				// на месте где стоит этот спецификатор будет встроенно соответствующее значение
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONINFORMATION);
		}
		break;
		case IDCANCEL:
			EndDialog(hwnd, 0);
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}