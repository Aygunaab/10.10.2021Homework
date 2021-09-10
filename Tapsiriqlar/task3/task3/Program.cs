using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meselenin serti:Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana");
            Console.WriteLine( );
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            int Number = Convert.ToInt32(Console.ReadLine());
            int LastDigit = Number % 10;
            if (LastDigit==7)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
    }
}
