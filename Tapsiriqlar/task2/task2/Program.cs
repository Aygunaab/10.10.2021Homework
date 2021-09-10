
using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(" Meselenin serti:Iki eded verilib .Eger birinci eded ikinci edede tam bolunurse o zaman cavabi cixart.Eks halda bolunmur sozunu cap et");
                Console.WriteLine();
                Console.WriteLine("***************************************************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Birinci ededi daxil edin");
                double NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin");
                double NumberTwo = Convert.ToDouble(Console.ReadLine());

                if (NumberOne % NumberTwo == 0)
                {
                    double divaded = NumberOne / NumberTwo;
                    Console.WriteLine(divaded);
                }
                else
                {
                    Console.WriteLine("Bolunmur");
                }

            }
        }
    }
}
