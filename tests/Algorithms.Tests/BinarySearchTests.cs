using Algorithms.BinarySearch;

namespace Algorithms.Tests;

public class BinarySearchTests
{
    [TestCase(1, 0)]
    [TestCase(2, 1)]
    [TestCase(3, 2)]
    [TestCase(4, 3)]
    [TestCase(5, 4)]
    [TestCase(6, 5)]
    [TestCase(7, 6)]
    [TestCase(8, 7)]
    [TestCase(9, 8)]
    [TestCase(10, null)]
    public void sorting_on_any_element_gives_the_expected_result(int value, int? expected)
    {
        // Arrange 
        int[] elements = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        
        // Act
        var index = elements.CustomBinarySearch(value);
        
        // Assert
        Assert.That(index, Is.EqualTo(expected));
    }
}