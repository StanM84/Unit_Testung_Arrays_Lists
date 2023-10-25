using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElementList = new() { 42 };

        int result = MaxNumber.FindMax(oneElementList);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> positiveElementList = new() { 42, 10, 4, 6, 23, 5 };

        int result = MaxNumber.FindMax(positiveElementList);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> negativeElementList = new() { -42, -10, -4, -6, -23, -5 };

        int result = MaxNumber.FindMax(negativeElementList);

        Assert.That(result, Is.EqualTo(-4));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> mixElementList = new() { 42, -10, 4, -6, 23, -5 };

        int result = MaxNumber.FindMax(mixElementList);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> duplicateElementList = new() { 42, 0, -4, -6, 42, 42 };

        int result = MaxNumber.FindMax(duplicateElementList);

        Assert.That(result, Is.EqualTo(42));
    }
}
