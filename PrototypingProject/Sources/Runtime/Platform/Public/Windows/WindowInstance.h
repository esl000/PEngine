#pragma once
#include <PEngineMacros.h>
#include <WindowHeader.h>

#define g_PWindowInstance PWindowInstance::GetInstance()

class PWindowInstance
{
	SINGLETONE(PWindowInstance)

public:
	PROPERTY_GET(HINSTANCE, MainHInstance)
	PROPERTY_GET(HWND, MainHWND)

public:
	static void Initialize(HINSTANCE hInstance, HWND hWND);
};
