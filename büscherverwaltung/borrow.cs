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
            info_p.Items.Add(selectedBook.bisausgeliehn.ToString("d")); // Format date as short date string
        }

        private void button1_Click(object sender, EventArgs e)
        {
            humans.people.Add(new Humans.Person()
            {
                lastname = name_i.Text,
                firtname = firstname_i.Text,
                email = email_i.Text,
                borrowed_books = human_borrowed.borrowed_books.Add(new human_borrowed.borrowed_book()
                {
                    bookid = buscher.büscherregal[form.p_selectedbook].id
                }),
            });
            buscher.büscherregal[form.p_selectedbook].bisausgeliehn = DateTime.Now; // Set the borrow date to now  
            form.list(); // Update the book list in the main form
            this.Close(); // Close the borrow form
        }
    }
}
