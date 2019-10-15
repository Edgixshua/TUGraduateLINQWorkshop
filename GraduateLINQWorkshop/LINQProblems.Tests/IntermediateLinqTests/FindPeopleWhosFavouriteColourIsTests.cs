using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class FindPeopleWhosFavouriteColourIsTests
    {
        [Test]
        public void FindPeopleWhosFavouriteColourIsRed_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var favouriteColour = Colour.Red;

            var people = TestData.NoPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().BeEmpty();
        }

        [Test]
        public void FindPeopleWhosFavouriteColourIsBlue_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var favouriteColour = Colour.Blue;

            var people = TestData.AbbySmith;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().HaveCount(1);
            peopleWithFavouriteColour.Should().BeEquivalentTo(TestData.AbbySmith);
        }

        [Test]
        public void FindPeopleWhosFavouriteColourIsBlue_LotsOfPeople_ReturnsCorrectPeople()
        {
            // Arrange
            var favouriteColour = Colour.Blue;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().HaveCount(8);
            peopleWithFavouriteColour.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"),
                new Person("Dani", "Hayes", new List<string> { "Holmes", "Reed" }, new DateTime(1986, 6, 5), 55, Colour.Blue, "Sheffield"),
                new Person("Ellie", "Ball", new List<string> { "Hunt" }, new DateTime(1975, 7, 5), 37, Colour.Blue, "Leeds"),
                new Person("George", "Hayes", new List<string> { "Olivia" }, new DateTime(1925, 10, 5), 74, Colour.Blue, "Leeds"),
                new Person("Hannah", "Baller", new List<string> { "Nelson", "Hunt", "Reed" }, new DateTime(1950, 1, 5), 5, Colour.Blue, "London"),
                new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds"),
                new Person("Jake", "Smith", new List<string> { "\n" }, new DateTime(1995, 3, 5), 18, Colour.Blue, "Nowhere"),
                new Person("Lenny", "Smith", new List<string> { "1231914=9123812=03&&&%%%" }, new DateTime(1990, 1, 5), 18, Colour.Blue, "Leeds")
            });
        }

        [Test]
        public void FindPeopleWhosFavouriteColourIsPurple_LotsOfPeople_ReturnsCharliePaul()
        {
            // Arrange
            var favouriteColour = Colour.Purple;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().HaveCount(1);
            peopleWithFavouriteColour.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Charlie", "Paul", null, new DateTime(2009, 5, 5), 10, Colour.Purple, "Lancaster")
            });
        }

        [Test]
        public void FindPeopleWhosFavouriteColourIsOrange_LotsOfPeople_ReturnsBobHumphrey()
        {
            // Arrange
            var favouriteColour = Colour.Orange;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().HaveCount(1);
            peopleWithFavouriteColour.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Bob", "Humphrey", new List<string>(), new DateTime(1956, 12, 5), 12, Colour.Orange, "Leeds")
            });
        }

        [Test]
        public void FindPeopleWhosFavouriteColourIsGreen_LotsOfPeople_ReturnsIsmailRay()
        {
            // Arrange
            var favouriteColour = Colour.Green;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithFavouriteColour = IntermediateLinq.FindPeopleWhosFavouriteColourIs(people, favouriteColour);

            //Assert
            peopleWithFavouriteColour.Should().HaveCount(1);
            peopleWithFavouriteColour.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds")
            });
        }
    }
}
