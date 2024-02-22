using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
       List<int> numbers = new List<int> {66}; 
        int result = MaxNumber.FindMax(numbers);
        Assert.That(result, Is.EqualTo(66));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int> { 31, 34, 55, 51213, 33 };
        int result = MaxNumber.FindMax(numbers);
        Assert.That(result, Is.EqualTo(51213));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int> {-124, -15, -1, -33 };
        int result = MaxNumber.FindMax(numbers);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int> { -10 ,5, 13, -66, 100 };
        int result = MaxNumber.FindMax(numbers);
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> numbers = new List<int> { -10, 5, 100, 13, -66, 100 };
        int result = MaxNumber.FindMax(numbers);
        Assert.That(result, Is.EqualTo(100));
    }
}
