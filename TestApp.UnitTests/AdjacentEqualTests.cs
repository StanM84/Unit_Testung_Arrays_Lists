using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noAdjacentEqualNumbers = new() { 1, 2, 3, 4, 5, 1 };

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualNumbers);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5 1"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjacentEqualNumbers = new() { 1, 2, 2, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(adjacentEqualNumbers);

        // Assert
        Assert.That(result, Is.EqualTo("1 8 3 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> allNumbersAreAdjacentEqual = new() { 1, 1, 2, 4 };

        // Act
        string result = AdjacentEqual.Sum(allNumbersAreAdjacentEqual);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjacentEqualNumbersAtBeginning = new() { 1, 1, 1, 1, 4 };

        // Act
        string result = AdjacentEqual.Sum(adjacentEqualNumbersAtBeginning);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjacentEqualNumbersAtEnd = new() { 4, 1, 1, 1, 1 };

        // Act
        string result = AdjacentEqual.Sum(adjacentEqualNumbersAtEnd);

        // Assert
        Assert.That(result, Is.EqualTo("8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> adjacentEqualNumbersInMiddle = new() { 4, 1, 1, 3 };

        // Act
        string result = AdjacentEqual.Sum(adjacentEqualNumbersInMiddle);

        // Assert
        Assert.That(result, Is.EqualTo("4 2 3"));
    }
}
