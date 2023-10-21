using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShtokerVN.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double p  = 0 ;
            int value;
            for (value = 5; value > 0;value++)
            {
                p = p +  (1 / (Math.Sqrt(Math.Cos(value) + 1)));
            }
            return Math.Round(p,3);
        }
    }
}
