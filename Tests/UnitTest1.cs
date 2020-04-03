using System;
using Xunit;
using GrundlProgrammering;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddAndMultiplyShouldReturn30()
        {
            //arrange
            
            //act
            int i = Program.AddAndMultiply(2, 4, 5);
            //assert
            Assert.Equal(30, i);
        }
        [Fact]
        public void CtoFShouldReturn32F()
        {
            //arrange

            //act
            string i = Program.CtoF(0);
            //assert
            Assert.Equal("T = 32F", i);
        }
        [Fact]
        public void CtoFShouldReturn212F()
        {
            //arrange

            //act
            string i = Program.CtoF(100);
            //assert
            Assert.Equal("T = 212F", i);
        }
        [Fact]
        public void CtoFShouldReturnError()
        {
            //arrange

            //act
            string i = Program.CtoF(-300);
            //assert
            Assert.Equal("Temperature below absolute zero", i);
        }
        [Fact]
        public void ElemOpsTest()
        {
            //arrange
            //act
            string s = Program.ElementaryOperations(3, 8);
            // assert
            Assert.Equal("11, -5, 24, 0.375", s);
        }
        [Fact]
        public void ElemOpsShouldNotAllowDivisionByZero()
        {
            //arrange
            //act
            string s = Program.ElementaryOperations(3, 0);
            // assert
            Assert.Equal("3, 3, 0, Division by zero not possible", s);
        }
        [Fact]
        public void IsResultTheSame()
        {
            //arrange
            //act
            //assrt
            Assert.True(Program.IsResultTheSame(2+2, 2*2));
            Assert.False(Program.IsResultTheSame(9/3, 16-1));
        }
        [Fact]
        public void ModuloOpsShouldReturn1()
        {
            //arrange
            //act
            int i = Program.ModuloOperations(8, 5, 2);
            //assert
            Assert.Equal(1, i);
        }
        [Fact]
        public void CubeShouldReturn8()
        {
            //arrange
            //act
            int i = (int) Program.Cube(2);
            //assert
            Assert.Equal(8, i);
        }
        [Fact]
        public void CubeShouldReturnMinus166_375()
        {
            //arrange
            //act
            double i = Program.Cube(-5.5);
            //assert
            Assert.Equal(-166.375, i);
        }
        [Fact]
        public void Swap()
        {
            //arrange
            //act
            string s = Program.SwapTwoNumbers(87, 45);
            //assert
            Assert.Equal("Before: a = 87, b = 45 After: a = 45, b = 87", s);
        }
    }
}
