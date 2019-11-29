namespace Formatting
{
    public static class Format
    {
        public static string Var(string name, string value)
        {
            return $"{name}=\"{value}\"";
        }
    }
}