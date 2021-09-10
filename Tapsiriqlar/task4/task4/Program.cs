using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Meselenin serti:Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana");
            int i = 1;
            while (i<5)
            {
                Console.WriteLine("***********************************************************************************************");
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                int firstDigit = Number % 10;
                int LastDigit = Number / 10;
                if (Number > 10 && Number < 99)
                {
                    if (firstDigit == LastDigit)
                    {
                        Console.WriteLine("beli");
                    }
                    else
                    {
                        Console.WriteLine("Xeyr");
                    }
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded ikireqemli deyil");
                }

            }
        }
    }
}
