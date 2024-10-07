#include<Windows.h>
#include"resource.h"

CONST CHAR* g_COMBO_BOX_ITEMS[] = { "This", "is", "my", "first", "Combo", "Box" }; // ������ �����

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//											NULL - �.�. ������������� ���� ���, DlgProc - ��������� ���� - �� � ��������, �������� ��� ������� (��������� �� �������)
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	return 0;
}

// ��������� ���� (�� ���� ���� ������� switch ������� �� ��������� ��������, ��� ��� ������)
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

		HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1); // �������� hwnd ��������� �������� ����

		//				����� �����. ������ ������� -  ������ ������� � ������ / �� ������ ������� ��-�� ������� � ������
		for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS)/sizeof(g_COMBO_BOX_ITEMS[0]); i++)
		{
			SendMessage(hCombo, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
			// CB_ - ������� ��� �������� ���� ComboBox
			// ���� ��-�� � ComboBox ����������� �� ���������, ������ ���������: project -> properties -> advansed -> character set -> Use Multi-Byte Character Set
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