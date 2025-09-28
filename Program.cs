namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.Value = "Single responsibility principle";

            Console.WriteLine(line.Value);
            Console.WriteLine(LineTransformer.Reverse(line.Value));
        }
    }

    internal class Line
    {
        private string _line;

        public string Value
        {
            get => _line;
            set => _line = value;
        }

        public int Length => _line.Length;
    }

    internal static class LineTransformer
    {
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
