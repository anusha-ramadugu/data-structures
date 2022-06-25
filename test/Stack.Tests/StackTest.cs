using Xunit;
using Xunit.Abstractions;

namespace Stack.Tests;

public class StackTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public StackTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void StackLengthMustBeEqualToNumberOfElementsPushed()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        var expected = 1;
        var actual = stack.Count;
        Assert.Equal(expected, actual);
        Assert.Equal(10, stack.Pop());
        Assert.True(stack.IsEmpty());
    }
    
    [Fact]
    public void PushArray()
    {
        var stack = new Stack<string[]>();
        var arr = new[] { "anusha", "ramadugu" };
        stack.Push(arr);
        var expectedStackLength = 1;
        var actual = stack.Count;
        Assert.Equal(expectedStackLength, actual);
    }
}