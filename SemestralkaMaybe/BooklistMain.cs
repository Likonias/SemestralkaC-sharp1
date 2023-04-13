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
        private UserEntity selectedUser;
        private enum enumTopBar { myCollection, books, authors, topUsers }
        private enumTopBar topBarSelected;
        public BooklistMain()
        {
            InitializeComponent();
            topBarSelected = enumTopBar.myCollection;
            BooklistLogin booklistLogin = new BooklistLogin();
            booklistLogin.ShowDialog();
            selectedUser = booklistLogin.SelectedUser;
            entitiesRecords = booklistLogin.EntitiesRecords;
            if (booklistLogin.exitClicked == true)
            {
                Environment.Exit(0);
            }
            userInfoInitialize();
            initializeListViews();
        }

        private void userInfoInitialize()
        {
            labelUserInfo.Text = "User info:\n\n"
                + "Name: " + selectedUser.Name + " " + selectedUser.Surname + "\n"
                + "Username: " + selectedUser.UserName + "\n"
                + "Time spent reading: " + selectedUser.TimeSpentReading;
        }
        private void initializeListViews()
        {
            switch (topBarSelected)
            {
                case enumTopBar.myCollection:
                    break;
                case enumTopBar.books:
                    break;
                case enumTopBar.authors:
                    break;
                case enumTopBar.topUsers:
                    break;
                default:
                    break;
            }
        }
        private void clearListViews()
        {
            listViewAuthors.Items.Clear();
            listViewBooks.Items.Clear();
            listViewMyCollection.Items.Clear();
            listViewTopUsers.Items.Clear();
        }
    }
}
