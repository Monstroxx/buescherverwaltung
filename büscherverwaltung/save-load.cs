using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace büscherverwaltung
{
    public class save_load
    {
        books büscher;
        Humans humans;
        human_borrowed human_borrowed;
        public save_load(books büscher, Humans humans, human_borrowed human_borrowed)
        {
            this.büscher = büscher;
            this.humans = humans;
            this.human_borrowed = human_borrowed;
        }
        public void save()
        {
            File.Delete("books.csv");
            File.Delete("humans.csv");
            //save as csv file
            for (int i = 0; i < büscher.büscherregal.Count; i++)
            {
                var book = büscher.büscherregal[i];
                File.AppendAllText("books.csv", book.title + ";" + book.isbn + ";" + book.sellprice + ";" + book.bisausgeliehn + ";" + book.idHuman + "\n");
            }
            for (int i = 0; i < humans.people.Count; i++)
            {
                var human = humans.people[i];
                // Speichere die IDs der ausgeliehenen Bücher als Komma-getrennte Liste
                string borrowedBooksIds = "";
                for (int j = 0; j < human.borrowed_books.Count; j++)
                {
                    if (j > 0) borrowedBooksIds += ",";
                    borrowedBooksIds += human.borrowed_books[j].bookid;
                }
                File.AppendAllText("humans.csv", human.firtname + ";" + human.lastname + ";" + human.email + ";" + human.Humanid + ";" + borrowedBooksIds + "\n");
            }
            //for (int i = 0; i < human_borrowed.borrowed_books.Count; i++)
            //{
            //    var borrowed_book = human_borrowed.borrowed_books[i];
            //    File.AppendAllText("borrowed_books.csv", borrowed_book.bookid + "\n");
            //}
        }

        public void load()
        {
            //load from csv file  
            if (File.Exists("books.csv"))
            {
                foreach (var line in File.ReadLines("books.csv"))
                {
                    var parts = line.Split(';');
                    if (parts.Length < 5) continue; // Skip invalid lines  
                    büscher.büscherregal.Add(new books.book()
                    {
                        title = parts[0],
                        isbn = parts[1],
                        sellprice = Convert.ToInt32(parts[2]),
                        bisausgeliehn = parts[3] == "01.01.0001 00:00:00" ? DateTime.MinValue : DateTime.Parse(parts[3]),
                        idHuman = Convert.ToInt32(parts[4])
                    });
                }
            }
            if (File.Exists("humans.csv"))
            {

                foreach (var line in File.ReadLines("humans.csv"))
                {
                    var parts = line.Split(';');
                    if (parts.Length < 5) continue; // Skip invalid lines  
                    var newPerson = new Humans.Person()
                    {
                        firtname = parts[0],
                        lastname = parts[1],
                        email = parts[2],
                        Humanid = Convert.ToInt32(parts[3])
                    };
                    
                    // Lade die ausgeliehenen Bücher
                    if (parts[4] != "")
                    {
                        string[] bookIds = parts[4].Split(',');
                        for (int i = 0; i < bookIds.Length; i++)
                        {
                            newPerson.borrowed_books.Add(new human_borrowed.borrowed_book()
                            {
                                bookid = Convert.ToInt32(bookIds[i])
                            });
                        }
                    }
                    
                    humans.people.Add(newPerson);
                }
            }
        }

    }
}
