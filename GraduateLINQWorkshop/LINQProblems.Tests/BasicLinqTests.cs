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
            var people = TestData.SinglePerson;

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
    }
}