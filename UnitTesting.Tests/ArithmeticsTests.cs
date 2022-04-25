using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions.Ordering;

namespace UnitTesting.Tests
{
    [Order(4)]
    public class ArithmeticsTests
    {
        [Theory]
        [InlineData(5.0, 3.0)]
        [InlineData(2.5, 1.2)]
        [InlineData(2, 2)]
        [InlineData(double.MaxValue, double.MaxValue)]
        [Order(1)]
        public async Task Add_ValidValues_ValidResult(double a, double b)
        {
            // Arrange
            var expected = a + b;

            // Act
            var result = Arithmetics.Add(a, b);
            await Task.Delay(2000);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        [Order(3)]
        public async Task Substract_ValidValues_ValidResult()
        {
            // Arrange
            double a = 10;
            double b = 5;
            double expected = 10 - 5;

            // Act
            var result = Arithmetics.Substract(a, b);
            await Task.Delay(2000);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        [Order(2)]
        public async Task Divide_InvalidValues_ExceptionThrown()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() =>
                Arithmetics.Divide(a, b));
            await Task.Delay(2000);
        }
    }
}
