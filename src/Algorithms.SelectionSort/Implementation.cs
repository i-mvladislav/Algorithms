namespace Algorithms.SelectionSort;

public static class Implementation
{
    /// <summary>
    /// Сортировка выбором
    /// Время выполнения по нотации О большое: O(n * 1/2 * n) or O(n * n)
    /// </summary>
    public static T[] SelectionSort<T>(this IList<T> collection) where T : IComparable<T>
    {
        List<T> result = [];
        var bufferCollection = collection.ToList();
        while (bufferCollection.Count > 0)
        {
            var smallestIndex = FindSmallestIndex(bufferCollection);
            var smallest = bufferCollection[smallestIndex];
            result.Add(smallest);
            bufferCollection.Remove(smallest);
        }

        return result.ToArray();
    }

    private static int FindSmallestIndex<T>(IList<T> collection) where T : IComparable<T>
    {
        var smallestIndex = 0;
        var smallest = collection[smallestIndex];
        
        for (var index = 0; index < collection.Count; index++)
        {
            var compareResult = collection[index].CompareTo(smallest);
            if (compareResult < 0)
            {
                smallestIndex = index;
                smallest = collection[smallestIndex];
            }
        }
        
        return smallestIndex;
    }
}