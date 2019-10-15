using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class PeopleWithOtherNameOfTests
    {
        [Test]
        public void PeopleWithOtherNamesOf_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            const string name = "Olivia";

            var people = TestData.NoPeople;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNameOf(people, name);

            //Assert
            peopleWithOtherNames.Should().BeEmpty();
        }

        [Test]
        public void PeopleWithOtherNamesOfOlivia_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            const string name = "Olivia";

            var people = TestData.AbbySmith;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNameOf(people, name);

            //Assert
            peopleWithOtherNames.Should().HaveCount(1);
            peopleWithOtherNames.Should().BeEquivalentTo(TestData.AbbySmith);
        }

        [Test]
        public void PeopleWithOtherNamesOfOlivia_LotsOfPeople_ReturnsCorrectPeople()
        {
            // Arrange
            const string name = "Olivia";

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNameOf(people, name);

            //Assert
            peopleWithOtherNames.Should().HaveCount(2);
            peopleWithOtherNames.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"),
                new Person("George", "Hayes", new List<string> { "Olivia" }, new DateTime(1925, 10, 5), 74, Colour.Blue, "Leeds")
            });
        }

        [Test]
        public void PeopleWithOtherNamesOfFrancis_LotsOfPeople_ReturnsIsmailRay()
        {
            // Arrange
            const string name = "Francis";

            var people = TestData.LotsOfPeople;

            //Act
            var peopleWithOtherNames = IntermediateLinq.PeopleWithOtherNameOf(people, name);

            //Assert
            peopleWithOtherNames.Should().HaveCount(1);
            peopleWithOtherNames.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds")
            });
        }
    }
}
