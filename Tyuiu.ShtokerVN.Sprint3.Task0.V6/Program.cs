using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint3.Task0.V6.Lib;

namespace Tyuiu.ShtokerVN.Sprint3.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 15;

            
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("Сумма ряда =" + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
