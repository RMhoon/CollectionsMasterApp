using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var numArray = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numArray, 0, 50);

            //Print the first number of the array
            Console.WriteLine(numArray[0]);


            //Print the last number of the array            
            Console.WriteLine(numArray[numArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numArray.Reverse());

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numArray);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"The list has {intList.Count} number of items.");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList, 0, 50, 50);

            //Print the new capacity
            Console.WriteLine($"The list has {intList.Count} number of items.");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var searchNumber = int.Parse(Console.ReadLine());
            NumberChecker(intList, searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Remove Odds Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            intList.Sort();

            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] newArray = intList.ToArray();
            Console.WriteLine($"The new array has {newArray.Length} number of items.");

            //Clear the list
            intList.Clear();
            Console.WriteLine($"The list has {intList.Count} number of items after the clear.");
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                    numbers[i] = 0;
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            var tmpList = new List<int>();
            foreach(var number in numberList)
            {
                if (number % 2 != 0)
                    tmpList.Add(number);
            }
            foreach(var remNumber in tmpList)
                numberList.Remove(remNumber);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
                Console.WriteLine($"Your number {searchNumber} was found in the list.");
            else
                Console.WriteLine($"Your number {searchNumber} was not found in the list.");
        }

        private static void Populater(List<int> numberList, int lowerLimit, int upperLimit, int totalNumbers)
        {
            Random rng = new Random();

            for (int i = 1; i <= totalNumbers; i++)
                numberList.Add(rng.Next(lowerLimit, upperLimit));
        }

        private static void Populater(int[] numbers, int lowerLimit, int upperLimit)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(lowerLimit, upperLimit);
            }
    
        }        

        private static void ReverseArray(int[] array)
        {
            for(int i = array.Length - 1; i >=0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
