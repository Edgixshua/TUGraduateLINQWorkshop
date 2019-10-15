using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.IntermediateLinqTests
{
    [TestFixture]
    public class CalculateHowManyPeopleLiveInTests
    {
        [Test]
        public void CalculateHowManyPeopleLiveInLeeds_EmptyList_ReturnsZero()
        {
            // Arrange
            const string place = "Leeds";

            var people = TestData.NoPeople;

            //Act
            var peopleLivingInLeeds = IntermediateLinq.CalculateHowManyPeopleLiveIn(people, place);

            //Assert
            peopleLivingInLeeds.Should().Be(0);
        }

        [Test]
        public void CalculateHowManyPeopleLiveInLeeds_AbbySmith_ReturnsOne()
        {
            // Arrange
            const string place = "Leeds";

            var people = TestData.AbbySmith;

            //Act
            var peopleLivingInLeeds = IntermediateLinq.CalculateHowManyPeopleLiveIn(people, place);

            //Assert
            peopleLivingInLeeds.Should().Be(1);
        }

        [Test]
        public void CalculateHowManyPeopleLiveInLeeds_LotsOfPeople_ReturnsSix()
        {
            // Arrange
            const string place = "Leeds";

            var people = TestData.LotsOfPeople;

            //Act
            var peopleLivingInLeeds = IntermediateLinq.CalculateHowManyPeopleLiveIn(people, place);

            //Assert
            peopleLivingInLeeds.Should().Be(6);
        }
    }
}
