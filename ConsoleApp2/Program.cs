using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double web = Convert.ToDouble(Console.ReadLine());
            double lw = 34.2;
            web = web / lw * 0.99;
            Console.WriteLine($"The response to Hello World is a number {web}");

                            
        }
    }
}
