using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task1.V8.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                           *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                            *");
            Console.WriteLine("* Задание #1                                                                                          *");
            Console.WriteLine("* Вариант #8                                                                                          *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                    *");
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                            *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при х=0,25 *");
            Console.WriteLine("*                                                                                                     *");
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                    *");
            Console.WriteLine("*******************************************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                          *");
            Console.WriteLine("*******************************************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
