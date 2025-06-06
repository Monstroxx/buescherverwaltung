using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace büscherverwaltung
{
    public class human_borrowed
    {
        public List<borrowed_book> borrowed_books;
        public human_borrowed()
        {
            borrowed_books = new List<borrowed_book>();
        }

        public class borrowed_book
        {
            int bookId; // ID of the borrowed book
        }
    }
}
