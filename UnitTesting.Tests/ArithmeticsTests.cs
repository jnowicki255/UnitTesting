using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting.Tests
{
    public class ArithmeticsTests
    {
        [Theory]
        [InlineData(5.0, 3.0)]
        [InlineData(2.5, 1.2)]
        [InlineData(2, 2)]
        [InlineData(double.MaxValue, double.MaxValue)]
        public void Add_ValidValues_ValidResult(double a, double b)
        {
            // Arrange
            var expected = a + b;

            // Act
            var result = Arithmetics.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        public void Divide_InvalidValues_ExceptionThrown()
        {

        }
    }
}
