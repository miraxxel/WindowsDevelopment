#include<Windows.h>

#define IDC_STATIC	1000 // 1. создаем ResourceID для дочернего эл-та
#define IDC_EDIT	1001
#define IDC_BUTTON	1002	

CONST CHAR g_SZ_WINDOW_CLASS[] = "Main Window"; // имя класса окна

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	wClass.style = NULL;
	wClass.cbSize = sizeof(wClass); // cb - count bytes
	wClass.cbClsExtra = 0; // Class Extra Bytes
	wClass.cbWndExtra = 0; // Window Extra Bytes

	//	Appearance:
	//wClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	//wClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION); // small icon
	wClass.hIcon = (HICON)LoadImage(hInstance, "ICO\\tv.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);
	wClass.hIconSm = (HICON)LoadImage(hInstance, "ICO\\ventilator.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);

	//wClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wClass.hCursor = (HICON)LoadImage
	(
		hInstance,
		"CUR\\starcraft-original\\Working in Background.ani",
		IMAGE_CURSOR,
		LR_DEFAULTSIZE,
		LR_DEFAULTSIZE,
		LR_LOADFROMFILE
	);
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	//
	wClass.hInstance = hInstance;
	wClass.lpfnWndProc = (WNDPROC)WndProc;
	wClass.lpszClassName = g_SZ_WINDOW_CLASS;
	wClass.lpszMenuName = NULL;

	// 1.2. Вызвать функцию RegisterClassEx(...):
	if (RegisterClassEx(&wClass) == NULL)
	{
		MessageBox(NULL, "Class registration failed", "Error", MB_OK | MB_ICONERROR);
	}

	// 2) Создаем окно:
	HWND hwnd = CreateWindowEx
		(
			NULL,		// Win ExStyle
			g_SZ_WINDOW_CLASS,	 // Win Class Name
			g_SZ_WINDOW_CLASS,	 // Win Title
			//WS_OVERLAPPEDWINDOW, // Win Style
			WS_OVERLAPPED | WS_THICKFRAME | WS_SYSMENU | WS_MINIMIZE | WS_MAXIMIZEBOX,
			CW_USEDEFAULT, CW_USEDEFAULT,	// Coordinates
			CW_USEDEFAULT, CW_USEDEFAULT,	// Windows size
			NULL,	// Parent
			NULL,	// hMenu: Для главного окна это ResourceID главного меню, 
			// для дочернего окна (кнопки и др эл-ты) - 
			// это ID-ресурса соответствующего эл-та (кнопки, текст.поля и т.д.)
			// поэтому ResourceID мы находим дочерний эл-т окна при помощи функции GetDlgItem()
			hInstance,
			NULL
		);
	if (hwnd == NULL)
	{
		MessageBox(NULL, "Windows creation failed", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}
	ShowWindow(hwnd, nCmdShow); // задает режим отоброжения окна (на весь экран/свернуто)
	UpdateWindow(hwnd); // прорисовывает окно

	// 3) Запуск цикла соо:
	MSG msg;
	while (GetMessage(&msg, 0, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.message;

	return 0;
}

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE: // для создания чего-то в пределах нашего окна
		CreateWindowEx
			(
				NULL,
				"Static",
				"Это static_text",
				WS_CHILD | WS_VISIBLE,	//	Для всех дочерних окон стиль обяз. будет WS_CHILD и часто с WS_VISIBLE
				100, 10, // положение в пределах окна
				200, 20, // размер 
				hwnd,
				(HMENU)IDC_STATIC,
				GetModuleHandle(NULL),
				NULL

			);
		CreateWindowEx
			(
				NULL, "Edit", "",
				WS_CHILD | WS_VISIBLE,	// WS - Windows Styles
				100, 30,
				200, 20,
				hwnd,
				(HMENU)IDC_EDIT,
				GetModuleHandle(NULL), // возвращает hInstance приложения
				NULL
			);
		CreateWindowEx
			(
				NULL, "Button", "Применить",
				WS_CHILD | WS_VISIBLE,
				200, 55,
				100, 32,
				hwnd,
				(HMENU)IDC_BUTTON,
				GetModuleHandle(NULL),
				NULL
			);
		break;
	case WM_COMMAND: // при нажатии на кнопки обработка сообщений происходит здесь
		switch (LOWORD(wParam))
		{
		case IDC_BUTTON:
		{
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT);
			SendMessage(hEdit, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			HWND hStatic = GetDlgItem(hwnd, IDC_STATIC);
			SendMessage(hStatic, WM_SETTEXT, 0, (LPARAM)sz_buffer);
			SendMessage(hwnd, WM_SETTEXT, 0, (LPARAM)sz_buffer);
		}
		break;
		}
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
	case WM_CLOSE:DestroyWindow(hwnd); break;
	default:	return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return FALSE;
}