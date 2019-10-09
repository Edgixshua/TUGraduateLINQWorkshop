using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.BasicLinqTests
{
    [TestFixture]
    public class OrderByAgeDescendingTests
    {
        [Test]
        public void OrderByAgeDescending_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeDescdending(people);

            //Assert
            orderedPeople.Should().BeEmpty();
        }

        [Test]
        public void OrderByAgeDescending_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeDescdending(people);

            //Assert
            orderedPeople.Should().BeInDescendingOrder(person => person.Age);
            orderedPeople.Should().HaveCount(people.Count);
            //Equivalent to ignores order
            orderedPeople.Should().BeEquivalentTo(people);
        }

        [Test]
        public void OrderByAgeDescending_LotsOfPeople_ReturnsOrderedList()
        {
            // Arrange
            var people = TestData.LotsOfPeople;

            //Act
            var orderedPeople = BasicLinq.OrderByAgeDescdending(people);

            //Assert
            orderedPeople.Should().BeInDescendingOrder(person => person.Age);
            orderedPeople.Should().HaveCount(people.Count);
            //Equivalent to ignores order
            orderedPeople.Should().BeEquivalentTo(people);
        }
    }
}