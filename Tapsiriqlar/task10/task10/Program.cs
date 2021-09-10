using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 1;
            while (i<3)
            {
                Console.WriteLine("Birinci ededi daxil edin: ");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin: ");
                int Number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ucuncu ededi daxil edin: ");
                int Number3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dorduncu ededi daxil edin: ");
                int Number4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Besinci ededi daxil edin: ");
                int Number5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Altinci ededi daxil edin: ");
                int Number6 = Convert.ToInt32(Console.ReadLine());

                if (Number1 > Number2 && Number1 > Number3 && Number1 > Number4 && Number1 > Number5 && Number1 > Number6)
                {
                    Console.WriteLine("en boyuk eded birinci ededdir");
                }
                else if (Number1 < Number2 && Number2 > Number3 && Number2 > Number4 && Number2 > Number5 && Number2 > Number6)
                {
                    Console.WriteLine("En boyuk eded 2ci ededdir");
                }
                else if (Number1 < Number3 && Number2 < Number3 && Number3 > Number4 && Number3 > Number5 && Number3 > Number6)
                {
                    Console.WriteLine("En boyuk eded 3cu ededdir");
                }
                else if (Number1 < Number4 && Number2 < Number4 && Number3 < Number4 && Number4 > Number5 && Number4 > Number6)
                {
                    Console.WriteLine("En boyuk eded 4cu ededdir");
                }
                else if (Number1 < Number5 && Number2 < Number5 && Number3 < Number5 && Number4 < Number5 && Number5 > Number6)
                {
                    Console.WriteLine("En boyuk eded 5ci ededdir");
                }
                else if (Number1 < Number6 && Number6 > Number3 && Number6 > Number4 && Number6 > Number5)
                {
                    Console.WriteLine("En boyuk eded 6ci ededdir");
                }


            }



        }
    }
}
