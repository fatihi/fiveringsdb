using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FiveRingsDb.Utils
{
    public static class ToIconizedHtmlCardTextExtension
    {
        public static string ToIconizedHtmlCardText(this string input)
        {
            var regex = new Regex(@"\[([\w-]+)\]");
            var evaluator = new MatchEvaluator(IconTextMatcher);
            var cardTextWithIcons = regex.Replace(input, evaluator);
            return ReplaceSingleQuotesWithHtmlCode(cardTextWithIcons);
        }

        private static string ReplaceSingleQuotesWithHtmlCode(string cardTextWithIcons)
        {
            const string singleQuoteHtmlCode = "&#39;";
            return cardTextWithIcons.Replace("'", singleQuoteHtmlCode, StringComparison.CurrentCulture);
        }

        private static string IconTextMatcher(Match match)
        {
            var icon = match.Groups[1].Captures.First().Value;

            return "<span class=\"icon icon-" + icon + "\"></span>";
        }
    }
}
