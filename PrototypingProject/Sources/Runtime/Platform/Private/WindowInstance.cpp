#include <WindowInstance.h>

PWindowInstance * PWindowInstance::GetInstance()
{
	static PWindowInstance instance;
	return &instance;
}

PWindowInstance::PWindowInstance()
	: MainHInstance(0)
	, MainHWND(0)
{
}

void PWindowInstance::Initialize(HINSTANCE hInstance, HWND hWND)
{
	GetInstance()->MainHInstance = hInstance;
	GetInstance()->MainHWND = hWND;
}
