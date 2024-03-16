using System;
using OOPLesson00.App.Console.Interface;
using OOPLesson001.App.Console.Concrete;

namespace OOPLesson001
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 105;
            IPrimeFactor primeFactor = new PrimeFactor();
            Console.WriteLine($"Prime factors of {number}: {string.Join(", ", primeFactor.Get(number))}");
        }
    }
}