namespace SemestralkaMaybe
{
    partial class BooklistNewAuthor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxBornIn = new TextBox();
            textBoxDiedIn = new TextBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Born in";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Died in";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(90, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(143, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(90, 41);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(143, 23);
            textBoxSurname.TabIndex = 5;
            // 
            // textBoxBornIn
            // 
            textBoxBornIn.Location = new Point(90, 70);
            textBoxBornIn.Name = "textBoxBornIn";
            textBoxBornIn.Size = new Size(143, 23);
            textBoxBornIn.TabIndex = 6;
            // 
            // textBoxDiedIn
            // 
            textBoxDiedIn.Location = new Point(90, 99);
            textBoxDiedIn.Name = "textBoxDiedIn";
            textBoxDiedIn.PlaceholderText = "Optional";
            textBoxDiedIn.Size = new Size(143, 23);
            textBoxDiedIn.TabIndex = 7;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(133, 138);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 138);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BooklistNewAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 173);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxDiedIn);
            Controls.Add(textBoxBornIn);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BooklistNewAuthor";
            Text = "BooklistNewAuthor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxBornIn;
        private TextBox textBoxDiedIn;
        private Button buttonOk;
        private Button buttonCancel;
    }
}