﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LINQProblems.Tests.AdvancedLinqTests
{
    [TestFixture]
    public class FindTotalAgeOfAllPeopleTests
    {
        [Test]
        public void FindTotalAgeOfAllPeople_EmptyList_Returns0()
        {
            // Arrange 
            var people = TestData.NoPeople;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(0);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_AbbySmith_Returns29()
        {
            // Arrange 
            var people = TestData.AbbySmith;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(29);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_Everyone_Returns403()
        {
            // Arrange 
            var people = TestData.LotsOfPeople;

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(403);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_Array_ReturnsTotal()
        {
            // Arrange 
            var people = new Person[]
            {
                new Person("Array", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 20, Colour.Red, "Collections"),
                new Person("Billy", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 30, Colour.Red, "Collections"),
                new Person("Cherry", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 40, Colour.Red, "Collections")
            };

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(90);
        }

        [Test]
        public void FindTotalAgeOfAllPeople_Set_ReturnsTotal()
        {
            // Arrange 
            var people = new HashSet<Person>
            {
                new Person("Array", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 20, Colour.Red, "Collections"),
                new Person("Billy", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 30, Colour.Red, "Collections"),
                new Person("Cherry", "Not", new List<string> { "A", "List" }, new DateTime(2000, 1, 1), 40, Colour.Red, "Collections")
            };

            // Act
            var totalAge = AdvancedLinq.FindTotalAgeOfAllPeople(people);

            // Assert
            totalAge.Should().Be(90);
        }
    }
}