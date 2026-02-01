namespace Algorithms.BinarySearch;

class Program
{
    static void Main(string[] args)
    {
        int[] test = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        Console.WriteLine(test.CustomBinarySearch(1));
        Console.WriteLine(test.CustomBinarySearch(2));
        Console.WriteLine(test.CustomBinarySearch(3));
        Console.WriteLine(test.CustomBinarySearch(4));
        Console.WriteLine(test.CustomBinarySearch(5));
        Console.WriteLine(test.CustomBinarySearch(6));
        Console.WriteLine(test.CustomBinarySearch(7));
        Console.WriteLine(test.CustomBinarySearch(8));
        Console.WriteLine(test.CustomBinarySearch(9));
        Console.WriteLine(test.CustomBinarySearch(10));
    }
}