using LeetCode.SourceCode.Easy;

namespace LeetCode.Tests.Easy;

public class ValidParenthesesTest
{
    private readonly ValidParenthesesSolution solution=new();
    
    [Fact]
    public void TestIsValid1()
    {
        Assert.True(solution.IsValid("()"));
    }
    
    [Fact]
    public void TestIsValid2()
    {
        Assert.True(solution.IsValid("()[]{}"));
    }
    
    [Fact]
    public void TestIsValid3()
    {
        Assert.True(solution.IsValid("{[]}"));
    }
    
    [Fact]
    public void TestIsValid4()
    {
        Assert.False(solution.IsValid("(]"));
    }
    
    [Fact]
    public void TestIsValid5()
    {
        Assert.False(solution.IsValid("([)]"));
    }
    
    [Fact]
    public void TestIsValid6()
    {
        Assert.False(solution.IsValid("]"));
    }

    [Fact]
    public void TestIsValid7()
    {
        Assert.False(solution.IsValid("([]){"));
    }

    [Fact]
    public void TestIsValid8()
    {
        Assert.False(solution.IsValid("([]"));
    }
}