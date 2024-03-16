using System;

namespace OOPLesson00.App.Console.Interface
{
    public interface IPrimeFactor
    {
        /// <summary>
        /// This method returns the prime factors/factor of <paramref name="number"/>.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The positive prime factors.</returns>
        int[] Get(int number);
    }
}