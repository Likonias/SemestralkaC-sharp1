namespace SemestralkaMaybe
{
    partial class BooklistNewBook
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
            buttonOk = new Button();
            buttonCancel = new Button();
            textBoxTitle = new TextBox();
            textBoxYearReleased = new TextBox();
            textBoxAverageReadTime = new TextBox();
            comboBoxAuthor = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Year released";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 3;
            label4.Text = "Average \r\nread time";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(132, 148);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 23);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 148);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(94, 12);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(138, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // textBoxYearReleased
            // 
            textBoxYearReleased.Location = new Point(94, 41);
            textBoxYearReleased.Name = "textBoxYearReleased";
            textBoxYearReleased.Size = new Size(138, 23);
            textBoxYearReleased.TabIndex = 9;
            // 
            // textBoxAverageReadTime
            // 
            textBoxAverageReadTime.Location = new Point(94, 99);
            textBoxAverageReadTime.Name = "textBoxAverageReadTime";
            textBoxAverageReadTime.Size = new Size(138, 23);
            textBoxAverageReadTime.TabIndex = 13;
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(94, 70);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(138, 23);
            comboBoxAuthor.TabIndex = 14;
            // 
            // BooklistNewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 183);
            Controls.Add(comboBoxAuthor);
            Controls.Add(textBoxAverageReadTime);
            Controls.Add(textBoxYearReleased);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BooklistNewBook";
            Text = "BooklistNewBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOk;
        private Button buttonCancel;
        private TextBox textBoxTitle;
        private TextBox textBoxYearReleased;
        private TextBox textBoxAverageReadTime;
        private ComboBox comboBoxAuthor;
    }
}