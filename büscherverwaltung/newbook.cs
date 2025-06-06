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
    public partial class newbook : Form
    {
        books buscher;
        Form1 form;
        public newbook(books buscher, Form1 form)
        {
            InitializeComponent();
            this.buscher = buscher;
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscher.büscherregal.Add(new books.book()
            {
                title = booktitle_i.Text,
                isbn = isbn_i.Text,
                sellprice = Convert.ToInt32(sellprice_i.Text)
            });
            //close form
            this.Close();
            form.list(); // Update the book list in the main form
        }
    }
}
