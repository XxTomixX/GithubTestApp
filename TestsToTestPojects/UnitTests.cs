using System;
using Xunit;
using TestowaBiblioteka;

namespace TestsToTestPojects
{
    public class UnitTests
    {
        [Fact]
        public void TrueTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, MathCalculations.Add(2, 2));
        }

        [Fact]
        public void SubTest()
        {
            Assert.Equal(4, MathCalculations.Substract(6, 2));
        }

        [Fact]
        public void ExceptionTest()
        {
            Assert.Equal(4, MathCalculations.Substract(6, 2));
        }

    }
}
