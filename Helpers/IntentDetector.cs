using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace bungalowparadise_api.Helpers
{
    public enum UserIntent
    {
        Unknown,
        BookingInquiry,
        ReviewInquiry,
        HotelInfo,
    }

    public static class IntentDetector
    {
        public static UserIntent Detect(string message)
        {
            var lower = NormalizeAccents(message.ToLower());

            foreach (var kvp in IntentKeywords.Keywords)
            {
                var pattern = BuildRegexPattern(kvp.Value);
                if (Regex.IsMatch(lower, pattern))
                    return kvp.Key;
            }

            return UserIntent.Unknown;
        }

        private static string BuildRegexPattern(string[] keywords)
        {
            var escaped = keywords.Select(Regex.Escape);
            return $@"\b({string.Join("|", escaped)})\b";
        }

        private static string NormalizeAccents(string input)
        {
            return string.Concat(
                input.Normalize(NormalizationForm.FormD)
                     .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            ).Normalize(NormalizationForm.FormC);
        }
    }
}
