using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            PrimeNumber prime = new PrimeNumber();

            Console.WriteLine("Выберете функицю:");
            Console.WriteLine("1 - вычислить факториал числа");
            Console.WriteLine("2 - проверка числа на простоту");
            Console.WriteLine("3 - поиск директории файла");
            Console.WriteLine("4 - поиск файлов по расширению");

            Console.Write("Выш выбор: ");

            int change;
            change = Convert.ToInt32(Console.ReadLine());

            switch (change)
            {
                case 1:
                    Console.Write("Введите число для возведения его в факториал: ");
                    Console.WriteLine(factorial.CalculateFactorial(Convert.ToInt32(Console.ReadLine())));
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Введите число для проверки на простоту: ");
                    Console.WriteLine(prime.IsPrime(Convert.ToInt32(Console.ReadLine())));
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Введите путь до файла: ");
                    SimpleDirectorySearch.DirectorySearch(Console.ReadLine());
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Введите путь до файла: ");
                    ExpansionDirectorySearch.ExpDirectorySearch(Console.ReadLine());
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
