#pragma once

#ifdef NATIVEDLL_EXPORTS
#define NATIVEDLL_API __declspec(dllexport)
#else
#define NATIVEDLL_API __declspec(dllimport)
#endif


extern "C" NATIVEDLL_API int __cdecl compute(int value);