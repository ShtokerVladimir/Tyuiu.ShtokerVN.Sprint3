using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task2.V20.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                             *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                              *");
            Console.WriteLine("* Задание #2                                                                                            *");
            Console.WriteLine("* Вариант #20                                                                                           *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                      *");
            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле, при х=1 *");
            Console.WriteLine("*                                                                                                       *");
            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
            Console.WriteLine("*********************************************************************************************************");

            int x = 1;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
            Console.WriteLine("*********************************************************************************************************");

            Console.WriteLine("Сумма ряда =" + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
