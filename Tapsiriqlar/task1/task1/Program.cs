using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            while (i<5)
            {
                Console.WriteLine("Meselenin serti:Verilmis ededlerin tek ve ya cut oldugunu yoxla");
                Console.WriteLine();
                Console.WriteLine("***************************************************************");
                Console.WriteLine();
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number % 2 == 0)
                {
                    Console.WriteLine("Eded cutdur");
                }
                else
                {
                    Console.WriteLine("Eded tekdir");
                }
            }
        }
    }
}
