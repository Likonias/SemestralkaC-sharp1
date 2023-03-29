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
    public partial class BooklistNewUser : Form
    {
        public UserEntity user;
        public BooklistNewUser()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxEMail.Text.Length == 0 || textBoxName.Text.Length == 0 || textBoxSurname.Text.Length == 0 || textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0)
                {
                    throw new Exception();
                }
                string password1 = textBoxPassword.Text;
                string password2 = textBoxPasswordAgain.Text;
                if(password1.Equals(password2))
                {
                    user = new UserEntity(textBoxName.Text, textBoxSurname.Text, textBoxUsername.Text, password2, textBoxEMail.Text);
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
