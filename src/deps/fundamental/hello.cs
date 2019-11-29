using System;
using System.Linq;
using System.Collections.Generic;

using Utility;
using Models;
using Formatting;

namespace Hello
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Format a list of key/pairs as variables!");
            Console.WriteLine($"like so: {Format.Var("foo", "bar")}");
            Console.WriteLine("\n");

            var vars = new Dictionary<string, string>() {
              {"TMP", "/tmp"},
              {"GITHUB_TOKEN", "oh-so-secret"},
              {"BAZEL_VERSION", "0.0.1"},
              {"MOON", "ON_ROUTE"}
            };

            foreach (var output in BuildEnvironment.GetVariables(vars))
            {
                Console.WriteLine(output);
            }
        }
    }
}
