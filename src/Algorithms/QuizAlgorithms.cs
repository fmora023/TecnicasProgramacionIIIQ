namespace Algorithms
{
    /// <summary>
    /// Some algorithms to be tested in the quiz #2.
    /// </summary>
    public class QuizAlgorithms
    {
        /// <summary>
        /// Sums the digits of the input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>the sum of the digits</returns>
        public int SumDigits(int input)
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
        public int GetMenor(List<int> input)
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
        /// ana => ana => true
        /// lava => aval => false
        /// mama => amam => false
        /// 
        /// ana lava la casa => asacaalavalana => false.
        /// 
        /// analavalana => analavalana => true.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPalindrome(string input)
        {
            input = input.Replace(" ", string.Empty).ToLower();
            for (var i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Factorials the specified number.
        /// 
        /// Test: 
        /// Factorial de 0 debe ser 1.
        /// Factorial de 1 debe ser 1.
        /// Factorial de 5 debe ser 120.
        /// Llamar con un número negativo debe lanzar una excepción.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Number must be non-negative</exception>
        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative");
            }
            if (number == 0 || number == 1)
            {
                return 1;
            }

            var result = 1;
            for (var i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Converts to titlecase.
        /// 
        /// Casos de prueba.
        /// "hello world" debe devolver "Hello World".
        /// "C# PROGRAMMING" debe devolver "C# Programming".
        /// Cadena vacía o nula debe devolver una cadena vacía.
        /// " multiple spaces " debe devolver "Multiple Spaces".
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var words = input.ToLower().Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// 
        /// 2000 debe devolver true (divisible entre 400).
        /// 1900 debe devolver false (divisible entre 100 pero no entre 400).
        /// 2024 debe devolver true (divisible entre 4 pero no entre 100).
        /// 2023 debe devolver false
        /// excepcion. Llamar con un año negativo debe lanzar una excepción.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.ArgumentException">Year must be a positive number</exception>
        public bool IsLeapYear(int year)
        {
            if (year <= 0)
            {
                throw new ArgumentException("Year must be a positive number");
            }

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}