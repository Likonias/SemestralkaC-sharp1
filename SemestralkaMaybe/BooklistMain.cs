﻿using SemestralkaLibrary;
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
            LoadEntities();
            Login();
            UserInfoInitialize();
            InitializeListViews();
            buttonMyCollection_Click(buttonMyCollection, EventArgs.Empty);
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
                + "Time spent reading: " + selectedUser.TimeSpentReading;
        }

        private void SelectListView()
        {
            ClearListViews();
            listViewMyCollection.Visible = false;
            listViewBooks.Visible = false;
            listViewAuthors.Visible = false;
            listViewTopUsers.Visible = false;
            buttonAdd.Visible = true;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;
            buttonAddToMyCollection.Visible = false;
            buttonShowAuthorsWorks.Visible = false;
            buttonReread.Visible = false;
            buttonAdd.Text = "Add";
            switch (topBarSelected)
            {
                case enumTopBar.myCollection:
                    foreach (Book book in selectedUser.BooksRead)
                    {
                        ListViewItem listViewItem = new ListViewItem(book.Title);
                        listViewItem.SubItems.Add(book.Author.FullName);
                        listViewItem.SubItems.Add(book.TimesRead.ToString());
                        listViewItem.SubItems.Add(book.DateRead.ToString());
                        listViewMyCollection.Items.Add(listViewItem);
                    }
                    listViewMyCollection.Visible = true;
                    buttonReread.Visible = true;
                    buttonAdd.Visible = false;
                    buttonEdit.Visible = false;
                    break;
                case enumTopBar.books:
                    foreach (Book book in entitiesRecords.Books)
                    {
                        ListViewItem listViewItem = new ListViewItem(book.Title);
                        listViewItem.SubItems.Add(book.Author.FullName);
                        listViewItem.SubItems.Add(book.ReleaseYear.ToString());
                        listViewItem.SubItems.Add(book.AverageReadTime.ToString());
                        listViewBooks.Items.Add(listViewItem);
                    }
                    listViewBooks.Visible = true;
                    buttonAddToMyCollection.Visible = true;
                    buttonAdd.Text = "Add Book";
                    break;
                case enumTopBar.authors:
                    foreach (Author author in entitiesRecords.Authors)
                    {
                        ListViewItem listViewItem = new ListViewItem(author.Name);
                        listViewItem.SubItems.Add(author.Surname);
                        listViewItem.SubItems.Add(author.BornInYear.ToString());
                        if (author.DiedInYear == null)
                        {
                            listViewItem.SubItems.Add("-");
                        }
                        else
                        {
                            listViewItem.SubItems.Add(author.DiedInYear.ToString());
                        }
                        listViewAuthors.Items.Add(listViewItem);
                    }
                    listViewAuthors.Visible = true;
                    buttonShowAuthorsWorks.Visible = true;
                    buttonAdd.Text = "Add Author";
                    break;
                case enumTopBar.topUsers:
                    List<UserEntity> topUsers = entitiesRecords.UserEntities.OrderByDescending(e => e.TimeSpentReading).ToList();
                    for (int i = 0; i < topUsers.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem(topUsers.ElementAt(i).Name + " " + topUsers.ElementAt(i).Surname);
                        listViewItem.SubItems.Add(topUsers.ElementAt(i).TimeSpentReading.ToString());
                        listViewTopUsers.Items.Add(listViewItem);
                    }
                    listViewTopUsers.Visible = true;
                    buttonAdd.Visible = false;
                    buttonEdit.Visible = false;
                    buttonRemove.Visible = false;
                    break;
            }
            UserInfoInitialize();
        }
        private void InitializeListViews()
        {
            listViewMyCollection.View = View.Details;
            listViewBooks.View = View.Details;
            listViewAuthors.View = View.Details;
            listViewTopUsers.View = View.Details;

            listViewMyCollection.FullRowSelect = true;
            listViewBooks.FullRowSelect = true;
            listViewAuthors.FullRowSelect = true;
            listViewTopUsers.FullRowSelect = true;

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

            listViewTopUsers.Columns.Add("User's Name", 390);
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
            buttonMyCollection.BackColor = Color.White;
            buttonBooks.BackColor = Color.White;
            buttonAuthors.BackColor = Color.White;
            buttonTopUsers.BackColor = Color.White;
        }

        private void buttonMyCollection_Click(object sender, EventArgs e)
        {
            ClearSelectedButton();
            buttonMyCollection.BackColor = Color.LightGreen;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (topBarSelected)
            {
                case enumTopBar.books:
                    BooklistNewBook booklistNewBook = new BooklistNewBook(entitiesRecords.Authors, null);
                    booklistNewBook.Text = "Booklist New Book";
                    booklistNewBook.ShowDialog();
                    if (booklistNewBook.CreatedBook != null)
                    {
                        entitiesRecords.AddBook(booklistNewBook.CreatedBook);
                    }
                    break;
                case enumTopBar.authors:
                    BooklistNewAuthor booklistNewAuthor = new BooklistNewAuthor(null);
                    booklistNewAuthor.Text = "Booklist New Author";
                    booklistNewAuthor.ShowDialog();
                    if (booklistNewAuthor.CreatedAuthor != null)
                    {
                        entitiesRecords.AddAuthor(booklistNewAuthor.CreatedAuthor);
                    }
                    break;
            }
            SelectListView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                switch (topBarSelected)
                {
                    case enumTopBar.books:
                        BooklistNewBook booklistNewBook = new BooklistNewBook(entitiesRecords.Authors, entitiesRecords.Books[listViewBooks.SelectedIndices[0]]);
                        booklistNewBook.Text = "Booklist Edit Book";
                        booklistNewBook.ShowDialog();
                        if (booklistNewBook.CreatedBook != null)
                        {
                            entitiesRecords.Books[listViewBooks.SelectedIndices[0]] = booklistNewBook.CreatedBook;
                        }
                        break;
                    case enumTopBar.authors:
                        BooklistNewAuthor booklistNewAuthor = new BooklistNewAuthor(entitiesRecords.Authors[listViewAuthors.SelectedIndices[0]]);
                        booklistNewAuthor.Text = "Booklist Edit Author";
                        booklistNewAuthor.ShowDialog();
                        if (booklistNewAuthor.CreatedAuthor != null)
                        {
                            entitiesRecords.Authors[listViewAuthors.SelectedIndices[0]] = booklistNewAuthor.CreatedAuthor;
                        }
                        break;
                }
                SelectListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again!");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                switch (topBarSelected)
                {
                    case enumTopBar.myCollection:
                        Book removedBookUser = selectedUser.BooksRead[listViewMyCollection.SelectedIndices[0]];
                        selectedUser.RemoveBook(removedBookUser);
                        break;
                    case enumTopBar.books:
                        Book removedBook = entitiesRecords.Books[listViewBooks.SelectedIndices[0]];
                        entitiesRecords.Books.Remove(removedBook);
                        break;
                    case enumTopBar.authors:
                        Author removedAuthor = entitiesRecords.Authors[listViewAuthors.SelectedIndices[0]];
                        entitiesRecords.Authors.Remove(removedAuthor);
                        break;
                }
                SelectListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again!");
            }
        }

        private void buttonAddToMyCollection_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewBooks.SelectedItems.Count == 0)
                {
                    throw new Exception("You haven't selected a book!");
                }
                Book selectedBook = entitiesRecords.Books[listViewBooks.SelectedIndices[0]];
                foreach (Book book in selectedUser.BooksRead)
                {
                    if (book.Title == selectedBook.Title)
                    {
                        throw new Exception("The book is already in your collection!");
                    }
                }
                selectedBook.TimesRead = 1;
                selectedBook.DateRead = DateTime.Now;
                selectedUser.AddBook(selectedBook);
                SelectListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShowAuthorsWorks_Click(object sender, EventArgs e)
        {
            try
            {
                BooklistAuthorWork booklistAuthorWork = new BooklistAuthorWork(entitiesRecords.Books, entitiesRecords.Authors[listViewAuthors.SelectedIndices[0]]);
                booklistAuthorWork.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Author doesn't have any books in the database!");
            }
            
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

        private void buttonReread_Click(object sender, EventArgs e)
        {
            try
            {
                Book selectedBook = selectedUser.BooksRead[listViewMyCollection.SelectedIndices[0]];
                selectedBook.TimesRead += 1;
                selectedBook.DateRead = DateTime.Now;
                selectedUser.BooksRead[listViewMyCollection.SelectedIndices[0]] = selectedBook;
                SelectListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchedThing = textBoxSearch.Text.ToLower();
            int i = 0;
            switch (topBarSelected)
            {
                case enumTopBar.myCollection:
                    try
                    {
                        foreach (Book book in selectedUser.BooksRead)
                        {
                            if (book.Title.ToLower().Substring(0, searchedThing.Count()).Equals(searchedThing))
                            {
                                break;
                            }
                            i++;
                        }
                        listViewMyCollection.Items[i].Selected = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Search failed! You can only search with book titles!");
                    }
                    break;
                case enumTopBar.books:
                    try
                    {
                        foreach (Book book in entitiesRecords.Books)
                        {
                            if (book.Title.ToLower().Substring(0, searchedThing.Count()).Equals(searchedThing))
                            {
                                break;
                            }
                            i++;
                        }
                        listViewBooks.Items[i].Selected = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Search failed! You can only search with book titles!");
                    }
                    break;
                case enumTopBar.authors:
                    try
                    {
                        foreach (Author author in entitiesRecords.Authors)
                        {
                            if (author.Name.ToLower().Substring(0, searchedThing.Count()).Equals(searchedThing) || author.Surname.ToLower().Substring(0, searchedThing.Count()).Equals(searchedThing) || author.FullName.ToLower().Substring(0, searchedThing.Count()).Equals(searchedThing))
                            {
                                break;
                            }
                            i++;
                        }
                        listViewAuthors.Items[i].Selected = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Search failed! You can only search with the author!");
                    }
                    break;
            }

        }

        private void LoadEntities()
        {
            try
            {
                FileSerializerDeserializer<Author> fileSerializerDeserializerAuthors = new FileSerializerDeserializer<Author>(entitiesRecords, "authorEntityData.author");
                fileSerializerDeserializerAuthors.Load();
            }
            catch (Exception) { Console.WriteLine("Loading Author Unable");}
            
            try 
            {
                FileSerializerDeserializer<Book> fileSerializerDeserializerBooks = new FileSerializerDeserializer<Book>(entitiesRecords, "bookEntityData.book");
                fileSerializerDeserializerBooks.Load();
            } catch (Exception) { Console.WriteLine("Loading Book Unable");}

            try
            {
                FileSerializerDeserializer<UserEntity> fileSerializerDeserializerUsers = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
                fileSerializerDeserializerUsers.Load();
            }
            catch (Exception) { Console.WriteLine("Loading UserEntity Unable");}
        }
        private void SaveEntities()
        {
            FileSerializerDeserializer<Author> fileSerializerDeserializerAuthors = new FileSerializerDeserializer<Author>(entitiesRecords, "authorEntityData.author");
            fileSerializerDeserializerAuthors.Save();
            FileSerializerDeserializer<Book> fileSerializerDeserializerBooks = new FileSerializerDeserializer<Book>(entitiesRecords, "bookEntityData.book");
            fileSerializerDeserializerBooks.Save();
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializerUsers = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
            fileSerializerDeserializerUsers.Save();
        }
    }
}
