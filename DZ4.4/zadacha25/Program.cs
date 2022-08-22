using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int result = a;
            for(int i=1; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }
    }
}
