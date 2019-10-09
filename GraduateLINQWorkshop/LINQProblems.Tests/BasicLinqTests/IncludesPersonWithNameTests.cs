using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.BasicLinqTests
{
    [TestFixture]
    public class IncludesPersonWithNameTests
    {
        [Test]
        public void IncludePersonWithNameAbby_EmptyList_ReturnsFalse()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var includesPerson = BasicLinq.IncludesPersonWithName(people, "Abby");

            //Assert
            includesPerson.Should().BeFalse();
        }

        [Test]
        public void IncludePersonWithNameAbby_AbbySmith_ReturnsTrue()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var includesPerson = BasicLinq.IncludesPersonWithName(people, "Abby");

            //Assert
            includesPerson.Should().BeTrue();
        }

        [Test]
        public void IncludePersonWithNameBob_AbbySmith_ReturnsTrue()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var includesPerson = BasicLinq.IncludesPersonWithName(people, "Bob");

            //Assert
            includesPerson.Should().BeFalse();
        }

        [Test]
        public void IncludePersonWithNameFelicity_LotsOfPeople_ReturnsTrue()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var includesPerson = BasicLinq.IncludesPersonWithName(people, "Felicity");

            //Assert
            includesPerson.Should().BeTrue();
        }

        [Test]
        public void IncludePersonWithNameEll_LotsOfPeople_ReturnsFalse()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var includesPerson = BasicLinq.IncludesPersonWithName(people, "Ell");

            //Assert
            includesPerson.Should().BeFalse();
        }
    }
}