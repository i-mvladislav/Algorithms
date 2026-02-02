namespace Algorithms.Tests;

public class BreadthFirstSearchTests
{
    /// <summary>
    /// Буква m на конце означает что это продавец манго (находим ближайшего для start), можно менять на другие имена
    /// </summary>
    public static IEnumerable<object[]> TestData()
    {
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
        const string start = "я";
        var expected = new[] { "ануджm", "боб", "я" };
        yield return [graph, start, expected];
    }
    
    [TestCaseSource(nameof(TestData))]
    public void searching_on_any_element_gives_the_expected_result(Dictionary<string, string[]> graph, string start, string[] expected)
    {
        // Arrange & Act
        var result = BreadthFirstSearch.Implementation.BfsSearch(graph, start, "m");
        
        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}