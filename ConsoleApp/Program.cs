using System;

using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = NorthwindDb.GetData();
            Console.WriteLine(text);
        }
    }
}
