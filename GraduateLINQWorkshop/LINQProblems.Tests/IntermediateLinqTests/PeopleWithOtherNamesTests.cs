using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class PeopleWithOtherNamesTests
    {
        [Test]
        public void PeopleWithOtherNames_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNames(people);

            //Assert
            peopleWithOtherNames.Should().BeEmpty();
        }

        [Test]
        public void PeopleWithOtherNames_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNames(people);

            //Assert
            peopleWithOtherNames.Should().BeEmpty();
        }

        [Test]
        public void PeopleWithOtherNames_LotsOfPeople_ReturnsCorrectPeople()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNames(people);

            //Assert
            peopleWithOtherNames.Should().HaveCount(8);
            peopleWithOtherNames.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"),
                new Person("Dani", "Hayes", new List<string> { "Holmes", "Reed" }, new DateTime(1986, 6, 5), 55, Colour.Blue, "Sheffield"),
                new Person("Ellie", "Ball", new List<string> { "Hunt" }, new DateTime(1975, 7, 5), 37, Colour.Blue, "Leeds"),
                new Person("George", "Hayes", new List<string> { "Olivia" }, new DateTime(1925, 10, 5), 74, Colour.Blue, "Leeds"),
                new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds"),
                new Person("Hannah", "Baller", new List<string> { "Nelson", "Hunt", "Reed" }, new DateTime(1950, 1, 5), 5, Colour.Blue, "London"),
                new Person("Jake", "Smith", new List<string> { "\n" }, new DateTime(1995, 3, 5), 18, Colour.Blue, "Nowhere"),
                new Person("Lenny", "Smith", new List<string> { "1231914=9123812=03&&&%%%" }, new DateTime(1990, 1, 5), 18, Colour.Blue, "Leeds")
            });
        }
    }
}
