using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Meselenin serti:Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman  hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.");
            int i = 1;
            while (i<5)
            {
                Console.WriteLine();
                Console.WriteLine("************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>10&&Number<99)
                {
                    int LastDigit = Number % 10;
                    int FirstDigit = Number / 10;
                    int sum = LastDigit + FirstDigit;
                    if (sum%2==0)
                    {
                        Console.WriteLine(LastDigit*FirstDigit);
                    }
                    else
                    {
                        Console.WriteLine("Verilmis ededin reqemleri cemi cut deyil");
                    }
                }
            }
        }
    }
}
