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
            try
            {
                LoadEntities();
            }
            catch (Exception)
            {
                Console.WriteLine("Loading Unable");
            }
            Login();
            UserInfoInitialize();
            InitializeListViews();
            buttonMyCollection_Click(buttonMyCollection, EventArgs.Empty);
            
        }
        private void LoadEntities()
        {
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializerUsers = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
            fileSerializerDeserializerUsers.Load();
            FileSerializerDeserializer<Author> fileSerializerDeserializerAuthors = new FileSerializerDeserializer<Author>(entitiesRecords, "authorEntityData.author");
            fileSerializerDeserializerAuthors.Load();
            FileSerializerDeserializer<Book> fileSerializerDeserializerBooks = new FileSerializerDeserializer<Book>(entitiesRecords, "bookEntityData.book");
            fileSerializerDeserializerBooks.Load();
        }
        private void SaveEntities()
        {
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializerUsers = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
            fileSerializerDeserializerUsers.Save();
            FileSerializerDeserializer<Author> fileSerializerDeserializerAuthors = new FileSerializerDeserializer<Author>(entitiesRecords, "authorEntityData.author");
            fileSerializerDeserializerAuthors.Save();
            FileSerializerDeserializer<Book> fileSerializerDeserializerBooks = new FileSerializerDeserializer<Book>(entitiesRecords, "bookEntityData.book");
            fileSerializerDeserializerBooks.Save();
        }
        private void Login()
        {
            BooklistLogin booklistLogin = new BooklistLogin(entitiesRecords);
            booklistLogin.ShowDialog();
            selectedUser = booklistLogin.SelectedUser;
            entitiesRecords = booklistLogin.EntitiesRecords;
            if (booklistLogin.exitClicked == true)
            {
                Environment.Exit(0);
            }
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

            listViewMyCollection.Columns.Add("Title", 195);
            listViewMyCollection.Columns.Add("Author", 195);
            listViewMyCollection.Columns.Add("Times Read", 195);
            listViewMyCollection.Columns.Add("Date Read", 195);
            
            listViewBooks.Columns.Add("Title", 195);
            listViewBooks.Columns.Add("Author", 195);
            listViewBooks.Columns.Add("Release Year", 195);
            listViewBooks.Columns.Add("Average Read Time", 195);
            
            listViewAuthors.Columns.Add("Name", 195);
            listViewAuthors.Columns.Add("Surname", 195);
            listViewAuthors.Columns.Add("Born In", 195);
            listViewAuthors.Columns.Add("Died In", 195);
            
            listViewTopUsers.Columns.Add("Username", 390);
            listViewTopUsers.Columns.Add("Time Spent Reading", 390);
            
        }
        private void ClearListViews()
        {
            listViewAuthors.Items.Clear();
            listViewBooks.Items.Clear();
            listViewMyCollection.Items.Clear();
            listViewTopUsers.Items.Clear();
        }

        private void ClearSelectedButton()
        {
            buttonMyCollection.BackColor= Color.White;
            buttonBooks.BackColor= Color.White;
            buttonAuthors.BackColor= Color.White;   
            buttonTopUsers.BackColor= Color.White;
        }

        private void buttonMyCollection_Click(object sender, EventArgs e)
        {
            ClearSelectedButton();
            buttonMyCollection.BackColor= Color.LightGreen;
            topBarSelected = enumTopBar.myCollection;
            SelectListView();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            ClearSelectedButton();
            buttonBooks.BackColor = Color.LightGreen;
            topBarSelected = enumTopBar.books;
            SelectListView();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            ClearSelectedButton();
            buttonAuthors.BackColor = Color.LightGreen;
            topBarSelected = enumTopBar.authors;
            SelectListView();
        }

        private void buttonTopUsers_Click(object sender, EventArgs e)
        {
            ClearSelectedButton();
            buttonTopUsers.BackColor = Color.LightGreen;
            topBarSelected = enumTopBar.topUsers;
            SelectListView();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ClearListViews();
            Login();
            UserInfoInitialize();
            InitializeListViews();
            buttonMyCollection_Click(buttonMyCollection, EventArgs.Empty);
        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            SaveEntities();
            Environment.Exit(0);
        }
    }
}
