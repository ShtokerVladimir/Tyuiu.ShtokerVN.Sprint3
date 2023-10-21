using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task3.V6.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                      *");
            Console.WriteLine("* Задание #3                                                                                    *");
            Console.WriteLine("* Вариант #6                                                                                    *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                              *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву t в строке: 12able 1o s4gh                     *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");
            
            string value = "12able 1o s4gh";
            char chr = 't';

            Console.WriteLine("строка = " + value);
            Console.WriteLine("Заменяющий символ = " + chr);

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("Итог = " + ds.ReplaceNumOnChar(value, chr));

            Console.ReadKey();

        }
    }
}
