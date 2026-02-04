namespace Algorithms.DepthFirstSearch;

public static class Implementation
{
    public static void DfsSearch(Dictionary<string, string[]> tree, string root)
    {
        foreach (var node in tree[root])
        {
            if (node.EndsWith("m"))
            {
                Console.WriteLine($"Продавец манго: {node}");
            }
            else
                DfsSearch(tree, node);
        }
    }
}