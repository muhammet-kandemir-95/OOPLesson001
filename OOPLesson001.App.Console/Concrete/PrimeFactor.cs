using System;
using OOPLesson00.App.Console.Interface;

namespace OOPLesson001.App.Console.Concrete
{
    public class PrimeFactor : IPrimeFactor
    {
        /// <summary>
        /// Get the absolute of <paramref name="number"/>.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Absolute value.</returns>
        public int Abs(int number)
        {
            return Math.Abs(number);
        }

        /// <inheritdoc />
        public int[] Get(int number)
        {
            if (number == 0)
                return new int[0];

            int posNumber = this.Abs(number);

            List<int> factors = new List<int>();

            if (posNumber % 2 == 0)
            {
                factors.Add(2);
            }

            for (int i = 3; i <= posNumber; i += 2)
            {
                if (this.IsPrime(i) && posNumber % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors.ToArray();
        }

        /// <summary>
        /// This methods checks the positive number is prime.
        /// <br />
        /// <b><paramref name="posNumber"/> must be either 0 or positive.</b>
        /// </summary>
        /// <param name="posNumber">The positive number.</param>
        /// <returns>If it is prime, true. Otherwise, false.</returns>
        public bool IsPrime(int posNumber)
        {
            if (posNumber < 0)
            {
                throw new ArgumentException("posNumber must be either 0 or positive!");
            }

            if (posNumber > 2 && posNumber % 2 == 0)
                return false;

            for (int i = 3; i * i <= posNumber; i += 2)
            {
                if (posNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}