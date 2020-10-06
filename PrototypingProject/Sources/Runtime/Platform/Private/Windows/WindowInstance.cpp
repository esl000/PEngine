#include <WindowInstance.h>

void PWindowInstance::Initialize(HINSTANCE hInstance, HWND hWND)
{
	GetInstance()->MainHInstance = hInstance;
	GetInstance()->MainHWND = hWND;
}
