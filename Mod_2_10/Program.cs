using System;

namespace Mod_2_10
{
    class Program
    {
        static string num_Of_year(int b)
        {
            if (b == 12 || b == 1 || b == 2)
            {
                return "Зима";
            }
            else if (b == 3 || b == 4 || b == 5)
            {
                return "Весна";
            }
            else if (b == 6 || b == 7 || b == 8)
            {
                return "Лето";
            }
            else if (b == 9 || b == 10 || b == 11)
            {
                return "Осень";
            }
            else
            {
                return "Введите число от 1 до 12";
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = num_Of_year(a);
            Console.WriteLine(b);
        }
    }
}