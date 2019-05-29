using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - BirthDate;
                return timespan.Days / 365;
            }
        }

    }
}