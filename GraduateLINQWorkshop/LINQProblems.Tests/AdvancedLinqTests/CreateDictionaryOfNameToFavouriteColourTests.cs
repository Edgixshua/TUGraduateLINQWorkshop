using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class CreateDictionaryOfNameToFavouriteColourTests
    {
        [Test]
        public void CreateDictionaryOfNameToFavouriteColour_EmptyList_ReturnsEmptyDictionary()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var favouriteColourDictionary = AdvancedLinq.CreateDictionaryOfNameToFavouriteColour(people);

            // Assert
            favouriteColourDictionary.Should().BeEmpty();
        }

        [Test]
        public void CreateDictionaryOfNameToFavouriteColour_AbbySmith_ReturnsSingleElementDictionary()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var favouriteColourDictionary = AdvancedLinq.CreateDictionaryOfNameToFavouriteColour(people);

            // Assert
            favouriteColourDictionary.Should().HaveCount(1);
            favouriteColourDictionary.Should().Contain("Abby", Colour.Blue);
        }

        [Test]
        public void CreateDictionaryOfNameToFavouriteColour_LotsOfPeople_ReturnsDictionaryWithAllPairs()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var favouriteColourDictionary = AdvancedLinq.CreateDictionaryOfNameToFavouriteColour(people);

            // Assert
            favouriteColourDictionary.Should().HaveCount(11);

            favouriteColourDictionary.Should().Contain("Abby", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Bob", Colour.Orange);
            favouriteColourDictionary.Should().Contain("Charlie", Colour.Purple);
            favouriteColourDictionary.Should().Contain("Dani", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Ellie", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Felicity", Colour.Blue);
            favouriteColourDictionary.Should().Contain("George", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Hannah", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Ismail", Colour.Green);
            favouriteColourDictionary.Should().Contain("Jake", Colour.Blue);
            favouriteColourDictionary.Should().Contain("Lenny", Colour.Blue);
        }
    }
}