#pragma once

#ifdef _EDITABLE_PROJECT
#define MATHMODULEAPI __declspec(dllexport)
#else
#define MATHMODULEAPI __declspec(dllimport)
#endif

