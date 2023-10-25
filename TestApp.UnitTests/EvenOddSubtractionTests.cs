using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenArrey = new int[2] { 10, 10 };
        // Act
        int result = EvenOddSubtraction.FindDifference(evenArrey);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddArrey = new int[2] { 9, 11 };
        // Act
        int result = EvenOddSubtraction.FindDifference(oddArrey);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixArrey = new int[4] { 9, 11, 2, 8 };
        // Act
        int result = EvenOddSubtraction.FindDifference(mixArrey);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
}
