using System;
using Xunit;
using GrundlProgrammering;

namespace GrundlProgrammering.Tests
{
    public class StringTests
    {
        
        [Fact]
        public void AddSeparatorTest()
        {
            // arrange
            //act
            const string input = "ABCD";
            const string sep = "^";
            string output = Strings.AddSeparator(input, sep);
            string output2 = Strings.AddSeparator("chocolate", "-");

            //assert
            Assert.Equal("A^B^C^D", output);
            Assert.Equal("c-h-o-c-o-l-a-t-e", output2);
        }
        [Fact]
        public void IsPalindromeTest()
        {
            // arrange
            string pal = "eye";
            string nonPal = "home";
            //act
            //assert
            Assert.True(Strings.IsPalindrome(pal));
            Assert.False(Strings.IsPalindrome(nonPal));
        }
        [Fact]
        public void LengthOfStringTest()
        {
            // arrange
            string string1 = "computer";
            string string2 = "ice cream";

            //act
            //assert
            Assert.Equal(8, Strings.LengthOfAString(string1));
            Assert.Equal(9, Strings.LengthOfAString(string2));
        }
        [Fact]
        public void StringInReverseOrderTest()
        {
            // arrange
            string input = "qwerty";
            string expected1 = "ytrewq";
            string input2 = "oe93 kr";
            string expected2 = "rk 39eo";
            //act
            string output1 = Strings.StringInReverseOrder(input);
            string output2 = Strings.StringInReverseOrder(input2);
            //assert
            Assert.Equal(expected1, output1);
            Assert.Equal(expected2, output2);
        }
        [Fact]
        public void NumberOfWordsTest()
        {
            // arrange
            string input1 = "This is sample sentence";
            int expected1 = 4;
            string input2 = "OK";
            int expected2 = 1;
            //act
            int out1 = Strings.NumberOfWords(input1);
            int out2 = Strings.NumberOfWords(input2);
            //assert
            Assert.Equal(expected1, out1);
            Assert.Equal(expected2, out2);
        }
        [Fact]
        public void RevertWordsOrderTest()
        {
            // arrange
            string input = "John Doe";
            string expected1 = "Doe John";
            string input2 = "A, B, C";
            string expected2 = "C B, A,";
            //act
            string out1 = Strings.RevertWordsOrder(input);
            string out2 = Strings.RevertWordsOrder(input2);
            //assert
            Assert.Equal(expected1, out1);
            Assert.Equal(expected2, out2);
        }
        [Fact]
        public void HowManyOccurrencesTest()
        {
            // arrange
            string inputString1 = "do it now";
            string substring1 = "do";
            string inputString2 = "empty";
            string substring2 = "d";
            int expectes1 = 1;
            int expected2 = 0;
            //act
            int actual1 = Strings.HowManyOccurrences(inputString1, substring1);
            int actual2 = Strings.HowManyOccurrences(inputString2, substring2);
            //assert
            Assert.Equal(expectes1, actual1);
            Assert.Equal(expected2, actual2);
        }
        [Fact]
        public void SortCharactersDescendingTest()
        {
            // arrange
            string input1 = "onomatopoeia";
            string input2 = "fohjwf42os";
            string expected1 = "tpoooonmieaa";
            string expected2 = "wsoojhff42";

            //act
            string actual1 = Strings.SortCharactersDescending(input1);
            string actual2 = Strings.SortCharactersDescending(input2);
            //assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);

        }
        [Fact]
        public void CompressStringTest()
        {
            // arrange
            string input1 = "kkkktttrrrrrrrrrr";
            string input2 = "p555ppp7www";
            string expected1 = "k4t3r10";
            string expected2 = "p153p371w3";
            //act
            string actual1 = Strings.CompressString(input1);
            string actual2 = Strings.CompressString(input2);
            //assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }
    }
} 