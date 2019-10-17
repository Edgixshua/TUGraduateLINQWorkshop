using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class IntermediateLinq
    {
        public static List<Person> CombinePeople(List<Person> people, List<Person> otherPeople)
        {
            return people.Concat(otherPeople).ToList();
        }

        public static List<string> NamesOfPeopleOlderThan(List<Person> people, int age)
        {
            return (from p in people
                    where p.Age >= age
                    select p.FirstName).ToList();
        }


        public static int CalculateHowManyPeopleLiveIn(List<Person> people, string birthplace)
        {
            return people.Count(p => p.PlaceOfBirth == birthplace);
        }


        public static IList<Person> FindPeopleWhosFavouriteColourIs(IEnumerable<Person> people, Colour favouriteColour)
        {
            return (from p in people
                    where p.FavouriteColour == favouriteColour
                    select p).ToList();
        }


        public static bool DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(IEnumerable<Person> people, int age, Colour favouriteColour)
        {
            return people.Any(p => p.Age > age && p.FavouriteColour == favouriteColour);
        }


        public static IList<Person> PeopleWithOtherNames(IEnumerable<Person> people)
        {
            return people.Where(p => p.OtherNames != null && p.OtherNames.Count > 0).ToList();
        }

        public static IEnumerable<Person> PeopleWithOtherNameOf(IEnumerable<Person> people, string name)
        {
            return people.Where(p => p.OtherNames != null && p.OtherNames.Count > 0 && p.OtherNames.Contains(name));
        }
    }
}