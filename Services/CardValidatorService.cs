using System.Text.RegularExpressions;

namespace bungalowparadise_api.Services
{
    public class CardValidatorService
    {
        public (bool IsValid, string? CardType, string? ErrorMessage) ValidateCard(string cardNumber, string expiryMonth, string expiryYear, string cvv)
        {
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            if (!Regex.IsMatch(cardNumber, @"^\d+$"))
                return (false, null, "El número de tarjeta debe contener solo dígitos.");

            string? cardType = cardNumber switch
            {
                _ when Regex.IsMatch(cardNumber, @"^4\d{12}(\d{3})?$") => "Visa",
                _ when Regex.IsMatch(cardNumber, @"^5[1-5]\d{14}$") => "MasterCard",
                _ when Regex.IsMatch(cardNumber, @"^3[47]\d{13}$") => "American Express",
                _ => null
            };

            if (cardType == null)
                return (false, null, "Tipo de tarjeta no válido. Aceptamos Visa, MasterCard y American Express.");

            if (!int.TryParse(expiryMonth, out int month) || month < 1 || month > 12)
                return (false, cardType, "El mes de expiración es inválido.");

            if (!int.TryParse(expiryYear, out int year) || year < DateTime.UtcNow.Year)
                return (false, cardType, "El año de expiración es inválido.");

            var expiryDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
            if (DateTime.UtcNow.Date > expiryDate)
                return (false, cardType, "La tarjeta está vencida.");

            if (!Regex.IsMatch(cvv, @"^\d+$"))
                return (false, cardType, "El CVV debe contener solo números.");

            int expectedCvvLength = cardType == "American Express" ? 4 : 3;
            if (cvv.Length != expectedCvvLength)
                return (false, cardType, $"Las tarjetas {cardType} requieren un CVV de {expectedCvvLength} dígitos.");

            return (true, cardType, null);
        }
    }
}
