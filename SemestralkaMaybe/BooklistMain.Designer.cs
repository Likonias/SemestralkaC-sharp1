namespace SemestralkaMaybe
{
    partial class BooklistMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewMyCollection = new ListView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            labelUserInfo = new Label();
            buttonMyCollection = new Button();
            buttonBooks = new Button();
            buttonAuthors = new Button();
            buttonTopUsers = new Button();
            textBox1 = new TextBox();
            buttonSearch = new Button();
            listViewBooks = new ListView();
            listViewAuthors = new ListView();
            listViewTopUsers = new ListView();
            buttonExitApplication = new Button();
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // listViewMyCollection
            // 
            listViewMyCollection.Location = new Point(10, 36);
            listViewMyCollection.Name = "listViewMyCollection";
            listViewMyCollection.Size = new Size(683, 505);
            listViewMyCollection.TabIndex = 0;
            listViewMyCollection.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(698, 130);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(165, 22);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(698, 157);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(165, 22);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(698, 183);
            buttonRemove.Margin = new Padding(3, 2, 3, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(165, 22);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelUserInfo
            // 
            labelUserInfo.AutoSize = true;
            labelUserInfo.Location = new Point(698, 12);
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(57, 15);
            labelUserInfo.TabIndex = 4;
            labelUserInfo.Text = "User Info:";
            // 
            // buttonMyCollection
            // 
            buttonMyCollection.Location = new Point(10, 9);
            buttonMyCollection.Margin = new Padding(3, 2, 3, 2);
            buttonMyCollection.Name = "buttonMyCollection";
            buttonMyCollection.Size = new Size(105, 22);
            buttonMyCollection.TabIndex = 5;
            buttonMyCollection.Text = "My Collection";
            buttonMyCollection.UseVisualStyleBackColor = true;
            buttonMyCollection.Click += buttonMyCollection_Click;
            // 
            // buttonBooks
            // 
            buttonBooks.Location = new Point(121, 9);
            buttonBooks.Margin = new Padding(3, 2, 3, 2);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Size = new Size(105, 22);
            buttonBooks.TabIndex = 6;
            buttonBooks.Text = "Books";
            buttonBooks.UseVisualStyleBackColor = true;
            buttonBooks.Click += buttonBooks_Click;
            // 
            // buttonAuthors
            // 
            buttonAuthors.Location = new Point(231, 9);
            buttonAuthors.Margin = new Padding(3, 2, 3, 2);
            buttonAuthors.Name = "buttonAuthors";
            buttonAuthors.Size = new Size(105, 22);
            buttonAuthors.TabIndex = 7;
            buttonAuthors.Text = "Authors";
            buttonAuthors.UseVisualStyleBackColor = true;
            buttonAuthors.Click += buttonAuthors_Click;
            // 
            // buttonTopUsers
            // 
            buttonTopUsers.Location = new Point(341, 9);
            buttonTopUsers.Margin = new Padding(3, 2, 3, 2);
            buttonTopUsers.Name = "buttonTopUsers";
            buttonTopUsers.Size = new Size(105, 22);
            buttonTopUsers.TabIndex = 8;
            buttonTopUsers.Text = "Top Users";
            buttonTopUsers.UseVisualStyleBackColor = true;
            buttonTopUsers.Click += buttonTopUsers_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(452, 10);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(589, 9);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 22);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listViewBooks
            // 
            listViewBooks.Location = new Point(10, 36);
            listViewBooks.Margin = new Padding(3, 2, 3, 2);
            listViewBooks.Name = "listViewBooks";
            listViewBooks.Size = new Size(683, 505);
            listViewBooks.TabIndex = 12;
            listViewBooks.UseCompatibleStateImageBehavior = false;
            // 
            // listViewAuthors
            // 
            listViewAuthors.Location = new Point(10, 36);
            listViewAuthors.Margin = new Padding(3, 2, 3, 2);
            listViewAuthors.Name = "listViewAuthors";
            listViewAuthors.Size = new Size(683, 505);
            listViewAuthors.TabIndex = 13;
            listViewAuthors.UseCompatibleStateImageBehavior = false;
            // 
            // listViewTopUsers
            // 
            listViewTopUsers.Activation = ItemActivation.OneClick;
            listViewTopUsers.Location = new Point(10, 36);
            listViewTopUsers.Margin = new Padding(3, 2, 3, 2);
            listViewTopUsers.Name = "listViewTopUsers";
            listViewTopUsers.Size = new Size(683, 505);
            listViewTopUsers.TabIndex = 14;
            listViewTopUsers.UseCompatibleStateImageBehavior = false;
            // 
            // buttonExitApplication
            // 
            buttonExitApplication.Location = new Point(699, 518);
            buttonExitApplication.Margin = new Padding(3, 2, 3, 2);
            buttonExitApplication.Name = "buttonExitApplication";
            buttonExitApplication.Size = new Size(165, 22);
            buttonExitApplication.TabIndex = 15;
            buttonExitApplication.Text = "Exit Application";
            buttonExitApplication.UseVisualStyleBackColor = true;
            buttonExitApplication.Click += buttonExitApplication_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(699, 492);
            buttonLogout.Margin = new Padding(3, 2, 3, 2);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(165, 22);
            buttonLogout.TabIndex = 16;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // BooklistMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 552);
            Controls.Add(buttonLogout);
            Controls.Add(buttonExitApplication);
            Controls.Add(listViewTopUsers);
            Controls.Add(listViewAuthors);
            Controls.Add(listViewBooks);
            Controls.Add(buttonSearch);
            Controls.Add(textBox1);
            Controls.Add(buttonTopUsers);
            Controls.Add(buttonAuthors);
            Controls.Add(buttonBooks);
            Controls.Add(buttonMyCollection);
            Controls.Add(labelUserInfo);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listViewMyCollection);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BooklistMain";
            Text = "BookList Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewMyCollection;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
        private Label labelUserInfo;
        private Button buttonMyCollection;
        private Button buttonBooks;
        private Button buttonAuthors;
        private Button buttonTopUsers;
        private TextBox textBox1;
        private Button buttonSearch;
        private ListView listViewBooks;
        private ListView listViewAuthors;
        private ListView listViewTopUsers;
        private Button buttonExitApplication;
        private Button buttonLogout;
    }
}