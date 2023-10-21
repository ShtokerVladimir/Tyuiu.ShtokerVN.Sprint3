using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShtokerVN.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double SumSeries = 0;
            int x = 1;
            do
            {
                SumSeries = SumSeries + Math.Pow((2 / Math.Cos(x) + 0.5), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
