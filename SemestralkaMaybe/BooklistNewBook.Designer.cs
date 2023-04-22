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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYearReleased = new System.Windows.Forms.TextBox();
            this.textBoxAverageReadTime = new System.Windows.Forms.TextBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year released";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average \r\nread time";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(151, 197);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(114, 31);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(14, 197);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 31);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(107, 16);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(157, 27);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxYearReleased
            // 
            this.textBoxYearReleased.Location = new System.Drawing.Point(107, 55);
            this.textBoxYearReleased.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYearReleased.Name = "textBoxYearReleased";
            this.textBoxYearReleased.Size = new System.Drawing.Size(157, 27);
            this.textBoxYearReleased.TabIndex = 9;
            // 
            // textBoxAverageReadTime
            // 
            this.textBoxAverageReadTime.Location = new System.Drawing.Point(107, 132);
            this.textBoxAverageReadTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAverageReadTime.Name = "textBoxAverageReadTime";
            this.textBoxAverageReadTime.Size = new System.Drawing.Size(157, 27);
            this.textBoxAverageReadTime.TabIndex = 13;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(107, 93);
            this.comboBoxAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(157, 28);
            this.comboBoxAuthor.TabIndex = 14;
            // 
            // BooklistNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 244);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.textBoxAverageReadTime);
            this.Controls.Add(this.textBoxYearReleased);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BooklistNewBook";
            this.Text = "BooklistNewBook";
            this.ResumeLayout(false);
            this.PerformLayout();

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