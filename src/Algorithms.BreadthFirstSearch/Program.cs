namespace Algorithms.BreadthFirstSearch;

class Program
{
    static void Main(string[] args)
    {
        // m на конце имени означает продавец манго (можно ставить на другие имена и алгоритм найдёт ближайшего продавца манго)
        var graph = new Dictionary<string, string[]>()
        {
            { "я", ["боб", "клэр", "алиса"] },
            { "боб", ["ануджm", "пегги"] },
            { "алиса", ["пегги"] },
            { "клэр", ["томm", "джонни"] },
            { "ануджm", [] },
            { "пегги", [] },
            { "томm", [] },
            { "джонни", [] }
        };
        Console.WriteLine(string.Join(", ", Implementation.BfsSearch(graph, "я", "m")!));
    }
}