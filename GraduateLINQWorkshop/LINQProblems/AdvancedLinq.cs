using System;
using System.Collections.Generic;

namespace LINQProblems
{
    public static class AdvancedLinq
    {
        // e.g. [FirstName, Othername1, Othername2, LastName]
        // Or for no othernames [FirstName, LastName]
        public static IList<string> NamesWithOtherNamesIncluded(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

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
    }
}