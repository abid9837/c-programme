using System;
namespace progamme
{
    class runTime
    {
        static void Main(string[] args)
        {
        
            int a, b, temp;
            a = 10;
            b = 20;
            temp = a;
            a =b;
            b=temp;   
            
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}", temp);
            
        }
    }
}
