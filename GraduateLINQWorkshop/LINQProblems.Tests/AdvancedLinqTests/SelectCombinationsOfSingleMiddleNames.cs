using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class SelectCombinationsOfSingleMiddleNames
    {
        [Test]
        public void SelectCombinationsOfSingleMiddleNames_EmptyList_ReturnsEmptyList()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var result = AdvancedLinq.SelectCombinationsOfSingleMiddleNames(people);

            // Assert
            result.Should().BeEmpty();
        }

        [Test]
        public void SelectCombinationsOfSingleMiddleNames_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var result = AdvancedLinq.SelectCombinationsOfSingleMiddleNames(people);

            // Assert
            result.Should().BeEquivalentTo("Abby, Olivia, Smith");
        }

        [Test]
        public void SelectCombinationsOfSingleMiddleNames_LotsOfPeople_ReturnsEveryone()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var result = AdvancedLinq.SelectCombinationsOfSingleMiddleNames(people);

            // Assert
            result.Should().BeEquivalentTo("Abby, Olivia, Smith",
                "Dani, Holmes, Hayes",
                "Dani, Reed, Hayes",
                "Ellie, Hunt, Ball",
                "George, Olivia, Hayes",
                "Hannah, Nelson, Baller",
                "Hannah, Hunt, Baller",
                "Hannah, Reed, Baller",
                "Ismail, Francis, Ray",
                "Ismail, , Ray",
                "Jake, \n, Smith",
                "Lenny, 1231914=9123812=03&&&%%%, Smith");
        }
    }
}