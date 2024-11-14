namespace ControllerTest
{
    using Controller;

    /// <summary>
    /// Test for <see cref="Calculator"/>.
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        /// <summary>
        /// Calculators the should sum elements.
        /// </summary>
        [TestMethod]
        public void CalculatorShouldSumElements()
        {
            // Arrange => Given
            var calculator = new Calculator();

            // Act => When
            var result = calculator.Sum(24, 47);
                
            // Assert => Then
            Assert.AreEqual(71, result);
        }
    }
}