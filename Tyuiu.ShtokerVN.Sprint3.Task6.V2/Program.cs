using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task6.V2.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                                                *");
            Console.WriteLine("* Задание #6                                                                                                              *");
            Console.WriteLine("* Вариант #2                                                                                                              *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                        *");
            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [12, 18] количество всех делителей. *");
            Console.WriteLine("*                                                                                                                         *");
            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                        *");
            Console.WriteLine("***************************************************************************************************************************");

            int startValue = 12;
            int stopVaue = 18;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopVaue);

            Console.WriteLine("***************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                              *");
            Console.WriteLine("***************************************************************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopVaue));

            Console.ReadKey();
        }
    }
}
