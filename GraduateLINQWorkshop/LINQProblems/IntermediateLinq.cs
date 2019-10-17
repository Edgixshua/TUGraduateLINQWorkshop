using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LINQProblems
{
    public static class IntermediateLinq
    {
        public static List<Person> CombinePeople(List<Person> people, List<Person> otherPeople)
        {
            var query = people.Union(otherPeople).ToList();

            return query;
        }

        public static List<string> NamesOfPeopleOlderThan(List<Person> people, int age)
        {
            var query = people.Where(n => n.Age >= age)
                .Select(n => n.FirstName)
                .ToList();

            return query;
        }


        public static int CalculateHowManyPeopleLiveIn(List<Person> people, string birthplace)
        {
            var query = people.Where(n => n.PlaceOfBirth == birthplace).Count();

            return query;
        }


        public static IList<Person> FindPeopleWhosFavouriteColourIs(IEnumerable<Person> people, Colour favouriteColour)
        {
            var query = people.Where(n => n.FavouriteColour == favouriteColour).ToList();

            return query;
        }


        public static bool DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(IEnumerable<Person> people, int age, Colour favouriteColour)
        {
            var query = people.Where(n => n.Age >= age && n.FavouriteColour == favouriteColour).Any();

            return query;
        }


        public static IList<Person> PeopleWithOtherNames(IEnumerable<Person> people)
        {
            var query = people.Where(n => n.OtherNames != null && n.OtherNames.Count() != 0 );

            return query.ToList();
        }

        public static IEnumerable<Person> PeopleWithOtherNameOf(IEnumerable<Person> people, string name)
        {
            var query = people.Where(n => n.OtherNames != null && n.OtherNames.Count() != 0 && n.OtherNames.Contains(name));

            return query;
        }
    }
}