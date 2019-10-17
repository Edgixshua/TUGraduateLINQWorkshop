using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class AdvancedLinq
    {
        public static IList<Colour> FindAllFavouriteColours(IEnumerable<Person> people)
        {
            var query = people.Select(p => p.FavouriteColour).Distinct().ToList();

            return query;
        }

        public static IList<string> FindFirstNamesWhichExistInBothLists(IEnumerable<Person> people, IEnumerable<Person> otherPeople)
        {
            var query = people.Select(p => p.FirstName).Intersect(otherPeople.Select(o => o.FirstName))
                .ToList();

            return query;
        }

        public static IDictionary<string, Colour> CreateDictionaryOfNameToFavouriteColour(IEnumerable<Person> people)
        {
            var query = people.ToDictionary(p => p.FirstName, p => p.FavouriteColour);

            return query;
        }

        public static int FindTotalAgeOfAllPeople(IEnumerable<Person> people)
        {
            var query = people.Select(p => p.Age).ToList().Sum();

            return query;
        }

        // Look at the tests for the output format
        // This one is tricky!
        public static string NamesWithOtherNamesIncluded(IEnumerable<Person> people)
        {
            var query = people.Where(n => n.OtherNames != null && n.OtherNames.Count() != 0).Select(n => new { n.FirstName, n.OtherNames, n.LastName }).Distinct().ToString();

            //var PeopleList = new List<Person>();

            //foreach (var person in query)
            //{
            //    PeopleList.Add(person);
            //}

            return query;

            //Can't do this, need to output a string, not turn a query to a string
        }
    }
}