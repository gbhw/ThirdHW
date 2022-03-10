using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            int[,] a = { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            DiagonalPrint(a);

            Console.WriteLine("Task2");
            Task2();

            Console.WriteLine("Task3");
            Task3();
            Console.ReadKey();
        }

        internal static void DiagonalPrint(int[,] array)
        {
            int sdvig = 1;
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString().PadLeft(sdvig++));
            }
        }

        internal static void Task2()
        {
            var dict = new Dictionary<string, string>()
            {
                { "Иван","ivan@mail.ru" },
                { "Галина","888005553553"},
                { "Сергей","sergo@gmail.com"},
            };

            foreach (var person in dict)
            {
                Console.WriteLine($"имя контакта: {person.Key} номер телефона/email: {person.Value}");
            }
        }
        
        internal static void Task3()
        {
            Console.Write("Введите строку: ");
            string userString = Console.ReadLine();
            string customString = string.Empty;
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                customString += userString[i];
            }
            Console.WriteLine(customString);

        }

    }
}
