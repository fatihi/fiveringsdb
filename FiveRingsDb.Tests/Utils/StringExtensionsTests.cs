using FiveRingsDb.Utils;
using FluentAssertions;
using NUnit.Framework;

namespace FiveRingsDb.Tests.Utils
{
    public class StringExtensionsTests
    {
        [TestCase("Blackmail", "blackmail")]
        [TestCase("A Fate Worse Than Death", "a fate worse than death")]
        [TestCase("Ancestral Daishō", "ancestral daisho")]
        [TestCase("Banzai!", "banzai!")]
        [TestCase("Bayushi's Whisperers", "bayushi's whisperers")]
        [TestCase("Blade of 10,000 Battles", "blade of 10,000 battles")]
        [TestCase("Kirei-ko", "kirei-ko")]
        public void ToCanonical_Should_ConvertNameToCanonical(string name, string expected)
        {
            var result = name.ToCanonical();

            result.Should().BeEquivalentTo(expected);
        }

        [TestCase(
            "While this character is participating in a conflict, ignore the effects of each status token on each participating character.",
            "while this character is participating in a conflict, ignore the effects of each status token on each participating character.")]
        [TestCase(
            "<b>Action:</b> While this character is participating in a [conflict-political] conflict, choose a participating character controlled by your opponent – until the end of the conflict, that character gets –1[conflict-political] and is discarded if its [conflict-political] skill is 0. (Limit twice per round.)",
            "action: while this character is participating in a [conflict-political] conflict, choose a participating character controlled by your opponent - until the end of the conflict, that character gets -1[conflict-political] and is discarded if its [conflict-political] skill is 0. (limit twice per round.)")]
        public void ToCanonical_Should_ConvertTextToCanonical(string name, string expected)
        {
            var result = name.ToCanonical();

            result.Should().BeEquivalentTo(expected);
        }
    }
}
