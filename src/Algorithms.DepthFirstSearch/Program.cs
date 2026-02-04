namespace Algorithms.DepthFirstSearch;

class Program
{
    static void Main(string[] args)
    {
        // m на конце имени означает продавец манго
        var tree = new Dictionary<string, string[]>()
        {
            { "я", ["боб", "клэр", "алиса"] },
            { "боб", ["ануджm", "пегги"] },
            { "клэр", ["томm", "джонни"] },
            { "алиса", [] },
            { "ануджm", [] },
            { "пегги", [] },
            { "томm", [] },
            { "джонни", [] }
        };
        
        Implementation.DfsSearch(tree, "я");
    }
}