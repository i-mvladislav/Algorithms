using Algorithms.SelectionSort;

namespace Algorithms.Tests;

public class SelectionSortTests
{
    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }];
    }
    [TestCaseSource(nameof(TestData))]
    public void sorting_on_any_element_gives_the_expected_result(int[] values, int[] expected)
    {
        // Arrange & Act
        var result = values.SelectionSort();
        
        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}