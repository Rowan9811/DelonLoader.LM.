#pragma once
#include "./Console.h"

class Debug
{
public:
    static bool Enabled;
    static void Msg(const char* txt);
    static void Msgf(const char* fmt, ...);
    static void DirectWrite(const char* txt);
    static void Internal_Msg(Console::Color meloncolor, Console::Color txtcolor, const char* namesection, const char* txt);
    static std::string string_format(const char* format, va_list args1);
};