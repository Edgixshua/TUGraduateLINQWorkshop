using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.BasicLinqTests
{
    [TestFixture]
    public class OrderByAgeAscendingTests
    {
        [Test]
        public void OrderByAgeAscending_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeAscending(people);

            //Assert
            orderedPeople.Should().BeEmpty();
        }

        [Test]
        public void OrderByAgeAscending_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeAscending(people);

            //Assert
            orderedPeople.Should().BeInAscendingOrder(person => person.Age);
            orderedPeople.Should().HaveCount(people.Count);
            //Equivalent to ignores order
            orderedPeople.Should().BeEquivalentTo(people);
        }

        [Test]
        public void OrderByAgeAscending_LotsOfPeople_ReturnsOrderedList()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeAscending(people);

            //Assert
            orderedPeople.Should().BeInAscendingOrder(person => person.Age);
            orderedPeople.Should().HaveCount(people.Count);
            //Equivalent to ignores order
            orderedPeople.Should().BeEquivalentTo(people);
        }
    }
}