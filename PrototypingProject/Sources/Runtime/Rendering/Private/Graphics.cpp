#include <Graphics.h>

PGraphics::PGraphics()
{
}

PGraphics * PGraphics::GetInstance()
{
	static PGraphics instance;
	return &instance;
}

void PGraphics::Initialize()
{
}

void PGraphics::Release()
{
}
