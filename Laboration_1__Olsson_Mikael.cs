using System;
using LaborationInterfaces;
using System.IO;

//Namnge namespace med ditt namn. Till exempel: Land_Rikard
namespace Olsson_Mikael
{
    //Byt X mot laborationens nummer. Till exempel: Laboration_1 : ILaboration_1
    public class Laboration_1 : ILaboration_1
    {
        //Ange funktionssignaturer enligt interfacet.
        //Detta exempel kommer från Laboration 1.
        static void Main(string[] args)
        {
            var lab1 = new Laboration_1();

            
            int[] arr = new int[10] { 1, 3, 4, 2, 1, 3, 1, 3, 4, 3 };
            int i = 3;
            var start = lab1.start();
            Console.WriteLine(lab1.NOfOccurrences(arr, i));
            var stop = lab1.stop();
            var ms = lab1.executionTime(start, stop);
            

            var startMaxDiff = lab1.start();
            int[] arr2 = new int[7] { 7, 4, 9, 2, 6, 1, 3 };
            Console.WriteLine(lab1.MaxDiff_BruteForce(arr2));
            Console.WriteLine(lab1.MaxDiff_Improved(arr2));

            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            lab1.ReverseArray(arr3);

            Console.Write("Press any key to exit.");
            Console.ReadLine();
        }

        /* Pseudo code
         * counter = 0
         * for each element in array
         *  if element == i
         *      counter ++
         */

        // This would be O(n) after we've stripped all constants.
        
        /// <summary>
        /// Returns the number of occurrences of a given number in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <param name="value">The value to search for.</param>
        /// <returns>The number of occurrences of <paramref name="value"/> in <paramref name="inputArray"/>.</returns>
        public uint NOfOccurrences(int[] inputArray, int value)
        {
            //loop of the array and count the number of occurences of the value
            uint count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == value)
                {
                    count++;
                }
            }
            
            return count;
        }


        /*  Pseudo code
         *  maxDiff = 0
         *  for each element in array
         *      for each element + 1 in array
         *          if element - element + 1 > maxDiff
         *              maxDiff = element - element + 1
         */

        // This would be O(n^2) after we've stripped all constants.

        /// <summary>
        /// Returns the maximum difference between two elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The max difference between two elements in the array <paramref name="inputArray"/>.</returns>
        public uint MaxDiff_BruteForce(int[] inputArray)
        {
            //loop over the array and find the max difference between two numbers
            uint maxDiff = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (Math.Abs(inputArray[i] - inputArray[j]) > maxDiff)
                    {
                        maxDiff = (uint)Math.Abs(inputArray[i] - inputArray[j]);
                    }
                }
            }
            
            return maxDiff;
        }

        /*  Pseudo code
         *  maxDiff = 0
         *  for each element in array
         *      for each element + 1 in array
         *          if element - element + 1 > maxDiff
         *              maxDiff = element - element + 1
         */

        //This would be O(n) after we've stripped all constants.

        /// <summary>
        /// Returns the maximum difference between two elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The max difference between two elements in the array <paramref name="inputArray"/>.</returns>
        public uint MaxDiff_Improved(int[] inputArray)
        {
            //loop over the array and find the max difference between two numbers but do the calculate at the end
            uint maxDiff = 0;
            uint min = (uint)inputArray[0];
            uint max = (uint)inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                {
                    min = (uint)inputArray[i];
                }
                if (inputArray[i] > max)
                {
                    max = (uint)inputArray[i];
                }
            }
            maxDiff = max - min;
            return maxDiff;
        }

        // This would be O(n) after we've stripped all constants.

        public void ReverseArray(int[] inputArray)
        {
            //reverset the array as inefficiently as possible
            int[] reversedArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                reversedArray[i] = inputArray[inputArray.Length - 1 - i];
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = reversedArray[i];
            }

        }
        
        // This would be O(n) after we've stripped all constants.

        public void ReverseArray_Improved(int[] inputArray)
        {
            //reverse the array as efficiently as possible
            int i = 0;
            int j = inputArray.Length - 1;
            while (i < j)
            {
                int temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
                i++;
                j--;
            }
        }

        public DateTime start()
        {
            DateTime startTime = DateTime.Now;
            return startTime;
        }

        public DateTime stop()
        {
            DateTime stopTime = DateTime.Now;
            return stopTime;
        }

        
        public double executionTime(DateTime startTime, DateTime stopTime)
        {
            TimeSpan executionTime = stopTime - startTime;
            double ms = executionTime.TotalMilliseconds;
            
            return ms;
        }

    }
}
