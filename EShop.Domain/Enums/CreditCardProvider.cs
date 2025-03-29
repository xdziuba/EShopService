using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Enums;

public enum CreditCardProvider
{
    Visa,
    MasterCard,
    [Display(Name = "American Express")]
    AmericanExpress,
    Discover,
    JCB,
    [Display(Name = "Diners Club")]
    DinersClub,
    Maestro,
}
