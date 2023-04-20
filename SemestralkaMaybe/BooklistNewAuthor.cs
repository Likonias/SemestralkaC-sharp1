using Microsoft.VisualBasic;
using SemestralkaMaybe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralkaMaybe
{
    public partial class BooklistNewAuthor : Form
    {
        private Author createdAuthor;
        public Author CreatedAuthor { get => createdAuthor; set => createdAuthor = value; }
        public BooklistNewAuthor(Author author)
        {
            InitializeComponent();
            createdAuthor = author;
            if (CreatedAuthor != null)
            {
                textBoxName.Text = createdAuthor.Name;
                textBoxSurname.Text = createdAuthor.Surname;
                textBoxBornIn.Text = createdAuthor.BornInYear.ToString();
                textBoxDiedIn.Text = createdAuthor?.DiedInYear.ToString();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBoxBornIn.Text, out int bornIn);
                int.TryParse(textBoxDiedIn.Text, out int diedIn);
                if (textBoxName.Text.Length == 0 || textBoxSurname.Text.Length == 0 || bornIn == null)
                {
                    throw new Exception("Something went wrong, try again please!");
                }
                if ((0 < bornIn && bornIn < DateAndTime.Now.Year) && ((0 < diedIn && diedIn < DateAndTime.Now.Year) || diedIn == null))
                {
                    if (bornIn >= diedIn)
                    {
                        throw new Exception("Born in can't be higher than died in!");
                    }
                    createdAuthor = new Author(textBoxName.Text, textBoxSurname.Text, bornIn, diedIn, null);
                    this.Close();
                }
                else
                {
                    throw new Exception("Wrong year! Try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            createdAuthor = null;
            this.Close();
        }
    }
}
