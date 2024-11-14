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

        /// <summary>
        /// Calculators the should rest elements.
        /// </summary>
        [TestMethod]
        public void CalculatorShouldRestElements()
        {
            // given 
            var calculator = new Calculator();

            // when
            var result = calculator.Minus(42, 32);

            // then
            Assert.AreEqual(10, result);
        }

        /// <summary>
        /// Calculator should mul elements.
        /// </summary>
        [TestMethod]
        public void CalculatorShouldMulElements()
        {
            // given
            var calculator = new Calculator();

            // when
            var result = calculator.Multiply(100, 15);

            // then
            Assert.AreEqual(1500, result);
        }

        /// <summary>
        /// Calculators the should div elements.
        /// </summary>
        [TestMethod]
        public void CalculatorShouldDivElements()
        {
            // given
            var calculator = new Calculator();

            // when
            var result = calculator.Divide(100, 10);

            // then
            Assert.AreEqual(10, result);
        }

        /// <summary>
        /// Calculator should throw exception when dividing elements.
        /// </summary>
        [TestMethod]
        public void CalculatorShouldThrowExceptionWhenDivElements()
        {
            // given
            var calculator = new Calculator();

            // when
            var result =  calculator.Divide(7, 2);

            // then
            Assert.AreEqual(3.5, result);

        }
    }
}