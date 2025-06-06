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
        Humans humans = new Humans();
        newbook newbook;
        borrow borrow;
        public int p_selectedbook = -1;

        public Form1()
        {
            InitializeComponent();
            // Initialize
            newbook = new newbook(buscher, this);
            borrow = new borrow(buscher, humans, this);
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
                info_p.Items.Add(selectedBook.bisausgeliehn.ToString("d")); // Format date as short date string
                info_p.Items.Add(selectedBook.isborrowed ? "Ausgeliehen" : "Verfügbar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p_selectedbook == -1)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }
            borrow.ShowDialog();
        }
    }
}
