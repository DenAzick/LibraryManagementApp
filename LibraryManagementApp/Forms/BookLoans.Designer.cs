namespace LibraryManagementApp.Forms
{
    partial class BookLoans
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
            buttonSearch = new Button();
            comboBoxAccaunt = new ComboBox();
            comboBoxBook = new ComboBox();
            buttonReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 705);
            dataGridView1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(212, 70);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "search 🔍 ";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxAccaunt
            // 
            comboBoxAccaunt.FormattingEnabled = true;
            comboBoxAccaunt.Location = new Point(12, 12);
            comboBoxAccaunt.Name = "comboBoxAccaunt";
            comboBoxAccaunt.Size = new Size(275, 23);
            comboBoxAccaunt.TabIndex = 4;
            // 
            // comboBoxBook
            // 
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(12, 41);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(275, 23);
            comboBoxBook.TabIndex = 5;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(212, 99);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(75, 23);
            buttonReturn.TabIndex = 6;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // BookLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(buttonReturn);
            Controls.Add(comboBoxBook);
            Controls.Add(comboBoxAccaunt);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "BookLoans";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSearch;
        private ComboBox comboBoxAccaunt;
        private ComboBox comboBoxBook;
        private Button buttonReturn;
    }
}