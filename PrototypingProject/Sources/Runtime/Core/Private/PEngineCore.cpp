#include <PEngineCore.h>
#include <Graphics.h>
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
