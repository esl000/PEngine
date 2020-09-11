#include "PEngineCore.h"
#include "Graphics.h"

PEngineCore * PEngineCore::GetInstance()
{
	static PEngineCore instance;
	return &instance;
}

PEngineCore::PEngineCore()
{
}

void PEngineCore::Initialize()
{
	PGraphics::GetInstance()->Initialize();
}

bool PEngineCore::UpdateApplication()
{
	return true;
}

void PEngineCore::Release()
{
	PGraphics::GetInstance()->Release();
}
