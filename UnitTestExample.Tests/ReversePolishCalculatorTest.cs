using System;
using Xunit;

namespace UnitTestExample.Tests;

public class ReversePolishCalculatorTest
{
    [Fact]
    public void Test_Add()
    {
        var sut = new ReversePolishCalculator(new[] { "2", "3", "+" });

        var result = sut.Calculate();

        Assert.Equal(5, result);
    }

    [Fact]
    public void Test_Subtract()
    {
        var sut = new ReversePolishCalculator(new[] { "2", "3", "-" });

        var result = sut.Calculate();

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_Multiply()
    {
        var sut = new ReversePolishCalculator(new[] { "2", "5", "*" });

        var result = sut.Calculate();

        Assert.Equal(10, result);
    }

    [Fact]
    public void Test_Divide()
    {
        var sut = new ReversePolishCalculator(new[] { "5", "10", "/" });

        var result = sut.Calculate();

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_Complex()
    {
        var sut = new ReversePolishCalculator(new[] { "10", "5", "+", "6", "*" });

        var result = sut.Calculate();

        Assert.Equal(90, result);
    }
}