namespace Algorithms.BinarySearch;

public static class Implementation
{
    /// <summary>
    /// Время выполнения по нотации О большое: O(log n)
    /// </summary>
    public static int? CustomBinarySearch<T>(this IList<T> collection, T value) where T : IComparable<T>
    {
        var low = 0;
        var high = collection.Count - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = collection[mid];
            var compareResult = guess.CompareTo(value);
            switch (compareResult)
            {
                case 0: return mid;
                case > 0: high = mid - 1; break;
                default: low = mid + 1; break;
            }
        }

        return null;
    }
}