using MyRegex.App;

public class RegexHelperTests
{
    [Fact]
    public void ValidateString_TooLongInput_ReturnsFalse()
    {
        // Arrange
        string input = "Aa1!" + new string('x', 20);

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_MatchingInputLength_ReturnsTrue()
    {
        // Arrange
        string input = "Aa1!xyzXYZ";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ValidateString_MissingUppercase_ReturnsFalse()
    {
        // Arrange
        string input = "aa1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_MissingLowercase_ReturnsFalse()
    {
        // Arrange
        string input = "AA1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_MissingDigit_ReturnsFalse()
    {
        // Arrange
        string input = "Aa!!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_MissingSpecialCharacter_ReturnsFalse()
    {
        // Arrange
        string input = "Aa1";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_WhitespaceAtStart_ReturnsFalse()
    {
        // Arrange
        string input = " Aa1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_WhitespaceAtEnd_ReturnsFalse()
    {
        // Arrange
        string input = "Aa1! ";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_WhitespaceInMiddle_ReturnsFalse()
    {
        // Arrange
        string input = "Aa 1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_TabAtStart_ReturnsFalse()
    {
        // Arrange
        string input = "\tAa1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_NewlineAtStart_ReturnsFalse()
    {
        // Arrange
        string input = "\nAa1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_TabInMiddle_ReturnsFalse()
    {
        // Arrange
        string input = "Aa\t1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_NewlineInMiddle_ReturnsFalse()
    {
        // Arrange
        string input = "Aa\n1!";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_TabAtEnd_ReturnsFalse()
    {
        // Arrange
        string input = "Aa1!\t";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidateString_NewlineAtEnd_ReturnsFalse()
    {
        // Arrange
        string input = "Aa1!\n";

        // Act
        bool result = RegexHelper.ValidateString(input, 10);

        // Assert
        Assert.False(result);
    }
}
