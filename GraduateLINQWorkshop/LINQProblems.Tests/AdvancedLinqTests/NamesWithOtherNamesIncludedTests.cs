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
            result.Trim().Should().Be(@"Abby, Olivia, Smith
Bob, Humphrey
Charlie, Paul
Dani, Holmes, Reed, Hayes
Ellie, Hunt, Ball
Felicity, Plott
George, Olivia, Hayes
Hannah, Nelson, Hunt, Reed, Baller
Ismail, Francis, , Ray
Jake, 
, Smith
Lenny, 1231914=9123812=03&&&%%%, Smith
");
        }
    }
}