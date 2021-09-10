using System;

namespace task13
{
    class Program
    {
        public static int GetDigit(int number, int digit)
        {
            for (int i = 0; i < digit - 1; i++)
            {
                number /= 10;
            }
            return number %= 10;
        }


        static void Main(string[] args)
        {
            //Verilmish 7 reqemli eded polindromdursa o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?

            
            int i = 0;
            while (i < 5)
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000000 && Number <= 9999999)
                {
                    int ReversNumber = (((((GetDigit(Number, 1) * 10 + GetDigit(Number, 2)) * 10 + GetDigit(Number, 3)) * 10 + GetDigit(Number, 4)) * 10 + GetDigit(Number, 5)) * 10 + GetDigit(Number, 6)) * 10 + GetDigit(Number, 7);
                    Console.WriteLine(ReversNumber);
                    if (Number == ReversNumber)
                    {
                        int count = 0;
                        int[] digits =
                         {
                        GetDigit(ReversNumber,1),
                        GetDigit(ReversNumber,2),
                          GetDigit(ReversNumber,3),
                            GetDigit(ReversNumber,4),
                              GetDigit(ReversNumber,5),
                                GetDigit(ReversNumber,6),
                                  GetDigit(ReversNumber,7),

                    };
                        for (int j = 0; j < digits.Length; j++)
                        {
                            if (0 == digits[j])
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Verilmis ededde 0 reqemi tapilmadi");
                        }
                        else
                        {
                            Console.WriteLine("Bu ededde {0} dene 0 var", count);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Daxil edilen eded palindrom deyil");
                    }

                }
                else
                {
                    Console.WriteLine("Daxil edilen eded 7 reqemli deyil");
                }


            }


        }
    }
}