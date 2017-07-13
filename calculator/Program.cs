using System;

namespace calculator
{
    public class Calculator
    {
        public int sum;

        public int Add(int val1, int val2)
        {
            int sum = val1 + val2;
            return sum;
        }

        public int Sub(int val1, int val2)
        {
            int dif = val1 - val2;
            return dif;
        }

        public int Mult(int val1, int val2)
        {
            int mult = val1 * val2;
            return mult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
