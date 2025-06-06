using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace büscherverwaltung
{
    public partial class borrow : Form
    {
        books buscher;
        Humans humans;
        Form1 form;
        human_borrowed human_borrowed;
        public borrow(books buscher, Humans humans, Form1 form, human_borrowed human_borrowed)
        {
            InitializeComponent();
            this.form = form;
            this.buscher = buscher;
            this.humans = humans;
            this.human_borrowed = human_borrowed;
        }

        private void borrow_Load(object sender, EventArgs e)
        {
            var selectedBook = buscher.büscherregal[form.p_selectedbook];
            info_p.Items.Clear();
            info_p.Items.Clear();
            info_p.Items.Add(selectedBook.title);
            info_p.Items.Add(selectedBook.isbn);
            info_p.Items.Add(selectedBook.sellprice.ToString() + " €");

            //reset inputs
            name_i.Text = "";
            firstname_i.Text = "";
            email_i.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Erstelle eine neue Person
            var newPerson = new Humans.Person()
            {
                lastname = name_i.Text,
                firtname = firstname_i.Text,
                email = email_i.Text,
                Humanid = humans.people.Count + 1
            };
            
            // Füge das ausgeliehene Buch zur Liste der Person hinzu
            newPerson.borrowed_books.Add(new human_borrowed.borrowed_book()
            {
                bookid = form.p_selectedbook // Verwende den Index als ID
            });
            
            // Füge die Person zur Liste hinzu
            humans.people.Add(newPerson);
            
            // Markiere das Buch als ausgeliehen
            buscher.büscherregal[form.p_selectedbook].bisausgeliehn = DateTime.Now;
            
            form.list(); // Update die Bücherliste
            this.Close(); // Schließe das Fenster
        }
    }
}
