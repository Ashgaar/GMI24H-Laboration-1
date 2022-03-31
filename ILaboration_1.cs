namespace LaborationInterfaces
{
    public interface ILaboration_1
    {
        #region Uppgift 1
        /// <summary>
        /// See laboration instructions.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <param name="value">The value to search for.</param>
        /// <returns>The number of occurrences of <paramref name="value"/> in <paramref name="inputArray"/>.</returns>
        uint NOfOccurrences(int[] inputArray, int value);
        #endregion

        #region Uppgift 2
        /// <summary>
        /// See laboration instructions.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The largest difference between elements in <paramref name="inputArray"/>.</returns>
        uint MaxDiff_BruteForce(int[] inputArray);

        /// <summary>
        /// See laboration instructions.
        /// </summary>
        /// <param name="inputArray">The array to be searched.</param>
        /// <returns>The largest difference between elements in <paramref name="inputArray"/>.</returns>
        uint MaxDiff_Improved(int[] inputArray);
        #endregion

        #region Uppgift 3
        /// <summary>
        /// See laboration instructions.
        /// </summary>
        /// <param name="inputArray">The array to be reversed.</param>
        /// <returns>An array with the elements in reversed order.</returns>
        void ReverseArray(int[] inputArray);

        /// <summary>
        /// See laboration instructions.
        /// </summary>
        /// <param name="inputArray">The array to be reversed.</param>
        /// <returns>An array with the elements in reversed order.</returns>
        void ReverseArray_Improved(int[] inputArray);
        #endregion
    }
}
