namespace SemestralkaMaybe
{
    partial class BooklistLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            buttonExit = new Button();
            buttonLogin = new Button();
            buttonNewUser = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 124);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(110, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(142, 124);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(110, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonNewUser
            // 
            buttonNewUser.Location = new Point(12, 87);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(240, 23);
            buttonNewUser.TabIndex = 4;
            buttonNewUser.Text = "Create New User";
            buttonNewUser.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(81, 6);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(171, 23);
            textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(81, 34);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(171, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Are you a new user?";
            // 
            // BooklistLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 159);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonNewUser);
            Controls.Add(buttonLogin);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BooklistLogin";
            Text = "BookList Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonExit;
        private Button buttonLogin;
        private Button buttonNewUser;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
    }
}