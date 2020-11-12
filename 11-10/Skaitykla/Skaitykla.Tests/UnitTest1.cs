using Skaitykla.Services;
using Skaitykla.Services.Interfaces;
using System;
using Xunit;
using Moq;
namespace Skaitykla.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arange
            int expectedResult = 4;

            //act
            var actualResult = Kvadratu(2);
      
            
            //assert
            Assert.Equal(expectedResult, actualResult);
        }



        public int Kvadratu(int n)
        {
            return n * n;
        }
    }
}
