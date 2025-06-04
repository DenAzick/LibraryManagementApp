namespace LibraryManagementApp.Forms
{
    partial class Books
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
            dataGridView1 = new DataGridView();
            buttonAddBook = new Button();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxAuthor = new TextBox();
            dateTimePickerBook = new DateTimePicker();
            comboBoxGenre = new ComboBox();
            textBoxISBN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 705);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(196, 186);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(75, 23);
            buttonAddBook.TabIndex = 1;
            buttonAddBook.Text = "add";
            buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(259, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 41);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(259, 23);
            textBoxDescription.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(12, 70);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(259, 23);
            textBoxAuthor.TabIndex = 4;
            // 
            // dateTimePickerBook
            // 
            dateTimePickerBook.Location = new Point(12, 128);
            dateTimePickerBook.Name = "dateTimePickerBook";
            dateTimePickerBook.Size = new Size(259, 23);
            dateTimePickerBook.TabIndex = 5;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(12, 157);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(259, 23);
            comboBoxGenre.TabIndex = 7;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(12, 99);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(259, 23);
            textBoxISBN.TabIndex = 8;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(textBoxISBN);
            Controls.Add(comboBoxGenre);
            Controls.Add(dateTimePickerBook);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(buttonAddBook);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Books";
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddBook;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxAuthor;
        private DateTimePicker dateTimePickerBook;
        private ComboBox comboBoxGenre;
        private TextBox textBoxISBN;
    }
}