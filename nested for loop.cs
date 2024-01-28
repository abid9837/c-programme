using System;
namespace progamme
{
    class runTime
    {
        static void Main(string[] args)
        {
            for ( int i=1; i<11; i++)
            {
                for (int j=1; j<i; j++)
                {
                    Console.Write(j);
                  
                }
                Console.Write("\n");
            }
            
        }
    }
}