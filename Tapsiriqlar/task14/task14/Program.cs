using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler(bu o demekdirki 1, 2, 3, 4, 5, 6, 7 reqemlide ola biler)
            //Bu ededin evvelin 1 reqemini artir.

            int i = 0;
            while (i < 5)
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 0 && Number <= 99999999)
                {
                    if (Number > 0 && Number <= 9)
                    {
                        Console.WriteLine(Number + 10);
                    }
                    else if (Number >= 10 && Number <= 99)
                    {
                        Console.WriteLine(Number + 100);
                    }
                    else if (Number >= 100 && Number <= 999)
                    {
                        Console.WriteLine(Number + 1000);
                    }
                    else if (Number >= 1000 && Number <= 9999)
                    {
                        Console.WriteLine(Number + 10000);
                    }
                    else if (Number >= 10000 && Number <= 99999)
                    {
                        Console.WriteLine(Number + 100000);
                    }
                    else if (Number >= 100000 && Number <= 999999)
                    {
                        Console.WriteLine(Number + 1000000);
                    }
                    else if (Number >= 1000000 && Number <= 9999999)
                    {
                        Console.WriteLine(Number + 10000000);
                    }
                    else if (Number >= 10000000 && Number <= 99999999)
                    {
                        Console.WriteLine(Number + 100000000);
                    }
                    else
                    {
                        Console.WriteLine("Daxil edilen reqem 8 reqemliden coxdur");
                    }
                }
                else
                {
                    Console.WriteLine("Daxil edilen eded serte uygun deyil");
                }

            }
        
    


        }
    }
}