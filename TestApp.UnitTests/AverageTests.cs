using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        int[] numbers = { 1, 2, 3 };

        double result = Average.CalculateAverage(numbers);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        int[] numbers = {-1, -2, -3 };
        double result = Average.CalculateAverage(numbers);
        Assert.That(result, Is.EqualTo(-2));

    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        int[] numbers = { 2, 3, -5, -10, -1, 15 };
        double result = Average.CalculateAverage(numbers);  
        Assert.That(result , Is.EqualTo(0.6666666666666666d));
    }
}
