using System;
using System.Collections.Generic;

namespace LINQProblems
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<string> OtherNames { get; }
        public DateTime DateOfBirth { get; }
        public int Age { get; }
        public Colour FavouriteColour { get; }
        public string PlaceOfBirth { get; }

        public Person(string firstName, string lastName, List<string> otherNames, DateTime dateOfBirth, int age, Colour favouriteColour, string placeOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            OtherNames = otherNames;
            DateOfBirth = dateOfBirth;
            Age = age;
            FavouriteColour = favouriteColour;
            PlaceOfBirth = placeOfBirth;
        }
    }
}