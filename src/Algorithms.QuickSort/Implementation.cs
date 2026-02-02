namespace Algorithms.QuickSort;

public static class Implementation
{
    /// <summary>
    /// Время выполнения по нотации О большое: O(n log n)
    /// </summary>
    public static T[] QuickSort<T>(this IList<T> collection) where T : IComparable<T>
    {
        if (collection.Count < 2)
        {
            return collection.ToArray();
        }
        else
        {
            var pivot = collection[0];
            var less = collection.Where(item => item.CompareTo(pivot) < 0).ToArray();
            var greater = collection.Where(item => item.CompareTo(pivot) > 0).ToArray();
            return less.QuickSort().Concat([pivot]).Concat(greater.QuickSort()).ToArray();
        }
    }
}