using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace büscherverwaltung
{
    public class books
    {
        public List<book> büscherregal;
        public books() {
            büscherregal = new List<book>();
        }

        public class book
        {
            public string title;
            public string isbn;
            public int sellprice;
            public DateTime bisausgeliehn;
            public bool isborrowed
            {
                get { return bisausgeliehn != DateTime.MinValue; }
            }
        }
    }
}
