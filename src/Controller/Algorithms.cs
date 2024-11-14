namespace Controller
{
    /// <summary>
    /// Some algoritms to be tested in class.
    /// </summary>
    public class Algorithms
    {
        /// <summary>
        /// Sums the digits of the input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the sum of the digits</returns>
        public static int SumDigits(int input)
        {
            if (input == 0)
            {
                return -1;
            }

            var sum = 0;
            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Gets the menor element in a list.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the minor element.</returns>
        public static int GetMenor(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                throw new ArgumentException("The input is null or empty");
            }

            var result = input[0];
            for (var index = 1; index < input.Count; index++)
            {
                if (input[index] < result)
                {
                    result = input[index];
                }
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified input is palindrome.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(string input)
        {
            return false;
        }
    }
}
