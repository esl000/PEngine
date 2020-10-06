#pragma once

class PGraphics
{
protected:
	PGraphics();
public:
	static PGraphics* GetInstance();
	static void Initialize();
	static void Release();
};