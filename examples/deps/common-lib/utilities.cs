using Formatting;
using System.Linq;
using System.Collections.Generic;

namespace Utility
{
    public static class BuildEnvironment
    {
        public static List<string> GetVariables(Dictionary<string, string> vars)
        {
            return vars.Select(v => Format.Var(v.Key, v.Value)).ToList();
        }
    }
}