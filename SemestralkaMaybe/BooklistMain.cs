using SemestralkaLibrary;
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
    public partial class BooklistMain : Form
    {
        private EntitiesRecords entitiesRecords = new EntitiesRecords();
        public BooklistMain()
        {
            BooklistLogin booklistLogin = new BooklistLogin();
            booklistLogin.ShowDialog();
            entitiesRecords = booklistLogin.EntitiesRecords;
            if (booklistLogin.exitClicked == true)
            {
                Environment.Exit(0);
            }
            InitializeComponent();
        }
    }
}
