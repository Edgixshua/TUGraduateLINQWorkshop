using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class FindTotalAgeOfAllPeopleTests
    {
        [Test]
        public void FindTotalAgeOfAllPeople_EmptyList_Returns0()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(0);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_AbbySmith_Returns29()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(29);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_Everyone_Returns403()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(403);
        }
    }
}