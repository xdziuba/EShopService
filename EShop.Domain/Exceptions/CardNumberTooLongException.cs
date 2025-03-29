using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions;

public class CardNumberTooLongException : Exception
{
    public CardNumberTooLongException() { }
    public CardNumberTooLongException(string cardNumber) : base($"Card number {cardNumber} is too long.") { }
    public CardNumberTooLongException(string cardNumber, Exception innerException) : base($"Card number {cardNumber} is too long.", innerException) { }

}
