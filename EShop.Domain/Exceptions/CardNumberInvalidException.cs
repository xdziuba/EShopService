using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions;

public class CardNumberInvalidException : Exception
{
    public CardNumberInvalidException() { }
    public CardNumberInvalidException(string cardNumber) : base($"Card number {cardNumber} is invalid.") { }
    public CardNumberInvalidException(string cardNumber, Exception innerException) : base($"Card number {cardNumber} is invalid", innerException) { }

}
