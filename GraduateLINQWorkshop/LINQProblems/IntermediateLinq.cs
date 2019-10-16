using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class IntermediateLinq
    {
        public static List<Person> CombinePeople(List<Person> people, List<Person> otherPeople)
        {
            return people.Union(otherPeople).ToList();
        }

        public static List<string> NamesOfPeopleOlderThan(List<Person> people, int age)
        {
            return people.Where(p => p.Age >= age).Select(p => p.FirstName).ToList();
        }


        public static int CalculateHowManyPeopleLiveIn(List<Person> people, string birthplace)
        {
            return people.Count(p => p.PlaceOfBirth.Equals(birthplace));
        }


        public static IList<Person> FindPeopleWhosFavouriteColourIs(IEnumerable<Person> people, Colour favouriteColour)
        {
            return people.Where(p => p.FavouriteColour.Equals(favouriteColour)).ToList();
        }


        public static bool DoesSomeoneExistWhoIsOverAgeWithFavouriteColourOf(IEnumerable<Person> people, int age, Colour favouriteColour)
        {
            return people.Any(p => p.Age >= age && p.FavouriteColour.Equals(favouriteColour));
        }


        public static IList<Person> PeopleWithOtherNames(IEnumerable<Person> people)
        {
            return people.Where(p => p.OtherNames!=null && p.OtherNames.Count>0).ToList();
        }

        public static IEnumerable<Person> PeopleWithOtherNameOf(IEnumerable<Person> people, string name)
        {
            return people.Where(p => p.OtherNames != null &&  p.OtherNames.Contains(name));
        }
    }
}