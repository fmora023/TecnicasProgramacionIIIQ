namespace Controller
{
    /// <summary>
    /// Class in charge of make arthmetic operations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Sums the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Minuses the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        public int Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        /// <summary>
        /// Multiplies the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// Divides the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Cannot divide by zero</exception>
        public double Divide(int value1, int value2)
        {
            if (value2 == 0)
            {
                try
                {
                    throw new System.DivideByZeroException("Cannot divide by zero");
                }
                catch
                {
                    return 0;
                }
            }
            var result = (double)value1 / value2;
            return result;
        }
    }
}
