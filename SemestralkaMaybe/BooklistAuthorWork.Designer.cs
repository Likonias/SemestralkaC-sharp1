namespace SemestralkaMaybe
{
    partial class BooklistAuthorWork
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
            buttonOk = new Button();
            listViewWorks = new ListView();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(362, 415);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // listViewWorks
            // 
            listViewWorks.Location = new Point(12, 12);
            listViewWorks.Name = "listViewWorks";
            listViewWorks.Size = new Size(776, 397);
            listViewWorks.TabIndex = 1;
            listViewWorks.UseCompatibleStateImageBehavior = false;
            // 
            // BooklistAuthorWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewWorks);
            Controls.Add(buttonOk);
            Name = "BooklistAuthorWork";
            Text = "BooklistAuthorWork";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private ListView listViewWorks;
    }
}