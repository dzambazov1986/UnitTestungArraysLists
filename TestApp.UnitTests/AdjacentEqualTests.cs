using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();
        string result = AdjacentEqual.Sum(emptyList);
        Assert.That(result, Is.EqualTo(string.Empty));
   
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        List<int> numbers = new List<int>{1, 2, 3, 4, 5};
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 5 };
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("1 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        List<int> numbers = new List<int> { 2, 2, 2 ,2};
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("8"));
  }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {

        List<int> numbers = new List<int> { 1, 1, 4, 8 };
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("2 4 8"));


    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {

        List<int> numbers = new List<int> {32, 13, 24 ,24 };
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("32 13 48"));



    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        List<int> numbers = new List<int> {17 ,190, 10, 10, 13, 18 };
        string result = AdjacentEqual.Sum(numbers);
        Assert.That(result, Is.EqualTo("17 190 20 13 18"));
    }
}
