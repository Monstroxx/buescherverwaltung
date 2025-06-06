using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace büscherverwaltung
{
    public partial class Form1 : Form
    {
        public books buscher = new books();
        Humans humans;
        human_borrowed human_borrowed = new human_borrowed();
        newbook newbook;
        borrow borrow;
        public int p_selectedbook = -1;

        public Form1()
        {
            InitializeComponent();
            // Initialize
            humans = new Humans(human_borrowed);
            newbook = new newbook(buscher, this);
            borrow = new borrow(buscher, humans, this, human_borrowed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //verknüpft büscherregal_SelectedIndexChanged
            büscherregal.SelectedIndexChanged += büscherregal_SelectedIndexChanged;
        }

        //rand book
        private void button2_Click(object sender, EventArgs e)
        {
            //add random book
            buscher.büscherregal.Add(new books.book()
            {
                title = "Random Book",
                isbn = "123-456-789",
                sellprice = 20
            });
            list();
        }

        //new book
        private void button1_Click(object sender, EventArgs e)
        {
            //open new book form
            newbook.ShowDialog();
        }

        public void list()
        {
            // List all books  
            büscherregal.Items.Clear();
            foreach (var book in buscher.büscherregal)
            {
                büscherregal.Items.Add(book.title + "" + book.isbn + "" + "" + book.sellprice);
            }
            // Reset selected book index  
            p_selectedbook = -1;
            info_p.Items.Clear(); // Clear the info list box  
            büscherregal.SelectedItems.Clear(); // Correctly deselect all selected items  
        }
        //wenn busch in der listbox ausgewählt wurde
        private void büscherregal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure a valid selection is made  
            if (büscherregal.SelectedItems.Count > 0)
            {
                var selectedIndex = büscherregal.SelectedIndices[0];
                var selectedBook = buscher.büscherregal[selectedIndex];
                p_selectedbook = selectedIndex; // Store the selected book index
                info_p.Items.Clear();
                info_p.Items.Add(selectedBook.title);
                info_p.Items.Add(selectedBook.isbn);
                info_p.Items.Add(selectedBook.sellprice.ToString() + " €");
                //if book is borrowed, show human who borrowed it
                if (selectedBook.isborrowed)
                {
                    for (int i = 0; i < humans.people.Count; i++)
                    {
                        for (int j = 0; j < humans.people[i].borrowed_books.Count; j++)
                        {
                            if (humans.people[i].borrowed_books[j].bookid == selectedIndex)
                            {
                                info_p.Items.Add("Ausgeliehen von: " + humans.people[i].firtname + " " + humans.people[i].lastname);
                                info_p.Items.Add("Email: " + humans.people[i].email);
                                info_p.Items.Add("Bis zum: " + selectedBook.bisausgeliehn.ToString("dd.mm.yyyy "));
                                break; // Stop after finding the first match
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p_selectedbook == -1)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }
            if (buscher.büscherregal[p_selectedbook].isborrowed)
            {
                MessageBox.Show("This book is already borrowed.");
                return;
            }
            borrow.ShowDialog();
        }
    }
}
