namespace Algorithms.QuickSort;

class Program
{
    static void Main(string[] args)
    {
        var input = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        var result = input.QuickSort();
        Console.WriteLine(string.Join(", ", result));
    }
}