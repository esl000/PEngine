#pragma once

#ifdef _EDITABLE_PROJECT
#define CORE_API __declspec(dllexport)
#else
#define CORE_API __declspec(dllimport)
#endif

