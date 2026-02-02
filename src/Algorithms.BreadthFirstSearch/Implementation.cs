namespace Algorithms.BreadthFirstSearch;

public static class Implementation
{
    /// <summary>
    /// Поиск в ширину, нахождение кратчайшего пути
    /// Время выполнения по нотации О большое: О (V * N) где количество вершин * рёбер
    /// </summary>
    public static List<string>? BfsSearch(Dictionary<string, string[]> graph, string start, string targetSuffix)
    {
        var visited = new HashSet<string>();
        var queue = new Queue<string>();
        var parent = new Dictionary<string, string>();
        
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            var nextItem = queue.Dequeue();
            if (nextItem.EndsWith(targetSuffix))
                break;

            foreach (var to in graph.GetValueOrDefault(nextItem, []))
            {
                if (!visited.Add(to))
                    continue;

                queue.Enqueue(to);
                parent[to] = nextItem;
            }
        }

        if (!visited.Any(item => item.EndsWith(targetSuffix)))
            return null;

        var result = new List<string>();
        var target = parent.First(item => item.Key.EndsWith(targetSuffix));
        for (var item = target.Key; item != start; item = parent[item])
            result.Add(item);
        result.Add(start);
        return result;
    }
}