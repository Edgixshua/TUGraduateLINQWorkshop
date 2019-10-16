using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class NamesWithOtherNamesIncludedTests
    {
        [Test]
        public void NamesWithOtherNamesIncluded_EmptyList_ReturnsEmptyList()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var result = AdvancedLinq.NamesWithOtherNamesIncluded(people);

            // Assert
            result.Should().BeEmpty();
        }

        [Test]
        public void NamesWithOtherNamesIncluded_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var result = AdvancedLinq.NamesWithOtherNamesIncluded(people);

            // Assert
            result.Should().Be("Abby, Olivia, Smith\n");
        }

        [Test]
        public void NamesWithOtherNamesIncluded_LotsOfPeople_ReturnsEveryone()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var result = AdvancedLinq.NamesWithOtherNamesIncluded(people);

            // Assert
            result.Should().Be("Abby, Olivia, Smith\nBob, Humphrey\nCharlie, Paul\nDani, Holmes, Reed, Hayes\nEllie, Hunt, Ball\nFelicity, Plott\nGeorge, Olivia, Hayes\nHannah, Nelson, Hunt, Reed, Baller\nIsmail, Francis, , Ray\nJake,\n, Smith\nLenny, 1231914=9123812=03&&&%%%, Smith\n");
        }
    }
}