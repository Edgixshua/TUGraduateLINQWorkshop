using System;
using System.Collections.Generic;

namespace LINQProblems.Implemented
{
    public static class BasicLinq
    {
        public static List<string> GetFirstNamesOfPeople(List<Person> people)
        {
            var names = new List<string>();

            foreach (var person in people)
            {
                names.Add(person.FirstName);
            }

            return names;
        }

        public static List<Person> GetPeopleOlderThan(List<Person> people, int age)
        {
            var peopleOlderThanAge = new List<Person>();

            foreach (var person in people)
            {
                if (person.Age >= age)
                {
                    peopleOlderThanAge.Add(person);
                }
            }

            return peopleOlderThanAge;
        }

        public static bool IncludesPersonWithName(List<Person> people, string name)
        {
            foreach (var person in people)
            {
                if (person.FirstName == name)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Person> OrderByAgeAscending(List<Person> people)
        {
            var test = new OrderAscending();

            people.Sort(test);

            return people;
        }

        public static List<Person> OrderByAgeDescending(List<Person> people)
        {
            var test = new OrderDescending();

            people.Sort(test);

            return people;
        }

        public static Person FindOldestPerson(List<Person> people)
        {
            Person oldestPerson = null;

            foreach (var person in people)
            {
                if (oldestPerson == null)
                {
                    oldestPerson = person;
                }
                else
                {
                    if (person.Age > oldestPerson.Age)
                    {
                        oldestPerson = person;
                    }
                }
            }

            return oldestPerson;
        }

        private class OrderDescending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                if (x.Age.CompareTo(y.Age) != 0)
                {
                    return y.Age.CompareTo(x.Age);
                }

                return 0;
            }
        }

        private class OrderAscending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                if (y.Age.CompareTo(x.Age) != 0)
                {
                    return x.Age.CompareTo(y.Age);
                }

                return 0;
            }
        }
    }
}