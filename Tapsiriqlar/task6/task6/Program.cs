using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana");
            int i = 1;
            while (i<5)
            {

                Console.WriteLine();
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=100&&Number<=999)
                {
                    int firstDigit = Number % 10;
                    int MidDigit = (Number % 100 - firstDigit) / 10;
                    int LastDigit = Number / 100;
                    int sum = firstDigit + LastDigit;
                  
                    if (sum==MidDigit)
                    {
                        Console.WriteLine("Beli");
                    }
                    else
                    {
                        Console.WriteLine("Xeyr");
                    }

                }
                else
                {
                    Console.WriteLine(" Daxil edilmis eded 3 reqemli deyil");
                }
            }
        }
    }
}
