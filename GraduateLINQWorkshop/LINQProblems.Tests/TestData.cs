using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;

namespace LINQProblems.Tests
{
    public static class TestData
    {
        public static List<Person> NoPeople { get; } = new List<Person>();

        public static List<Person> AbbySmith { get; } = new List<Person>
        {
            new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds")
        };

        public static List<Person> LotsOfPeople { get; } = new List<Person>
        {
            new Person("Abby", "Smith", new List<string> { "Olivia" }, new DateTime(1990, 1, 5), 29, Colour.Blue, "Leeds"),
            new Person("Bob", "Humphrey", new List<string>(), new DateTime(1956, 12, 5), 12, Colour.Orange, "Leeds"),
            new Person("Charlie", "Paul", null, new DateTime(2009, 5, 5), 10, Colour.Purple, "Lancaster"),
            new Person("Dani", "Hayes", new List<string> { "Holmes", "Reed" }, new DateTime(1986, 6, 5), 55, Colour.Blue, "Sheffield"),
            new Person("Ellie", "Ball", new List<string> { "Hunt" }, new DateTime(1975, 7, 5), 37, Colour.Blue, "Leeds"),
            new Person("Felicity", "Plott", new List<string>(), new DateTime(1800, 4, 5), 99, Colour.Blue, "London"),
            new Person("George", "Hayes", new List<string> { "Olivia" }, new DateTime(1925, 10, 5), 74, Colour.Blue, "Leeds"),
            new Person("Hannah", "Baller", new List<string> { "Nelson", "Hunt", "Reed" }, new DateTime(1950, 1, 5), 5, Colour.Blue, "London"),
            new Person("Ismail", "Ray", new List<string> { "Francis", null }, new DateTime(2200, 9, 5), 46, Colour.Green, "Leeds"),
            new Person("Jake", "Smith", new List<string> { "\n" }, new DateTime(1995, 3, 5), 18, Colour.Blue, "Nowhere"),
            new Person("Lenny", "Smith", new List<string> { "1231914=9123812=03&&&%%%" }, new DateTime(1990, 1, 5), 18, Colour.Blue, "Leeds")
        };

        public static List<Person> AllThePeople { get; } = CreatePeople();

        private static List<Person> CreatePeople()
        {
            var fixture = new Fixture();

            return fixture.CreateMany<Person>(100000).ToList();
        }
    }
}