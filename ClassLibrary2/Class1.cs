using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("除数不能为 0。");
            }

            return dividend / divisor;
        }

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double DivideX(double a, double b) => a / b;

        public double DivideY(double a, double b) => a / b;
    }
}
