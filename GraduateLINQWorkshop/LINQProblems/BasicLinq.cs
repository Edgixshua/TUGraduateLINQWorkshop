using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQProblems
{
    public static class BasicLinq
    {
        public static List<string> GetFirstNamesOfPeople(List<Person> people)
        {
            var query = people.Select(n => n.FirstName);

            return query.ToList();
        }

        // This is an inclusive older than, e.g. someone with an age of 18 counts as being older
        // than a specified age of 18
        public static List<Person> GetPeopleOlderThan(List<Person> people, int age)
        {
            var query = people.Where(n => n.Age >= age).Select(n => n);

            return query.ToList();
        }

        public static bool IncludesPersonWithName(List<Person> people, string name)
        {
            var query = people.Any(n => n.FirstName == name);

            return query;
        }

        public static List<Person> OrderByAgeAscending(List<Person> people)
        {
            var query = people.OrderBy(n => n.Age);

            return query.ToList();
        }

        public static List<Person> OrderByAgeDescending(List<Person> people)
        {
            var query = people.OrderByDescending(n => n.Age);

            return query.ToList();
        }

        public static Person FindOldestPerson(List<Person> people)
        {
            var query = people.OrderByDescending(n => n.Age).FirstOrDefault();

            return query;
        }
    }
}