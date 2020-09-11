#pragma once
#include <WindowHeader.h>

class PWindowInstance
{
public:
	static PWindowInstance* GetInstance();
public:
	HINSTANCE MainHInstance;
	HWND MainHWND;
protected:
	PWindowInstance();

public:
	static void Initialize(HINSTANCE hInstance, HWND hWND);
};
