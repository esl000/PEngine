#pragma once

#include <PEngineMacros.h>

#define g_PEngineCore PEngineCore::GetInstance()

class PEngineCore
{
	SINGLETONE(PEngineCore)
public:
	static void Initialize();
	static bool UpdateApplication();
	static void Release();

public:
};