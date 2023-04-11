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
            this.listViewMain = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonMyCollection = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonTopUsers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMain
            // 
            this.listViewMain.Location = new System.Drawing.Point(14, 53);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(779, 666);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(799, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(799, 193);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(189, 29);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(799, 228);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(189, 29);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Location = new System.Drawing.Point(799, 16);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(71, 20);
            this.labelUserInfo.TabIndex = 4;
            this.labelUserInfo.Text = "User Info:";
            // 
            // buttonMyCollection
            // 
            this.buttonMyCollection.Location = new System.Drawing.Point(12, 12);
            this.buttonMyCollection.Name = "buttonMyCollection";
            this.buttonMyCollection.Size = new System.Drawing.Size(120, 29);
            this.buttonMyCollection.TabIndex = 5;
            this.buttonMyCollection.Text = "My Collection";
            this.buttonMyCollection.UseVisualStyleBackColor = true;
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(138, 12);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(120, 29);
            this.buttonBooks.TabIndex = 6;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(264, 12);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(120, 29);
            this.buttonAuthors.TabIndex = 7;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonTopUsers
            // 
            this.buttonTopUsers.Location = new System.Drawing.Point(390, 12);
            this.buttonTopUsers.Name = "buttonTopUsers";
            this.buttonTopUsers.Size = new System.Drawing.Size(120, 29);
            this.buttonTopUsers.TabIndex = 8;
            this.buttonTopUsers.Text = "Top Users";
            this.buttonTopUsers.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(673, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 29);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // BooklistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 736);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTopUsers);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonMyCollection);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BooklistMain";
            this.Text = "BookList Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewMain;
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
    }
}