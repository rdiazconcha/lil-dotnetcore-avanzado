using System;

namespace dotnet_waffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragraphs = args != null && args.Length > 0 && int.TryParse(args[0], out int value) ? value : 1;
            Console.WriteLine(WaffleGenerator.WaffleEngine.Text(paragraphs, true));
        }
    }
}
