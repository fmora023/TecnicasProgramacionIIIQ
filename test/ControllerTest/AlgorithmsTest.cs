namespace ControllerTest
{
    using Controller;

    /// <summary>
    /// Test class for <see cref="Algorithms"/>.
    /// </summary>
    [TestClass]
    public class AlgorithmsTest
    {
        /// <summary>
        /// Sums the digits should return sum of digits.
        /// </summary>
        [TestMethod]
        public void SumDigitsShouldReturnSumOfDigits()
        {
            // Arrange
            var input = 1234;

            // Act
            var result = Algorithms.SumDigits(input);

            // Assert
            Assert.AreEqual(10, result);
        }

        /// <summary>
        /// Sums the digits should handle zero scenario.
        /// </summary>
        [TestMethod]
        public void SumDigitsShouldHandleZeroScenario()
        {
            // Arrange
            var input = 0;

            // Act
            var result = Algorithms.SumDigits(input);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
