using System;
using MathTDD;
using Xunit;

namespace TestMathTDD {
    public class TestMyMath {
        [Fact]
        public void ShouldAddNumbers()
        {
            Assert.Equal(5, MyMath.Add(2, 3)); 
        }

        [Fact]
        public void ShouldMultiplyNumbers()
        {
            Assert.Equal(6, MyMath.Multiply(2, 3));
        }

        [Fact]
        public void ShouldSubtractNumbers()
        {
            Assert.Equal(8, MyMath.Subtract(13, 5));
        }
        // Comment
        //THIS WILL BREAK mwahAhAHA
        // Another Comment
        //Cmon, I don't want this to work
    }
}
