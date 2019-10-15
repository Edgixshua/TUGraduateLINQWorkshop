using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class CombinePeopleTests
    {
        [Test]
        public void CombinePeople_EmptyLists_ReturnsNull()
        {
            // Arrange
            var firstList = TestData.NoPeople;
            var secondList = TestData.NoPeople;

            //Act
            var combinedPeople = IntermediateLinq.CombinePeople(firstList, secondList);

            //Assert
            combinedPeople.Should().BeNull();
        }

        [Test]
        public void CombinePeople_AbbySmithAndEmptyList_ReturnsAbbySmith()
        {
            // Arrange
            var firstList = TestData.AbbySmith;
            var secondList = TestData.NoPeople;

            //Act
            var combinedPeople = IntermediateLinq.CombinePeople(firstList, secondList);

            //Assert
            combinedPeople.Should().HaveCount(TestData.AbbySmith.Count);
            combinedPeople.Should().BeEquivalentTo(TestData.AbbySmith);
        }

        [Test]
        public void CombinePeople_LotsOfPeopleAndEmptyList_ReturnsLotsOfPeople()
        {
            // Arrange
            var firstList = TestData.LotsOfPeople;
            var secondList = TestData.NoPeople;

            //Act
            var combinedPeople = IntermediateLinq.CombinePeople(firstList, secondList);

            //Assert
            combinedPeople.Should().HaveCount(TestData.LotsOfPeople.Count);
            combinedPeople.Should().BeEquivalentTo(TestData.LotsOfPeople);
        }

        [Test]
        public void CombinePeople_AbbySmithAndLotsOfPeople_ReturnsCombinedList()
        {
            // Arrange
            var firstList = TestData.AbbySmith;
            var secondList = TestData.LotsOfPeople;
            var combinedListCount = TestData.AbbySmith.Count + TestData.LotsOfPeople.Count;

            //Act
            var combinedPeople = IntermediateLinq.CombinePeople(firstList, secondList);

            //Assert
            combinedPeople.Should().HaveCount(combinedListCount);
            combinedPeople.Should().Contain(TestData.AbbySmith.FirstOrDefault());
        }
    }
}
