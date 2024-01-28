using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eenter your 1st number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your 2nd number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your 3rd number ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 < num2) && (num1 < num3))
            {
                Console.WriteLine("The small number is = " + num1);
            }
            else if ((num2 < num3) && (num2 < num2))
            {
                Console.WriteLine("The small number is = " + num2);
            }
            else
            {
                Console.WriteLine("The small number is = " + num3);
            }
        }
    }
}