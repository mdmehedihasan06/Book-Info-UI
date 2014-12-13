using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoUIApp
{
    public partial class bookInfoUI : Form
    {
        Hashtable bookInfo = new Hashtable();
        public bookInfoUI()
        {
            InitializeComponent();
        }

        private void addInfoButton_Click(object sender, EventArgs e)
        {

            if (bookInfo.ContainsKey(isbnToAddBookTextBox.Text))
            {
                MessageBox.Show("This Book info is already in list.");
            }
            else
            {
                bookInfo.Add(isbnToAddBookTextBox.Text, bookDetailsAddTextBox.Text);
                MessageBox.Show("The info of this book is saved.");
            }
        }

        private void searchInfoButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnToSearchBookTextBox.Text))
            {
                string details = Convert.ToString(bookInfo[isbnToSearchBookTextBox.Text]);
                bookDetailsSearchTextBox.Text = details;
            }
            else
            {
                MessageBox.Show("There is no book in the list with this ISBN.");
            }
        }
    }
}
