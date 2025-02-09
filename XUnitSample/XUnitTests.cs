using Xunit;

namespace XUnitSample;

public class XUnitTests
{
    // fact sample
    [Fact]
    public void TestSplit()
    {
        string str = "Hello World";
        string[] split = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // assert that the split is a collection of two strings:
        // "Hello" and "World"
        Assert.True(split.SequenceEqual(["Hello", "World"]));
    }

    /// <summary>
    /// Run TestSplits(...) methods for every [InlineData] 
    /// providing various arguments.
    /// </summary>
    [Theory]
    [InlineData("Hello", new string[] { "Hello" })]
    [InlineData("Hello World", new string[] { "Hello", "World" })]
    [InlineData("Hello Great World", new string[] { "Hello", "Great", "World" })]
    public void TestSplits(string strToSplit, IEnumerable<string> expectedSplit)
    {
        string[] split = strToSplit.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Assert.True(split.SequenceEqual(expectedSplit));
    }
}