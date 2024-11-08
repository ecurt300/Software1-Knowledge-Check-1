﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{

    //Put in a static class makes sense since these are only used once per program run.
    public class Calculator
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Subtract(int first, int second)
        {
            return first - second;
        }

        public static int Multiply(int first, int second)
        {
           return first * second;
        }

        public static double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
