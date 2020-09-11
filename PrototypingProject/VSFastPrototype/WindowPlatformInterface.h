#pragma once
#include "WindowHeader.h"

class PWindowPlatformInterface
{
public:
	static PWindowPlatformInterface* Initialize(HINSTANCE hInstance);

public:
	PWindowPlatformInterface(HINSTANCE hInstance);
};
