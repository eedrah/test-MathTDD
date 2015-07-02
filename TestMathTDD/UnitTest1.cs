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
    }
}
