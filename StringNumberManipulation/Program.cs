using System;
using System.Collections.Generic;

namespace StringNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma seperated list of numbers to multiply?");
            

            var usrInput = (Console.ReadLine().Split(','));
            //TODO: Validate the user input so stuff doesn't blow up

            List<int> usrInputList = new List<int>();
            //int[] usrInputArray = new int[usrInput.Length];
            foreach (string value in usrInput)
            {
                usrInputList.Add(Convert.ToInt32(value));
            }

            var multiplyResults = MultiplyNumbers(usrInputList);

            Console.WriteLine($"\nThe answer is: {multiplyResults}");
            Console.WriteLine("\nPress any to exit!");
            Console.ReadLine();
            //var answer = MultiplyNumbers(usrInput);
            
        }

        static int MultiplyNumbers(List<int>numbers)
        {
            var results = 1;
            foreach (int number in numbers)
            {
                results = results * number;
            }
            return results;
        }
    }
}
