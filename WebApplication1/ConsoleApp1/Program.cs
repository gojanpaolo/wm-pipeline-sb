using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
#if !DEBUG
            Console.WriteLine("my console app");
#endif
            Console.ReadLine();
        }
    }
}
