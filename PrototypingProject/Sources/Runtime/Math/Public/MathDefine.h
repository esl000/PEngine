#pragma once

#ifdef _EDITABLE_PROJECT
#define MATH_API __declspec(dllexport)
#else
#define MATH_API __declspec(dllimport)
#endif

