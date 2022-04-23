using System;
using LaborationInterfaces;
using System.IO;
using System.Collections.Generic;


namespace Olsson_Mikael
{
    public class Laboration_1 : ILaboration_1
    {
        /// <summary>
        /// Returns the number of occurrences of a given number in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <param name="value">The value to search for.</param>
        /// <returns>The number of occurrences of <paramref name="value"/> in <paramref name="inputArray"/>.</returns>
        public uint NOfOccurrences(int[] inputArray, int value)
        {
            uint count = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(n)
            {
                if (inputArray[i] == value) //O(1)
                {
                    count++; //O(1)
                }
            }

            return count; 
        }

        /// <summary>
        /// Returns the maximum difference between two elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The max difference between two elements in the array <paramref name="inputArray"/>.</returns>
        public uint MaxDiff_BruteForce(int[] inputArray)
        {
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

        /// <summary>
        /// Returns the maximum difference between two elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The max difference between two elements in the array <paramref name="inputArray"/>.</returns>
        public uint MaxDiff_Improved(int[] inputArray)
        {
            uint maxDiff = 0;
            int min = 300000000;
            int max = 0;
            if (inputArray.Length > 0)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < min)
                    {
                        min = inputArray[i];
                    }
                    if (inputArray[i] > max)
                    {
                        max = inputArray[i];
                    }
                }
                maxDiff = (uint)(max - min);

            }
            return maxDiff;
        }

        /// <summary>
        /// Reverses the order of the elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be reversed.</param>
        public void ReverseArray(int[] inputArray)
        {
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
        }
        
        /// <summary>
        /// Reverses the order of the elements in an array.
        /// </summary>
        /// <param name="inputArray">The array to be reversed.</param>
        public void ReverseArray_Improved(int[] inputArray)
        {
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
    }
}
