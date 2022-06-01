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
            double sonuc = number1 + number2;
            return sonuc;
        }

        public double Subtraction(double number1, double number2)
        {
            double sonuc = number1 - number2;
            return sonuc;
        }
        public double Multiply(double number1, double number2)
        {
            double sonuc = number1 * number2;
            return sonuc;
        }
        public double Divide(double number1, double number2)
        {
            double sonuc = number1 / number2;
            return sonuc;
        }

    }
}