using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(24));
        }

        public static int Fibonacci(int n)
        {
            return (n <= 1 ? n : Fibonacci(n-1) + Fibonacci(n-2));
        }
    }
}
