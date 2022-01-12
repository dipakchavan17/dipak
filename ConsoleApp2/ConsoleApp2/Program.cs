using System;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("helloworld");
            Console.ReadLine();
            FibonacciSeries fibonacci = new FibonacciSeries();
            fibonacci.FindFibonacciSeries();
            Console.ReadLine();
        }
    }
}
