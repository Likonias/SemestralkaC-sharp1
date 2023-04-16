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
            UserInfoInitialize();
            InitializeListViews();
            SelectListView();
        }

        private void UserInfoInitialize()
        {
            labelUserInfo.Text = "User info:\n\n"
                + "Name: " + selectedUser.Name + " " + selectedUser.Surname + "\n"
                + "Username: " + selectedUser.UserName + "\n"
                + "Time spent reading: " + selectedUser.TimeSpentReading;
        }
        private void SelectListView()
        {
            listViewMyCollection.Visible = false;
            listViewBooks.Visible = false;
            listViewAuthors.Visible = false;
            listViewTopUsers.Visible = false;

            switch(topBarSelected)
            {
                case enumTopBar.myCollection:
                    listViewMyCollection.Visible = true;
                    break;
                case enumTopBar.books:
                    listViewBooks.Visible = true;
                    break;
                case enumTopBar.authors:
                    listViewAuthors.Visible = true;
                    break;
                case enumTopBar.topUsers:
                    listViewTopUsers.Visible = true;
                    break;
                default: 
                    break;
            }
        }
        private void InitializeListViews()
        {
            listViewMyCollection.View = View.Details;
            listViewBooks.View = View.Details;
            listViewAuthors.View = View.Details;
            listViewTopUsers.View = View.Details;

            listViewMyCollection.Columns.Add("Title", 200);
            listViewMyCollection.Columns.Add("Author", 200);
            listViewMyCollection.Columns.Add("Times Read", 200);
            listViewMyCollection.Columns.Add("Date Read", 200);
            
            listViewBooks.Columns.Add("Title", 200);
            listViewBooks.Columns.Add("Author", 200);
            listViewBooks.Columns.Add("Release Year", 200);
            listViewBooks.Columns.Add("Average Read Time", 200);
            
            listViewAuthors.Columns.Add("Name", 200);
            listViewAuthors.Columns.Add("Surname", 200);
            listViewAuthors.Columns.Add("Born In", 200);
            listViewAuthors.Columns.Add("Died In", 200);
            
            listViewTopUsers.Columns.Add("Username", 200);
            listViewTopUsers.Columns.Add("Time Spent Reading", 200);
            
        }
        private void ClearListViews()
        {
            listViewAuthors.Items.Clear();
            listViewBooks.Items.Clear();
            listViewMyCollection.Items.Clear();
            listViewTopUsers.Items.Clear();
        }
    }
}
