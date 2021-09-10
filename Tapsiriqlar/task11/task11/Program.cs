using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Meselenin serti:Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zamanbu ededdin ilk 2 reqemini son 2 reqemine yapishdir.Neticenin ustune ortaya dushen 2 reqemini gel.");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            int Number = Convert.ToInt32(Console.ReadLine());
           
            if (Number>=100000&&Number<=999999)
            {
                int Number1 = Number / 1000;
                int Number2 = Number % 1000;
                int sum1 = 0;
                int sum2 = 0;
                while (Number1 != 0)
                {
                    sum1+=Number1 % 10;
                    Number1 /= 10;
   
                }
                Console.WriteLine("Ededin ilk uc reqeminin cemi:"+sum1);
                while (Number2 != 0)
                {
                    sum2 += Number2 % 10;
                    Number2 /= 10;
                   

                }
                Console.WriteLine("Ededin son uc reqeminin cemi:"+sum2);
                if (sum1==sum2)
                {
                    int Number3 = Number / 10000;
                    int Number4 = Number % 100;
                    int Number5 = Number / 100 % 100;
                    int Number6 = Number3 * 100 + Number4;
                    int result = Number6 + Number5;
                    Console.WriteLine("Netice:"+result);
                    
                }


            }
 
        }
    }
}
