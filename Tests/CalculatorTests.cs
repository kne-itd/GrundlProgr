using System;
using Xunit;

namespace GrundlProgrammering.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddShouldReturn7()
        {
            // arrange
            // act
            // assert
            Assert.Equal(7, Calculator.Add(3, 4));
        }
        [Fact]
        public void SubtractShouldReturn4()
        {
            // arrange
            // act
            // assert
            Assert.Equal(4, Calculator.Subtract(7, 3));
        }
        [Fact]
        public void MultiplyShouldReturn21()
        {
            // arrange
            // act
            // assert
            Assert.Equal(21, Calculator.Multiply(7, 3));
        }
        [Fact]
        public void DivideShouldReturn3()
        {
            // arrange
            // act
            // assert
            Assert.Equal(3, Calculator.Divide(21, 7));
        }
        [Fact]
        public void DivideShouldThrowDivideByZeroException()
        {
            // arrange
            // act
            // assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(3, 0));
        }
        [Fact]
        public void CalcWithPrecedenseShouldReturn25_125()
        {
            // arrange
            string task = "2+(3*4+(3*4))+0-3.5/(2*2)";
            double expected = 25.125;
            // act
            double actual = Calculator.CalcWithPrecedensRules(task);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
