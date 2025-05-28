using System.Text.RegularExpressions;
namespace EShop.Application.Services;

public interface ICreditCardService
{
    public Boolean ValidateCard(string cardNumber);

    public string GetCardType(string cardNumber);
}