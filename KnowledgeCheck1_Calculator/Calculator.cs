using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{

    //Put in a static class makes sense since these are only used once per program run.
    public class Calculator
    {
        public static int Add(string first, string second)
        {
            int convertedFirst = CalculatorHelper.ConvertToInt(first);
            int convertedSecond = CalculatorHelper.ConvertToInt(second);
            return convertedFirst + convertedSecond;
        }

        public static int Subtract(string first, string second)
        {
            int convertedFirst = CalculatorHelper.ConvertToInt(first);
            int convertedSecond = CalculatorHelper.ConvertToInt(second);
            return convertedFirst - convertedSecond;
        }

        public static int Multiply(string first, string second)
        {
            int convertedFirst = CalculatorHelper.ConvertToInt(first);
            int convertedSecond = CalculatorHelper.ConvertToInt(second);
            return convertedFirst + convertedSecond;
        }

        public static double Divide(string first, string second)
        {
            double convertedFirst = CalculatorHelper.ConvertToDouble(first);
            double convertedSecond = CalculatorHelper.ConvertToDouble(second);
            return convertedFirst / convertedSecond;
        }
    }
}

public static class CalculatorHelper
{
    public static decimal ConvertToDecimal(string num)
    {
        decimal result = 0;
        if (decimal.TryParse(num, out result))
        {
            return result;
        }
        
        return 0;
    }
    public static double ConvertToDouble(string num)
    {
        double result = 0;
        if (double.TryParse(num, out result))
        {
            return result;
        }

        return 0;
    }
    public static int ConvertToInt(string num)
    {
        int result = 0;
        if (int.TryParse(num, out result))
        {
            return result;
        }

        return 0;
    }

    public static float ConvertToFloat(string num)
    {
        float result = 0;
        if(float.TryParse(num, out result))
        {
            return result;
        }
        return 0;
    }
}
