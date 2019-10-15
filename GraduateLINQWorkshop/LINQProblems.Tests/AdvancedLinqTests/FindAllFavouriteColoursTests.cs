using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class FindAllFavouriteColoursTests
    {
        [Test]
        public void FindAllFavouriteColours_EmptyList_ReturnsEmptyList()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var result = AdvancedLinq.FindAllFavouriteColours(people);

            // Assert
            result.Should().BeEmpty();
        }

        [Test]
        public void FindAllFavouriteColours_AbbySmith_ReturnsSingleElement()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var result = AdvancedLinq.FindAllFavouriteColours(people);

            // Assert
            var colour = result.Should().ContainSingle().Subject;
            colour.Should().Be(Colour.Blue);
        }

        [Test]
        public void FindAllFavouriteColours_Everyone_ReturnsUniqueColours()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var result = AdvancedLinq.FindAllFavouriteColours(people);

            // Assert
            result.Should().BeEquivalentTo(new List<Colour>
            {
                Colour.Blue,
                Colour.Orange,
                Colour.Purple,
                Colour.Green
            });
        }
    }
}