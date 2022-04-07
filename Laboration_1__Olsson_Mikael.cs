using System;
using LaborationInterfaces;
using System.IO;
using System.Collections.Generic;


namespace Olsson_Mikael
{
    public class Laboration_1 : ILaboration_1
    {
        List<double> times = new List<double>();
        
        static void Main(string[] args)
        {
            Laboration_1 lab1 = new Laboration_1();
            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                int based = 10000000;
                int increment = 2500000;
                int compare = 3;
                int runs = based + i * increment;
                Console.WriteLine($"Phase {i+1} out of 10, using size {runs}");
                int[] arrayRuns = new int[runs];
                for (int j = 0; j < arrayRuns.Length; j++)
                {
                    arrayRuns[j] = random.Next(0, 250);
                }
                lab1.NOfOccurrences(arrayRuns, compare);
                //lab1.MaxDiff_BruteForce(arrayRuns);
                lab1.MaxDiff_Improved(arrayRuns);
                //lab1.ReverseArray(arrayRuns);
                lab1.ReverseArray_Improved(arrayRuns);
            }

            lab1.writeTimesToFile("../../runTime.csv");

            
            Console.Write("Press enter to exit.");
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
            DateTime startTime = DateTime.Now;
            uint count = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(n)
            {
                if (inputArray[i] == value) //O(1)
                {
                    count++; //O(1)
                }
            }
            DateTime endTime = DateTime.Now; 
            TimeSpan runTime = endTime - startTime; 
            double ms = runTime.TotalMilliseconds; 
            times.Add(ms); 
            Console.WriteLine($"Step 1 done, with elapsed time {ms}");
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
            DateTime startTime = DateTime.Now;
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
            DateTime endTime = DateTime.Now;
            TimeSpan runTime = endTime - startTime;
            double ms = runTime.TotalMilliseconds;
            times.Add(ms);

            Console.WriteLine($"Step 2 done, with elapsed time {ms}");

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
            DateTime startTime = DateTime.Now;
            
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
            
            DateTime endTime = DateTime.Now;
            TimeSpan runTime = endTime - startTime;
            double ms = runTime.TotalMilliseconds;
            times.Add(ms);
            Console.WriteLine($"Step 3 done, with elapsed time {ms}");

            return maxDiff;
        }

        // This would be O(n^2) after we've stripped all constants.

        public void ReverseArray(int[] inputArray)
        {
            DateTime startTime = DateTime.Now;
            
            int i = 1;
            while (i < inputArray.Length)
            {
                int nextValue = inputArray[i];
                int j = i;
                while(j > 0)
                {
                    inputArray[j] = inputArray[j - 1];
                    j--;
                }
                inputArray[0] = nextValue;
                i++;
            }
            
            DateTime endTime = DateTime.Now;
            TimeSpan runTime = endTime - startTime;
            double ms = runTime.TotalMilliseconds;
            times.Add(ms);
            Console.WriteLine($"Step 4 done, with elapsed time {ms}");
        }

        // This would be O(n) after we've stripped all constants.

        public void ReverseArray_Improved(int[] inputArray)
        {
            DateTime startTime = DateTime.Now;
            
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

            DateTime endTime = DateTime.Now;
            TimeSpan runTime = endTime - startTime;
            double ms = runTime.TotalMilliseconds;
            times.Add(ms);
            Console.WriteLine($"Step 5 done with elapsed time {ms}");
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

        public void writeTimesToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (double time in times)
                {
                    writer.WriteLine(time);
                }
            }
        }

    }
}
