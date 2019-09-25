using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests
{
    [TestFixture]
    public class BasicLinqTests
    {
        [Test]
        public void GetFirstNamesOfPeople_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var names = BasicLinq.GetFirstNamesOfPeople(people);

            //Assert
            names.Should().BeEmpty();
        }

        [Test]
        public void GetFirstNamesOfPeople_SinglePerson_ReturnsListWithSingleName()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var names = BasicLinq.GetFirstNamesOfPeople(people);

            //Assert
            names.Should().ContainSingle().Subject.Should().Be("Abby");
        }

        [Test]
        public void GetFirstNamesOfPeople_LotsOfPeople_ReturnsListWithAllNames()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var names = BasicLinq.GetFirstNamesOfPeople(people);

            //Assert
            names.Should().BeEquivalentTo(new List<string>
            {
                "Abby",
                "Bob",
                "Charlie",
                "Dani",
                "Ellie",
                "Felicity",
                "George",
                "Hannah",
                "Ismail",
                "Jake",
                "Lenny"
            });
        }

        [Test]
        public void GetPeopleOlderThan10_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;
            const int cutOffAge = 10;

            //Act
            var peopleOlderThanCutOffAge = BasicLinq.GetPeopleOlderThan(people, cutOffAge);

            //Assert
            peopleOlderThanCutOffAge.Should().BeEmpty();
        }

        [Test]
        public void GetPeopleOlderThan30_AbbySmith_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.AbbySmith;
            const int cutOffAge = 30;

            //Act
            var peopleOlderThanCutOffAge = BasicLinq.GetPeopleOlderThan(people, cutOffAge);

            //Assert
            peopleOlderThanCutOffAge.Should().BeEmpty();
        }

        [Test]
        public void GetPeopleOlderThan29_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;
            const int cutOffAge = 29;

            //Act
            var peopleOlderThanCutOffAge = BasicLinq.GetPeopleOlderThan(people, cutOffAge);

            //Assert
            var person = peopleOlderThanCutOffAge.Should().ContainSingle().Subject;
            person.FirstName.Should().Be("Abby");
            person.LastName.Should().Be("Smith");
        }

        [Test]
        public void GetPeopleOlderThan18_LotsOfPeople_ReturnsPeopleOlderThan18()
        {
            // Arrange
            var people = TestData.LotsOfPeople;
            const int cutOffAge = 18;

            //Act
            var peopleOlderThanCutOffAge = BasicLinq.GetPeopleOlderThan(people, cutOffAge);

            //Assert
            peopleOlderThanCutOffAge.Should().HaveCount(8);
            peopleOlderThanCutOffAge.Should().BeEquivalentTo(new List<Person>
            {
                new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"),
                new Person("Dani", "Hayes", new List<string> { "Holmes", "Reed" }, new DateTime(1986, 6, 5), 55, Colour.Blue, "Sheffield"),
                new Person("Ellie", "Ball", new List<string> { "Hunt" }, new DateTime(1975, 7, 5), 37, Colour.Blue, "Leeds"),
                new Person("Felicity", "Plott", new List<string>(), new DateTime(1800, 4, 5), 99, Colour.Blue, "London"),
                new Person("George", "Hayes", new List<string> { "Olivia" }, new DateTime(1925, 10, 5), 74, Colour.Blue, "Leeds"),
                new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds"),
                new Person("Jake", "Smith", new List<string> { "\n" }, new DateTime(1995, 3, 5), 18, Colour.Blue, "Nowhere"),
                new Person("Lenny", "Smith", new List<string> { "1231914=9123812=03&&&%%%" }, new DateTime(1990, 1, 5), 18, Colour.Blue, "Leeds")
            });
        }
    }
}