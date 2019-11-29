using Formatting;

namespace Models
{
    public sealed class BuildVar
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Format.Var(Name, Value);
        }
    }
}