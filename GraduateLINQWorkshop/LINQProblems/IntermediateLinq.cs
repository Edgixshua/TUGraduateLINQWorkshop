using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class IntermediateLinq
    {
        public static List<Person> CombinePeople(List<Person> people, List<Person> otherPeople)
        {
            throw new NotImplementedException();
        }

        public static List<string> NamesOfPeopleOlderThan(List<Person> people, int age)
            => people.Where(person => person.Age > age).Select(s => s.FirstName).ToList();


        public static int CalculateHowManyPeopleLiveIn(List<Person> people, string birthplace)
            => people.Count(person => person.PlaceOfBirth == birthplace);


        public static IList<Person> FindPeopleWhosFavouriteColourIs(IEnumerable<Person> people, Colour favouriteColour)
            => people.Where(person => person.FavouriteColour == favouriteColour).ToList();


        public static bool DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(IEnumerable<Person> people, int age, Colour favouriteColour)
            => people.Where(person => person.Age > age).Select(person => person.FavouriteColour == favouriteColour).Contains(true);


        public static IList<Person> PeopleWithOtherNames(IEnumerable<Person> people)
            => people.Where(person => person.OtherNames?.Any() == true).ToList();

        public static IEnumerable<Person> PeopleWithOtherNameOf(IEnumerable<Person> people, string name)
            => people.Where(person => person.OtherNames?.Any() == true).Where(s => s.OtherNames.Contains(name));
    }
}