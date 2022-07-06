namespace Calculator.Tests
{
    public class MathOperationsTests
    {
        [Fact]
        public void SimpleAdditionTest()
        {
            // Arrange
            //double expected = 7;

            // Act
            //double actual = MathOperations.Addition(4, 3);

            // Assert
            Assert.Equal(4 + 3, MathOperations.Addition(4, 3));
        }

        [Fact]
        public void ArrayAdditionTest()
        {
            // Arrange
            double expected = 30;
            double[] arrayOfDoubles = new double[] { 10, 5, 15 };

            // Act
            double actual = MathOperations.Addition(arrayOfDoubles);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleSubtractionTest()
        {
            // Arrange
            double expected = 7;

            // Act
            double actual = MathOperations.Subtraction(10, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArraySubtractionTest()
        {
            // Arrange
            double expected = -30;
            double[] arrayOfDoubles = new double[] { 10, 5, 15 };

            // Act
            double actual = MathOperations.Subtraction(arrayOfDoubles);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleMultiplicationTest()
        {
            // Arrange
            double expected = 7;

            // Act
            double actual = MathOperations.Multiplication(2, 3.5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleDivisionTest()
        {
            // Arrange
            double expected = 7;

            // Act
            double actual = MathOperations.Division(14, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivisionTestDividedByZero()
        {
            // Arrange
            double expected = 14 / 0.0;

            // Act
            double actual = MathOperations.Division(120, 0.0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}