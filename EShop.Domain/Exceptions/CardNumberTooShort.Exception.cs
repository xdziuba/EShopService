using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions;

public class CardNumberTooShortException : Exception
{
    public CardNumberTooShortException() { }
    public CardNumberTooShortException(string cardNumber) : base($"Card number {cardNumber} is too short.") { }
    public CardNumberTooShortException(string cardNumber, Exception innerException) : base($"Card number {cardNumber} is too short.", innerException) { }

}
