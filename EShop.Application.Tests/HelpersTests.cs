namespace EShop.Application.Tests;
using Application;
using Domain.Exceptions;

public class HelpersTests
{
    [Theory]
    [InlineData("3497 7965 8312 797", true)]
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
    [InlineData("3s497 7965 831dss2 797")]
    [InlineData("34497 7965 831d52 797")]
    public void ValidateCard_CheckWrongCardNumber_ShouldThrowCorrectException(string cardNumber)
    {
        // Arrange
        var helpers = new Helpers();

        // Act & Assert
        Assert.Throws<CardNumberInvalidException>(() => helpers.ValidateCard(cardNumber));
    }


    [Theory]
    [InlineData("473856294")]
    [InlineData("123")]
    [InlineData("1234566")]
    public void ValidateCard_CheckCardNumberTooShort_ShouldThrowCorrectThrowException(string cardNumber)
    {
        // Arrange
        var helpers = new Helpers();

        // Act & Assert
        Assert.Throws<CardNumberTooShortException>(() => helpers.ValidateCard(cardNumber));
    }

    [Theory]
    [InlineData("47385629483582583528")]
    [InlineData("1237 31482 372 28 592355 923859932589325823 53")]
    [InlineData("123456- 52235 -23 523532-5 235  -2383258326")]
    public void ValidateCard_CheckCardNumberTooLong_ShouldThrowCorrectThrowException(string cardNumber)
    {
        // Arrange
        var helpers = new Helpers();

        // Act & Assert
        Assert.Throws<CardNumberTooLongException>(() => helpers.ValidateCard(cardNumber));
    }


    [Theory]
    [InlineData("3497 7965 8312 797", "American Express")]
    [InlineData("345-470-784-783-010", "American Express")]
    [InlineData("4532 2080 2150 4434", "Visa")]
    [InlineData("5551561443896215", "MasterCard")]
    public void GetCardType_CheckCardType_ShouldReturnCorrectValue(string cardNumber, string expected)
    {
        // Arrange
        var helpers = new Helpers();

        // Act
        var result = helpers.GetCardType(cardNumber);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3497a7965b8312c7")]
    [InlineData("2345-470-5784-7383-010")]
    [InlineData("4580 2150 4434")]
    [InlineData("5551561443895346215")]
    public void GetCardType_CheckWrongCardNumber_ShouldThrowCorrectException(string cardNumber)
    {
        // Arrange
        var helpers = new Helpers();

        // Act & Assert
        Assert.Throws<CardNumberInvalidException>(() => helpers.GetCardType(cardNumber));
    }
}