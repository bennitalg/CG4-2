using System;

namespace CG4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare, assign and initialize the array of numbers
            int[] numbers = new int[6]{ 1, 1, 2, 3, 5, 8 };
            //display the values with a foreach loop
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

        }
    }
}
