using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task7.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                                                *");
            Console.WriteLine("* Задание #7                                                                                                              *");
            Console.WriteLine("* Вариант #7                                                                                                              *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                        *");
            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции: F(x) = cos(x) + cos(x) / x + 2 - 3 * x                    *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на ноль.            *");
            Console.WriteLine("* При делении на ноль вернуть 0. Значения округлить до двух знаков после запятой.                                         *");
            Console.WriteLine("*                                                                                                                         *");
            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                        *");
            Console.WriteLine("***************************************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                              *");
            Console.WriteLine("***************************************************************************************************************************");


            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    +   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <=len-1; i++ )
            {
                Console.WriteLine("| {0,5:d}    |  {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
