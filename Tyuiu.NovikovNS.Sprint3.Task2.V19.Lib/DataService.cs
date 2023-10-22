using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovNS.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            do
            {
                sum += Math.Cos(i) * 0.5;
                i++;
            } while (i <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
