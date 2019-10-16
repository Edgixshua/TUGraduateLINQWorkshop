using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class BasicLinq
    {
        public static IEnumerable<int> GetNumberGreaterThan(IEnumerable<int> numbers, int greaterThan)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<int> OrderNumbersAscending(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public static List<string> GetFirstNamesOfPeople(List<Person> people)
        {
            throw new NotImplementedException();
        }

        // This is an inclusive older than, e.g. someone with an age of 18 counts as being older
        // than a specified age of 18
        public static List<Person> GetPeopleOlderThan(List<Person> people, int age)
        {
            throw new NotImplementedException();
        }

        public static bool IncludesPersonWithName(List<Person> people, string name)
        {
            throw new NotImplementedException();
        }

        public static List<Person> OrderByAgeAscending(List<Person> people)
        {
            throw new NotImplementedException();
        }

        public static List<Person> OrderByAgeDescending(List<Person> people)
        {
            throw new NotImplementedException();
        }

        public static Person FindOldestPerson(List<Person> people)
        {
            throw new NotImplementedException();
        }
    }
}