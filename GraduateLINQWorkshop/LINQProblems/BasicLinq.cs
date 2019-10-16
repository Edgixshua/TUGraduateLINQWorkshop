using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class BasicLinq
    {
        public static List<string> GetFirstNamesOfPeople(List<Person> people)
        {
            return people.Select(p => p.FirstName).ToList();
        }

        // This is an inclusive older than, e.g. someone with an age of 18 counts as being older
        // than a specified age of 18
        public static List<Person> GetPeopleOlderThan(List<Person> people, int age)
        {
            return people.Where(p => p.Age >= age).ToList();
        }

        public static bool IncludesPersonWithName(List<Person> people, string name)
        {
            return people.Any(p => p.FirstName.Equals(name));
        }

        public static List<Person> OrderByAgeAscending(List<Person> people)
        {
            return people.OrderBy(p => p.Age).ToList();
        }

        public static List<Person> OrderByAgeDescending(List<Person> people)
        {
            return people.OrderByDescending(p => p.Age).ToList();
        }

        public static Person FindOldestPerson(List<Person> people)
        {
            return people.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}