using System;

namespace Casing
{
    public static class CasingHelper
    {
        public static string Lowercase(string text) => text.ToLower();
        public static string Uppercase(string text) => text.ToUpper();
        public static string Titlecase(string text) => Char.ToUpper(text[0]) + text.ToLower().Substring(1);
    }
}