using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace büscherverwaltung
{
    public class Humans
    {
        public List<Person> people;
        public Humans()
        {
            people = new List<Person>();
        }

        public class Person
        {
            public string firtname;
            public string lastname;
            public string email;
        }
    }
}
