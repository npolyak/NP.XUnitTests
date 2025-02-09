using Xunit;
using Xunit.Abstractions;

namespace XUnitSample;

public class XUnitTestWithPrinting
{
    private ITestOutputHelper _xunitOutput;

    /// <summary>
    /// pass a test console writer for the test 
    /// (XUnit will provide the correct value itself)
    /// </summary>
    /// <param name="xunitOutput"></param>
    public XUnitTestWithPrinting(ITestOutputHelper xunitOutput)
    {
        _xunitOutput = xunitOutput;
    }

    [Fact]
    public void TestSplit()
    {
        string str = "Hello World";
        string[] split = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Assert.True(split.SequenceEqual(["Hello", "World"]));

        foreach (string part in split)
        {
            // print each part to Test Console
            _xunitOutput.WriteLine(part);
        }
    }
}
