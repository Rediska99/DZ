using System;

namespace Project;

    class Program
    {
        static void Main(string[] args)
        {
            int a_x = 1;
            int a_y = 1;
            int a_z = 1;
            int b_x = 0;
            int b_y = 0;
            int b_z = 0;
            double distance = Math.Sqrt(Math.Pow(a_x - b_x,2) + Math.Pow(a_y - b_y,2) + Math.Pow(a_z - b_z,2));
            Console.WriteLine(distance);  

        }    
    }    
