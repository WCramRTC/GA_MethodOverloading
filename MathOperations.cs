using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading
{
    public class MathOperations
    {

        // Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }

        public double Subtract(double a, double b, double c)
        {
            return a - b - c;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        // Division
        public int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }


    } // class

} // namespace
