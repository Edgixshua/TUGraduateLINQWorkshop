using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class AdvancedLinq
    {
        public static IList<Colour> FindAllFavouriteColours(IEnumerable<Person> people)
        {
            var query = people
                .Select(p => p.FavouriteColour)
                .Distinct()
                .ToList();

            return query;
        }

        public static IList<string> FindFirstNamesWhichExistInBothLists(IEnumerable<Person> people, IEnumerable<Person> otherPeople)
        {
            var query = people.Intersect(otherPeople)
                .Distinct()
                .Select(p => p.FirstName)
                .ToList();

            

            return query;

            //Didn't pass these two tests
        }

        public static IDictionary<string, Colour> CreateDictionaryOfNameToFavouriteColour(IEnumerable<Person> people)
        {
            var query = people.ToDictionary(p => p.FirstName, p => p.FavouriteColour);

            return query;
        }

        public static int FindTotalAgeOfAllPeople(IEnumerable<Person> people)
        {
            var query = people.Select(p => p.Age).ToList();

            var total = query.Sum();

            return total;
        }

        // Look at the tests for the output format
        // This one is tricky!
        public static string NamesWithOtherNamesIncluded(IEnumerable<Person> people)
        {
            var query = people.Where(n => n.OtherNames != null && n.OtherNames.Count() != 0).Select(n => new { n.FirstName, n.OtherNames, n.LastName }).GroupBy(p => p.FirstName).OrderBy(g => g.Key).ToString();

            return query;

            //Can't do this, need to output a string, not turn a query to a string
        }
    }
}