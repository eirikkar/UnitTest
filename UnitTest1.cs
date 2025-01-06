namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

    [Fact]
    public void TestStringArray()
    {
        string[] expected = new string[255];
        Assert.Equal(StringArray(expected), expected);
    }

    int Add(int x, int y) => x + y;

    string[] StringArray(string[] arr) => arr;
}
