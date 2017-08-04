using System.Text.RegularExpressions;

namespace SystemCustomers
{
    public class MyRegEx
    {

        public const string OnlyCharsPattern = "^[A-Za-z]+$";
        public const string OnlyCharsSpacesAndApostropheDigitsHebrew = "[א-תA-Za-z0-9._%-,'\\s]+$";
        public const string OnlyCharsSpacesAndApostrophe = "^[A-Za-z'\\s]+$";
        public const string OnlyCharsSpacesAndApostropheNumbers = "^[._%-0-9A-Za-z'\\s]+$";
        public const string OnlyDigits = "^[.0-9]+$";
        public const string OnlyNineDigits = "^[0-9]{9}$";
        public const string OnlySixDigits = "^[0-9]{6}$";
        public const string OnlyTenDigits = "^[0-9]{10}$";
        public const string OnlyFormatEmail = "[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$";
        public const string OnlyFormatHour = "^(([0-1][0-9])|([2][0-3]))[.]([0-5][0-9])$";
        public const string OnlyFiveDigits = "^[0-9]{5}$";

        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public static bool Validate(string value, string pattern)
        {
            Regex valuePattern = new Regex(pattern);
            bool result = valuePattern.IsMatch(value);
            return result;
        }

    }
}
