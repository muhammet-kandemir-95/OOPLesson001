using OOPLesson001.App.Console.Concrete;

namespace OOPLesson001.App.Console.Test;

public class PrimeFactorTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(10, 10)]
    [InlineData(15, 15)]
    [InlineData(152342134, 152342134)]
    [InlineData(-1, 1)]
    [InlineData(-10, 10)]
    [InlineData(-15, 15)]
    [InlineData(-152342134, 152342134)]
    public void Abs_ShouldWorkCorrectly(int input, int output)
    {
        // Arrange
        PrimeFactor primeFactor = new PrimeFactor();

        // Act
        int result = primeFactor.Abs(input);

        // Assert
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(11)]
    [InlineData(347)]
    [InlineData(953)]
    [InlineData(167449)]
    [InlineData(1828669)]
    [InlineData(19734581)]
    public void IsPrime_ShouldReturnTrue_WhenInputIsPrime(int input)
    {
        // Arrange
        PrimeFactor primeFactor = new PrimeFactor();

        // Act
        bool result = primeFactor.IsPrime(input);

        // Assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(4)]
    [InlineData(12)]
    [InlineData(15)]
    [InlineData(33)]
    [InlineData(169)]
    [InlineData(1081)]
    [InlineData(16459)]
    [InlineData(954687)]
    [InlineData(1973451)]
    public void IsPrime_ShouldReturnFalse_WhenInputIsNotPrime(int input)
    {
        // Arrange
        PrimeFactor primeFactor = new PrimeFactor();

        // Act
        bool result = primeFactor.IsPrime(input);

        // Assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(2, new int[] { 2 })]
    [InlineData(4, new int[] { 2 })]
    [InlineData(5, new int[] { 5 })]
    [InlineData(7, new int[] { 7 })]
    [InlineData(12, new int[] { 2, 3 })]
    [InlineData(15, new int[] { 3, 5 })]
    [InlineData(35, new int[] { 5, 7 })]
    [InlineData(105, new int[] { 3, 5, 7 })]
    [InlineData(32, new int[] { 2 })]
    [InlineData(1024, new int[] { 2 })]
    [InlineData(48, new int[] { 2, 3 })]
    [InlineData(528, new int[] { 2, 3, 11 })]
    [InlineData(30251, new int[] { 13, 179 })]
    public void Get_ShouldReturnCorrectValues_WhenInputIsPositive(int input, int[] output)
    {
        // Arrange
        PrimeFactor primeFactor = new PrimeFactor();

        // Act
        int[] result = primeFactor.Get(input);

        // Assert
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(-2, new int[] { 2 })]
    [InlineData(-4, new int[] { 2 })]
    [InlineData(-5, new int[] { 5 })]
    [InlineData(-7, new int[] { 7 })]
    [InlineData(-12, new int[] { 2, 3 })]
    [InlineData(-15, new int[] { 3, 5 })]
    [InlineData(-35, new int[] { 5, 7 })]
    [InlineData(-105, new int[] { 3, 5, 7 })]
    [InlineData(-32, new int[] { 2 })]
    [InlineData(-1024, new int[] { 2 })]
    [InlineData(-48, new int[] { 2, 3 })]
    [InlineData(-528, new int[] { 2, 3, 11 })]
    [InlineData(-30251, new int[] { 13, 179 })]
    public void Get_ShouldReturnCorrectValues_WhenInputIsNegative(int input, int[] output)
    {
        // Arrange
        PrimeFactor primeFactor = new PrimeFactor();

        // Act
        int[] result = primeFactor.Get(input);

        // Assert
        Assert.Equal(output, result);
    }
}