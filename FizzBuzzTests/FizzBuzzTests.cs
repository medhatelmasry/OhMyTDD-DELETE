using FizzBuzzLibrary;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Fact]
    public void Given2Returns2()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(2);
        string expected = "2";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given3ReturnsFizz()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(3);
        string expected = "Fizz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given4Returns4()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(4);
        string expected = "4";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5ReturnsBuzz()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(5);
        string expected = "Buzz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given15ReturnsFizzBuzz()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(15);
        string expected = "FizzBuzz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given0ReturnsFizzBuzz()
    {
        FizzBuzz fb = new();
        string actual = fb.GetResult(0);
        string expected = "FizzBuzz";
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void GivenNegativeNumberThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(-19);
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void GivenNumberGreaterThan10000ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(10001);
        Assert.Throws<Exception>(act);
    }

}
