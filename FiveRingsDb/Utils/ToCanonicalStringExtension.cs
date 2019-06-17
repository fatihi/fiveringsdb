using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace FiveRingsDb.Utils
{
    public static class ToCanonicalStringExtension
    {
        public static string ToCanonical(this string input)
        {
            if (input == null)
            {
                return null;
            }

            input = RemoveHtmlTags(input);
            input = Lowercase(input);
            input = RemoveDiacritics(input);
            input = ReplaceDashes(input);
            input = TrimDashes(input);
            input = RemoveDoubleDashes(input);

            return input;
        }

        private static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);
        }

        private static string Lowercase(string input)
        {
            #pragma warning disable CA1308 // Normalize strings to uppercase
            return input.ToLowerInvariant();
            #pragma warning restore CA1308 // Normalize strings to uppercase
        }

        private static string RemoveDiacritics(string input)
        {
            var strFormD = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var str in strFormD)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(str);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(str);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private static string ReplaceDashes(string input)
        {
            return input.Replace('–', '-');
        }

        private static string TrimDashes(string input)
        {
            return input.Trim('-', '_');
        }

        private static string RemoveDoubleDashes(string input)
        {
            return Regex.Replace(input, @"([-_]){2,}", "$1", RegexOptions.Compiled);
        }
    }
}
