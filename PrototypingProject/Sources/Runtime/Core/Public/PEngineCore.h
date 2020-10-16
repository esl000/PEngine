#pragma once
#include <CoreDefine.h>
#include <PEngineMacros.h>

#define g_PEngineCore PEngineCore::GetInstance()

class CORE_API PEngineCore
{
	SINGLETONE(PEngineCore)
public:
	static void Initialize();
	static bool UpdateApplication();
	static void Release();

public:
};