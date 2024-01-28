using System;
namespace switchCase
{
    class Case
    {
        static void Main (string [] args)
        {
            Console.WriteLine("day ?  ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is statrday");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 3:
                    Console.WriteLine("Today is Monday");
                    break;
                case 4:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 7:
                    Console.WriteLine("Today is Friday");
                    break;
            }
        }
    }
}