using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovNS.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k;
            for (k = startValue; k <= stopValue; k++)
            {
                multiplySeries = multiplySeries * Math.Pow(1 / (Math.Pow(k, value)),-1);
            }
            return multiplySeries;
        }
    }
}
