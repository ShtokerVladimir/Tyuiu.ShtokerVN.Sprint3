using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task4.V27.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                       *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры C#                                                        *");
            Console.WriteLine("* Задание #4                                                                                      *");
            Console.WriteLine("* Вариант #27                                                                                     *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=x/(cos(x)+sin(x)) *");
            Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.                                 *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
