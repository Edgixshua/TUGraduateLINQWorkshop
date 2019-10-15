using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOfTests
    {
        [Test]
        public void DoesSomeoneExistWhoIsOverAgeTwentyWithFavouriteColourOfRed_EmptyList_ReturnsFalse()
        {
            // Arrange
            const int age = 20;
            var favouriteColour = Colour.Red;

            var people = TestData.NoPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(people, age, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().BeFalse();
        }

        [Test]
        public void DoesSomeoneExistWhoIsOverAgeTwentyWithFavouriteColourOfBlue_AbbySmith_ReturnsTrue()
        {
            // Arrange
            const int age = 20;
            var favouriteColour = Colour.Blue;

            var people = TestData.AbbySmith;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(people, age, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().BeTrue();
        }

        [Test]
        public void DoesSomeoneExistWhoIsOverAgeTwentyWithFavouriteColourOfBlue_LotsOfPeople_ReturnsTrue()
        {
            // Arrange
            const int age = 20;
            var favouriteColour = Colour.Blue;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(people, age, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().BeTrue();
        }

        [Test]
        public void DoesSomeoneExistWhoIsOverAgeFiftyWithFavouriteColourOfGreen_LotsOfPeople_ReturnsFalse()
        {
            // Arrange
            const int age = 50;
            var favouriteColour = Colour.Green;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(people, age, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().BeFalse();
        }
    }
}
