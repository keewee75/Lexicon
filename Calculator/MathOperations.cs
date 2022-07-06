using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
        //Addition
        public static double Addition(double input1, double input2)
        {
            return input1 + input2;

        }

        public static double Addition(double[] arrayOfDoubles)
        {
            return arrayOfDoubles.Sum(x => x);
        }

        //Subtraction
        public static double Subtraction(double input1, double input2)
        {
            return input1 - input2;
        }

        public static double Subtraction(double[] arrayOfDoubles)
        {
            double start = 0;
            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                start = start - arrayOfDoubles[i];
            }

            return start;
        }

        //Multiplication
        public static double Multiplication(double input1, double input2)
        {
            return input1 * input2;
        }

        //Division
        public static double Division(double input1, double input2)
        {
            return input1 / input2;
        }
    }
}
