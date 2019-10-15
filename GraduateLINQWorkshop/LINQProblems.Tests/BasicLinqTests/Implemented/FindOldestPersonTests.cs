using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.BasicLinqTests.Implemented
{
    [TestFixture]
    public class FindOldestPersonTests
    {
        [Test]
        public void FindOldestPerson_EmptyList_ReturnsNull()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var oldestPerson = LINQProblems.Implemented.BasicLinq.FindOldestPerson(people);

            //Assert
            oldestPerson.Should().BeNull();
        }

        [Test]
        public void FindOldestPerson_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var oldestPerson = LINQProblems.Implemented.BasicLinq.FindOldestPerson(people);

            //Assert
            oldestPerson.Should().BeEquivalentTo(new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"));
        }

        [Test]
        public void FindOldestPerson_LotsOfPeople_ReturnsFelicityPlott()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var oldestPerson = LINQProblems.Implemented.BasicLinq.FindOldestPerson(people);

            //Assert
            oldestPerson.Should().BeEquivalentTo(new Person("Felicity", "Plott", new List<string>(), new DateTime(1800, 4, 5), 99, Colour.Blue, "London"));
        }
    }
}