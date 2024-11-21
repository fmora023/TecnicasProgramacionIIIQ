using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// New algorithms to be tested.
    /// </summary>
    public static class NewAlgorithms
    {
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
        public static int Factorial(int number)
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
        public static string ToTitleCase(string input)
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
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.ArgumentException">Year must be a positive number</exception>
        public static bool IsLeapYear(int year)
        {
            if (year <= 0)
            { 
                throw new ArgumentException("Year must be a positive number");
            }

            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
