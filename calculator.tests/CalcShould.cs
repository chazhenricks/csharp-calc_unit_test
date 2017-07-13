using System;
using Xunit;

namespace calculator.tests
{
    public class CalculatorShould
    {
        private Calculator _newcalculator;

        public CalculatorShould()
        {
            _newcalculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _newcalculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractTwoIntegers()
        {
            int dif = _newcalculator.Sub(15, 4);
            Assert.Equal(dif, 11);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        public void MultiplyTwoIntegers(int value)
        {
            int mult = _newcalculator.Mult(value, 5);
            
            Assert.Equal(mult, (value * 5));
        }
    }
}
