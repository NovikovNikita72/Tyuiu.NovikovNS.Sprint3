using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovNS.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueA;
            int len = (stopValue - startValue) + 1;
            valueA = new double[len];
            double y;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) - 2) == 0)
                {
                    y = 0;
                    valueA[i] = y;
                    i++;
                }
                y = Math.Round((((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2), 2);
                valueA[i] = y;
                i++;
            }
            return valueA;
        }
    }
}
