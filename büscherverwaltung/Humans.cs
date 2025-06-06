using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace büscherverwaltung
{
    public class Humans
    {
        public List<Person> people;
        human_borrowed human_Borrowed1;
        public Humans(human_borrowed human_Borrowed1)
        {
            people = new List<Person>();
            this.human_Borrowed1 = human_Borrowed1;
        }

        public class Person
        {
            public string firtname;
            public string lastname;
            public string email;
            public int Humanid;
            public List<human_borrowed.borrowed_book> borrowed_books;
            
            public Person()
            {
                borrowed_books = new List<human_borrowed.borrowed_book>();
            }
        }
    }
}
