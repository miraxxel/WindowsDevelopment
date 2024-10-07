#include<Windows.h>
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
	case WM_COMMAND:
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}