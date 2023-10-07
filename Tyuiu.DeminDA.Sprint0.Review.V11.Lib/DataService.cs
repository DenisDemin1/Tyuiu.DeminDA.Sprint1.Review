﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DeminDA.Sprint0.Review.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Pow(Math.Log(Math.Sin(x)), x)) / Math.Log(1 + Math.Pow(x, 2))+ (y - Math.Sqrt(Math.Abs(x)));
            double res = Math.Round(z, 3, MidpointRounding.AwayFromZero);
            return res;

        }
    }
}
