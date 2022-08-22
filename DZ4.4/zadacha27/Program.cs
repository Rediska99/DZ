using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20673;
            SumOfDigits(number);
        }    
        
        void SumOfDigits(int number)    
        {
            int sum = 0;
            Console.Write("Сумма цифр числа " + number);
            while(number > 0)
            {
                sum += number%10;
                number /=10;
            }
            Console.WriteLine(" Равна " + sum);
        }
        void Power(int a, int b)
        {
            int result = a;
            for(i = i; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }    
        
    }
}

