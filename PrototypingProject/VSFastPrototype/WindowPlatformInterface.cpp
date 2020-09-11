#include "WindowPlatformInterface.h"

PWindowPlatformInterface* PWindowPlatformInterface::Initialize(HINSTANCE hInstance)
{
	return new PWindowPlatformInterface(hInstance);
}

PWindowPlatformInterface::PWindowPlatformInterface(HINSTANCE hInstance)
{
}
