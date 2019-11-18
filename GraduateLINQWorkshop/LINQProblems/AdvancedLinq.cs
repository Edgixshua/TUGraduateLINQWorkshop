using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class AdvancedLinq
    {
        public static IList<Colour> FindAllFavouriteColours(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        public static IList<string> FindFirstNamesWhichExistInBothLists(IEnumerable<Person> people, IEnumerable<Person> otherPeople)
        {
            throw new NotImplementedException();
        }

        public static IDictionary<string, Colour> CreateDictionaryOfNameToFavouriteColour(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        public static int FindTotalAgeOfAllPeople(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        // Look at the tests for the output format
        // This one is tricky!
        public static string NamesWithOtherNamesIncluded(IEnumerable<Person> people)
        {
            return people.Aggregate("", (s, person) => s + $"{person.FirstName}, {ProcessOtherNames(person.OtherNames)}{person.LastName}\n");
        }

        private static string ProcessOtherNames(List<string> othernames)
        {
            if (othernames?.Any() != true)
            {
                return "";
            }

            return string.Join(", ", othernames) + ", ";
        }

        public static IEnumerable<string> SelectAllMiddleNames(IEnumerable<Person> people)
        {
            return people.SelectMany(p => p.OtherNames);
        }

        public static IList<string> SelectCombinationsOfSingleMiddleNames(IEnumerable<Person> people)
        {
            return people
                .Where(p => p.OtherNames?.Any() == true)
                .SelectMany(p => p.OtherNames, (p, otherName) => $"{p.FirstName}, {otherName}, {p.LastName}").ToList();
        }
    }
}