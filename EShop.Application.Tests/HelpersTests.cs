namespace EShop.Application.Tests;
using Application;

public class HelpersTests
{
    [Theory]
    [InlineData("3497 7965 8312 797", true)]
    [InlineData("3s497 7965 831dss2 797", false)]
    [InlineData("34973425235", false)]
    [InlineData("345-470-784-783-010", true)]
    [InlineData("378523393817437", true)]
    public void ValidateCard_ChceckCardNumber_ShouldReturnCorrectValue(string cardNumber, bool expected)
    {
        // Arrange
        var helpers = new Helpers();

        // Act
        var result = helpers.ValidateCard(cardNumber);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3497 7965 8312 797", "American Express")]
    [InlineData("345-470-784-783-010", "American Express")]
    [InlineData("4532 2080 2150 4434", "Visa")]
    [InlineData("5551561443896215", "MasterCard")]
    [InlineData("555156144389hsgejk6215", "Unknown")]
    public void GetCardType_CheckCardType_ShouldReturnCorrectValue(string cardNumber, string expected)
    {
        // Arrange
        var helpers = new Helpers();

        // Act
        var result = helpers.GetCardType(cardNumber);

        // Assert
        Assert.Equal(expected, result);
    }
}