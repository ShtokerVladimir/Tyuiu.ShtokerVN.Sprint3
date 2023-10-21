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
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                p = p + (1 / Math.Pow((Math.Cos(5) + 1), 2));
            }
            return Math.Round(p,3);
        }
    }
}
