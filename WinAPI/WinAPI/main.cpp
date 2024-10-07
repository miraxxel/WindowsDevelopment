#include<Windows.h>
#include"resource.h"

// глобальные переменные объявлять нельзя, константы можно
CONST CHAR g_sz_LOGIN_INVITATION[] = "Введите имя пользователя";
// Процедура окна:
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	// hInstance - экземпляр запущенного *.exe-файла нашей программы
	// hPrevInst - НЕ исп-ся
	// LPSTR - LongPoiner To String
	// lpCmdLine - CommandLine  (командная строка с параметрами запуска приложения)
	// nCmdShow	- режим отображения окна (развернуто на весь экран, свернуто на панель задач и т.д.)
	//Префиксы: n...., lp... это Венгерская нотация
	//			n - Number
	//			lp - Long Pointer
	//			h - HINSTANCE
	//
	// типы окон:
	// 1 - окно сообщения
	// 2 - диалоговое окно MessageBox()
	// 3 - обычное окно
	// Модальным называется окно, которое блокирует родительское

	/*MessageBox
	(
		NULL, 
		"Hello World!\nThis is MessageBox()", 
		"Windows title", 
		MB_CANCELTRYCONTINUE | MB_HELP | MB_DEFBUTTON3 |
		MB_ICONERROR |
		//MB_SYSTEMMODAL
		MB_DEFAULT_DESKTOP_ONLY |
		MB_RIGHT
	);  // wchar_t 
	// MB_DEFBUTTON3 - флаг значит, что третья кнопка (макс. 4 кнопки в окне) будет активной
	// MB_SYSTEMMODAL - делает наше окно модальным, так, что никакое другое окно его не перекрывает
	// тоже самое и MB_DEFAULT_DESKTOP_ONLY
	// MB_RIGHT - текст в окне будет по правому краю*/

	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	// hwnd - handler to window (обработчик/дескриптор окна - это число, при помощи которого можно обратиться к окну.)
	// uMsg - Message. Сообщение, которое отправляется окну. 
	// wParam, lParam - это параметры сообщения, у каждого сообщения свой набор параметров.

	//static const char* defaultText = "Введите имя пользователя:";

	switch (uMsg)
	{
	case WM_INITDIALOG:		// это соо отпр. 1 раз при инициализации окна
	{	
		HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
		SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)g_sz_LOGIN_INVITATION);
	}
		break;
	case WM_COMMAND:		// обраб. нажатие кнопок и др. действия пользователя
		// ResourceID берем здесь
		switch (LOWORD(wParam))
		{
		case IDC_EDIT_LOGIN:
		{
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage((HWND)lParam, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			/*
			WM_COMMAND
			LOWORD(wParam) = ResourceID
			HIWORD(wParam) = NotificationCode(EN_SETFOCUS)
			*/

			// NotoficationCode берем здесь
			if (HIWORD(wParam) == EN_SETFOCUS && strcmp(sz_buffer, g_sz_LOGIN_INVITATION) == 0)
					SendMessage((HWND)lParam, WM_SETTEXT, 0, (LPARAM)"");
			if (HIWORD(wParam) == EN_KILLFOCUS && strcmp(sz_buffer, "") == 0)
					SendMessage((HWND)lParam, WM_SETTEXT, 0, (LPARAM)g_sz_LOGIN_INVITATION);
			// EN - Edit Notification
			/* 
			Функция strcmp(const char* str1, const char* str2) - сравнивает строки и вовзр.знач - е типа 'int'
				возвращает:
				0 - строки идентичны;
				!0 -  строки отличаются; (<0 - 1 строка меньше 2-ой; >0 - 1 строка больше 2-ой)
			*/
		}
		break;
		case IDC_BUTTON_COPY:
		{
			// 1. создаем буфер:
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE] = {}; // sz - string zero (null terminated line - c-string)
			// 2. получаем обработчик текстовых полей:
			HWND hEditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
			HWND hEditPassword = GetDlgItem(hwnd, IDC_EDIT_PASSWORD);
			// 3. считываем содержимое поля 'Login' в буфер:
			SendMessage(hEditLogin, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);
			// 4. Записываем полученный текст в текстовое поле 'Password':
								// если указатель, то его нужно всегда явно преобразовывать в LPARAM
			SendMessage(hEditPassword, WM_SETTEXT, 0, (LPARAM)sz_buffer);
		}
		break;
		case IDOK: MessageBox(hwnd, "Была нажата кнопка ОК", "Info", MB_OK | MB_ICONINFORMATION); break;
		}
		break;	
	case WM_CLOSE:			// отпр-ся при нажатии кнопки 'Закрыть' (X)
		EndDialog(hwnd, 0);
		break;
	}

	return false;
}