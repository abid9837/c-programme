using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,num=1;
            Console.WriteLine("number?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=n; i>=1; i--)
            {
                num = num*i;
            }
            Console.WriteLine("the factoria of {0} is {1}",n,num);
        }
    }
}