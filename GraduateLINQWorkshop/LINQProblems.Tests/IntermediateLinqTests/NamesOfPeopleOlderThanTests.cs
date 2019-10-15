using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class NamesOfPeopleOlderThanTests
    {
        [Test]
        public void NamesOfPeopleOlderThan_EmptyList_ReturnsEmpty()
        {
            // Arrange
            var people = TestData.NoPeople;

            //Act
            var peopleOlderThan = IntermediateLinq.NamesOfPeopleOlderThan(people, 20);

            //Assert
            peopleOlderThan.Should().BeEmpty();
        }

        [Test]
        public void NamesOfPeopleOlderThanThirty_AbbySmith_ReturnsEmpty()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var peopleOlderThan = IntermediateLinq.NamesOfPeopleOlderThan(people, 30);

            //Assert
            peopleOlderThan.Should().BeEmpty();
        }

        [Test]
        public void NamesOfPeopleOlderThanTwenty_AbbySmith_ReturnsAbbySmith()
        {
            // Arrange
            var people = TestData.AbbySmith;

            //Act
            var peopleOlderThan = IntermediateLinq.NamesOfPeopleOlderThan(people, 20);

            //Assert
            peopleOlderThan.Should().HaveCount(TestData.AbbySmith.Count);
            peopleOlderThan.Should().BeEquivalentTo("Abby");
        }

        [Test]
        public void NamesOfPeopleOlderThanTwenty_LotsOfPeople_ReturnsCorrectPeople()
        {
            // Arrange
            const int expectedCount = 6;

            var people = TestData.LotsOfPeople;

            //Act
            var peopleOlderThan = IntermediateLinq.NamesOfPeopleOlderThan(people, 25);

            //Assert
            peopleOlderThan.Should().HaveCount(expectedCount);
            peopleOlderThan.Should().Contain("Abby");
            peopleOlderThan.Should().Contain("Dani");
            peopleOlderThan.Should().Contain("Ellie");
            peopleOlderThan.Should().Contain("Felicity");
            peopleOlderThan.Should().Contain("George");
            peopleOlderThan.Should().Contain("Ismail");
        }
    }
}
