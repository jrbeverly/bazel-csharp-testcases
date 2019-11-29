using System;

using Casing;

namespace Hello
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Playing around with text casing!");

            var text1 = "hello";
            var text2 = "HeLLo WoRLd!";
            var text3 = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine($"Text: {text1}");
            Console.WriteLine("Lowercase: " + CasingHelper.Lowercase(text1));
            Console.WriteLine("Uppercase: " + CasingHelper.Uppercase(text1));
            Console.WriteLine("Titlecase: " + CasingHelper.Titlecase(text1));

            Console.WriteLine($"Text: {text2}");
            Console.WriteLine("Lowercase: " + CasingHelper.Lowercase(text2));
            Console.WriteLine("Uppercase: " + CasingHelper.Uppercase(text2));
            Console.WriteLine("Titlecase: " + CasingHelper.Titlecase(text2));

            Console.WriteLine($"Text: {text3}");
            Console.WriteLine("Lowercase: " + CasingHelper.Lowercase(text3));
            Console.WriteLine("Uppercase: " + CasingHelper.Uppercase(text3));
            Console.WriteLine("Titlecase: " + CasingHelper.Titlecase(text3));
        }
    }
}
