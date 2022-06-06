using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Calculate
    {
        public double Add(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        public double Subtraction(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }
        public double Multiply(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }
        public double Divide(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }

    }
}