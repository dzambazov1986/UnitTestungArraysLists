using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
       List<int> numbers = new List<int> { 15};
        List<int> result = GaussTrick.SumPairs(numbers);
        CollectionAssert.AreEqual(numbers, result);     
            
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40};
        List<int> result = GaussTrick.SumPairs(numbers);
        List<int> expected = new List<int> { 50, 50};
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        List<int> result = GaussTrick.SumPairs(numbers);
        List<int> expected = new List<int> { 60, 60, 30};
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> numbers = new List<int> { 3, 2, 10, 15, 6, 13, 27 };
        List<int> result = GaussTrick.SumPairs(numbers);
        List<int> expected = new List<int> { 30, 15, 16, 15 };
        CollectionAssert.AreEqual(expected, result);
    }
}
