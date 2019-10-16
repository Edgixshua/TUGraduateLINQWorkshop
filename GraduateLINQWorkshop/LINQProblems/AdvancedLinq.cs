using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class AdvancedLinq
    {
        public static IList<Colour> FindAllFavouriteColours(IEnumerable<Person> people)
        {
            return people.Select(p => p.FavouriteColour).Distinct().ToList();
        }

        public static IList<string> FindFirstNamesWhichExistInBothLists(IEnumerable<Person> people, IEnumerable<Person> otherPeople)
        {
            return people.Where(p => otherPeople.Any(o => o.FirstName.Equals(p.FirstName))).Select(s => s.FirstName).ToList();
            //return people.Intersect(otherPeople,new IEqualityComparer())

        }

        public static IDictionary<string, Colour> CreateDictionaryOfNameToFavouriteColour(IEnumerable<Person> people)
        {
            return people.ToDictionary(p => p.FirstName, p => p.FavouriteColour);
        }

        public static int FindTotalAgeOfAllPeople(IEnumerable<Person> people)
        {
            return people.Select(p => p.Age).Sum();
        }

        // Look at the tests for the output format   "Abby, Olivia, Smith\n"
        // This one is tricky!      first, other, last
        public static string NamesWithOtherNamesIncluded(IEnumerable<Person> people)
        {
            var firstnames = people.Select(p => p.FirstName).ToList();
            var othernames = people.Select(p => p.OtherNames).ToList();
            var lastnames = people.Select(p => p.LastName).ToList();

            string result = "";
            for (int i = 0; i < people.Count(); i++)
            {
                result += firstnames[i] + ", ";

                if (people.ElementAt(i).OtherNames != null)
                {
                    foreach (string s in othernames[i])
                    {
                        result += s + ", ";
                    }
                }

                result += lastnames[i] + "\n";
            }

            return result;

        }
    }
}