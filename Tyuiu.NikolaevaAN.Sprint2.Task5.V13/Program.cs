using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikolaevaAN.Sprint2.Task5.V13.Lib;

namespace Tyuiu.NikolaevaAN.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Николаева А. Н. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Николаева Александра Николаевна | ПКТб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g(год), *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m           *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n, m, g;
            Console.Write("Введите год: ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n));
            Console.ReadKey(); 
        }
    }
}
