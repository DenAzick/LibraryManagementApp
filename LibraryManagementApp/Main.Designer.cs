namespace LibraryManagementApp
{
    partial class Main
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
            buttonManager = new Button();
            buttonUserManager = new Button();
            buttonLoans = new Button();
            dataGridViewBooks = new DataGridView();
            textBoxName = new TextBox();
            buttonSearchName = new Button();
            buttonSearchGenre = new Button();
            textBoxGenre = new TextBox();
            buttonSearchAuthor = new Button();
            textBoxAuthor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // buttonManager
            // 
            buttonManager.Location = new Point(12, 12);
            buttonManager.Name = "buttonManager";
            buttonManager.Size = new Size(246, 44);
            buttonManager.TabIndex = 0;
            buttonManager.Text = "Book manager";
            buttonManager.UseVisualStyleBackColor = true;
            buttonManager.Click += buttonManager_Click;
            // 
            // buttonUserManager
            // 
            buttonUserManager.Location = new Point(12, 62);
            buttonUserManager.Name = "buttonUserManager";
            buttonUserManager.Size = new Size(246, 44);
            buttonUserManager.TabIndex = 1;
            buttonUserManager.Text = "User manager";
            buttonUserManager.UseVisualStyleBackColor = true;
            buttonUserManager.Click += buttonUserManager_Click;
            // 
            // buttonLoans
            // 
            buttonLoans.Location = new Point(12, 112);
            buttonLoans.Name = "buttonLoans";
            buttonLoans.Size = new Size(246, 44);
            buttonLoans.TabIndex = 2;
            buttonLoans.Text = "Loan manager";
            buttonLoans.UseVisualStyleBackColor = true;
            buttonLoans.Click += buttonLoans_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(264, 12);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(732, 705);
            dataGridViewBooks.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 193);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(220, 23);
            textBoxName.TabIndex = 4;
            // 
            // buttonSearchName
            // 
            buttonSearchName.Location = new Point(238, 193);
            buttonSearchName.Name = "buttonSearchName";
            buttonSearchName.Size = new Size(20, 23);
            buttonSearchName.TabIndex = 5;
            buttonSearchName.Text = "🔍 ";
            buttonSearchName.UseVisualStyleBackColor = true;
            buttonSearchName.Click += buttonSearchName_Click;
            // 
            // buttonSearchGenre
            // 
            buttonSearchGenre.Location = new Point(238, 222);
            buttonSearchGenre.Name = "buttonSearchGenre";
            buttonSearchGenre.Size = new Size(20, 23);
            buttonSearchGenre.TabIndex = 7;
            buttonSearchGenre.Text = "🔍 ";
            buttonSearchGenre.UseVisualStyleBackColor = true;
            buttonSearchGenre.Click += buttonSearchGenre_Click;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(12, 222);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(220, 23);
            textBoxGenre.TabIndex = 6;
            // 
            // buttonSearchAuthor
            // 
            buttonSearchAuthor.Location = new Point(238, 251);
            buttonSearchAuthor.Name = "buttonSearchAuthor";
            buttonSearchAuthor.Size = new Size(20, 23);
            buttonSearchAuthor.TabIndex = 9;
            buttonSearchAuthor.Text = "🔍 ";
            buttonSearchAuthor.UseVisualStyleBackColor = true;
            buttonSearchAuthor.Click += buttonSearchAuthor_Click;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(12, 251);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(220, 23);
            textBoxAuthor.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(buttonSearchAuthor);
            Controls.Add(textBoxAuthor);
            Controls.Add(buttonSearchGenre);
            Controls.Add(textBoxGenre);
            Controls.Add(buttonSearchName);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewBooks);
            Controls.Add(buttonLoans);
            Controls.Add(buttonUserManager);
            Controls.Add(buttonManager);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Library Management";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonManager;
        private Button buttonUserManager;
        private Button buttonLoans;
        private DataGridView dataGridViewBooks;
        private TextBox textBoxName;
        private Button buttonSearchName;
        private Button buttonSearchGenre;
        private TextBox textBoxGenre;
        private Button buttonSearchAuthor;
        private TextBox textBoxAuthor;
    }
}
