using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace QLDiemSV_Winform.Validation
{
    internal class Standardize
    {
        public Standardize()
        {
        }

        public static string StandardizeText(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            input = input.ToLower();
            input = input.Trim();
            input = RemoveConsecutiveSpacesSpaces(input);
            input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
            return input;
        }

        public static string NotNullStandardizeNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "0";
            }
            return Convert.ToInt32(input).ToString();
        }

        private static string RemoveConsecutiveSpacesSpaces(string input) => Regex.Replace(input, @"\s{2,}", " ");
    }
}
