using System;
using Xunit;
using Cond;

namespace GrundlProgrammering.Cond.Tests
{
    public class CondTests
    {
        private Cond.Program ObjectUnderTest;
        public CondTests()
        {
            ObjectUnderTest = new Cond.Program();
        }
        [Fact]
        public void AbsoluteValueShouldReturnAbs()
        {
            // arrange
            const int POS = 6832;
            const int NEG = -392;
            //act

            int i = Program.AbsoluteValue(POS);
            int j = Program.AbsoluteValue(NEG);

            //assert
            Assert.Equal(POS, i);
            Assert.Equal(-NEG, j);

        }
        [Fact]
        public void DivisibleBy2or3()
        {
            // arrange
            //act
            int i = Program.DivisibleBy2Or3(15, 30);
            int j = Program.DivisibleBy2Or3(2, 90);
            int a = Program.DivisibleBy2Or3(7, 12);

            //assert
            Assert.Equal(450, i);
            Assert.Equal(180, j);
            Assert.Equal(19, a);
        }
        [Fact]
        public void UppercaseTest()
        {
            // arrange
            //act
            //assert
            Assert.False(Program.IfConsistsOfUppercaseLetters("xyz"));
            Assert.True(Program.IfConsistsOfUppercaseLetters("DOG"));
            Assert.False(Program.IfConsistsOfUppercaseLetters("L9#"));
        }
        [Fact]
        public void IfGreaterThanThirdOne()
        {
            // arrange
            //act
            //assert
            Assert.True(Program.IfGreaterThanThirdOne(2, 7, 12));
            Assert.False(Program.IfGreaterThanThirdOne(-5, -8, 50));
        }
        [Fact]
        public void IfNumberIsEven()
        {
            // arrange
            //act
            //assert
            Assert.True(Program.IfNumberIsEven(1248));
            Assert.False(Program.IfNumberIsEven(721));
        }
        [Fact]
        public void IsSortedAsc()
        {
            // arrange
            int[] i = { 3, 7, 10 };
            int[] j = { 64, 62, 99 };
            //act
            //assert
            Assert.True(Program.IfSortedAscending(i));
            Assert.False(Program.IfSortedAscending(j));
        }
        [Fact]
        public void NegPosZero()
        {
            // arrange
            //act
            //assert
            Assert.Equal("positive", Program.PositiveNegativeOrZero(5.24));
            Assert.Equal("zero", Program.PositiveNegativeOrZero(0.0));
            Assert.Equal("negative", Program.PositiveNegativeOrZero(-994.53));
        }
        [Fact]
        public void LeapYear()
        {
            // arrange
            //act
            //assert

            Assert.True(Program.IfYearIsLeap(2016));
            Assert.False(Program.IfYearIsLeap(2018));
        }
    }
}
