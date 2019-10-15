using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class FindFirstNamesWhichExistInBothListsTests
    {
        [Test]
        public void FindFirstNamesWhichExistInBothLists_EmptyList_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;
            var otherPeople = TestData.NoPeople;

            // Act
            var namesWhichExistInBoth = AdvancedLinq.FindFirstNamesWhichExistInBothLists(people, otherPeople);

            // Assert
            namesWhichExistInBoth.Should().BeEmpty();
        }

        [Test]
        public void FindFirstNamesWhichExistInBothLists_AbbySmith_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.AbbySmith;
            var otherPeople = TestData.NoPeople;

            // Act
            var namesWhichExistInBoth = AdvancedLinq.FindFirstNamesWhichExistInBothLists(people, otherPeople);

            // Assert
            namesWhichExistInBoth.Should().BeEmpty();
        }

        [Test]
        public void FindFirstNamesWhichExistInBothLists_AbbySmith_AbbyDoe_ReturnsAbby()
        {
            // Arrange
            var people = TestData.AbbySmith;
            var otherPeople = new List<Person> { new Person("Abby", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion") };

            // Act
            var namesWhichExistInBoth = AdvancedLinq.FindFirstNamesWhichExistInBothLists(people, otherPeople);

            // Assert
            var name = namesWhichExistInBoth.Should().ContainSingle().Subject;
            name.Should().Be("Abby");
        }

        [Test]
        public void FindFirstNamesWhichExistInBothLists_AbbySmith_JohnDoe_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.AbbySmith;
            var otherPeople = new List<Person> { new Person("John", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion") };

            // Act
            var namesWhichExistInBoth = AdvancedLinq.FindFirstNamesWhichExistInBothLists(people, otherPeople);

            // Assert
            namesWhichExistInBoth.Should().BeEmpty();
        }

        [Test]
        public void FindFirstNamesWhichExistInBothLists_LotsOfPeople_RandomPeople_PeopleWhoExistInBoth()
        {
            // Arrange
            var people = TestData.LotsOfPeople;
            var otherPeople = new List<Person>
            {
                new Person("Zebedee", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
                new Person("Josh", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
                new Person("Dani", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
                new Person("Ismail", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
                new Person("Jack", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
                new Person("Daniel", "Doe", null, new DateTime(2000, 1, 1), 10, Colour.Blue, "TransUnion"),
            };

            // Act
            var namesWhichExistInBoth = AdvancedLinq.FindFirstNamesWhichExistInBothLists(people, otherPeople);

            // Assert
            namesWhichExistInBoth.Should().BeEquivalentTo(new List<string>
            {
                "Dani",
                "Ismail"
            });
        }
    }
}