namespace AlgorithmsTest
{
    using Algorithms;

    /// <summary>
    /// Test for <see cref="QuizAlgorithms"/>.
    /// </summary>
    [TestClass]
    public class QuizAlgorithmsTest
    {
        /// <summary>
        /// Determines whether [is palindrome should return true].
        /// </summary>
        [TestMethod]
        [DataRow("ana")]
        [DataRow("ana lava Lana")]
        public void IsPalindromeShouldReturnTrue(string input)
        {
            // Arrange
            var quizAlgorithms = new QuizAlgorithms();

            // Act
            var result = quizAlgorithms.IsPalindrome(input);
            
            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Determines whether [is palindrome should return false].
        /// </summary>
        [TestMethod]
        public void IsPalindromeShouldReturnFalse()
        {
            // Arrange
            var quizAlgorithms = new QuizAlgorithms();
            var input = "lava";

            // Act
            var result = quizAlgorithms.IsPalindrome(input);
            
            // Assert
            Assert.IsFalse(result);
        }
    }
}
