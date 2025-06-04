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
            dataGridViewLoans = new DataGridView();
            buttonSearch = new Button();
            buttonReturn = new Button();
            textBoxPassport = new TextBox();
            textBoxBook = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLoans
            // 
            dataGridViewLoans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoans.Location = new Point(293, 12);
            dataGridViewLoans.Name = "dataGridViewLoans";
            dataGridViewLoans.Size = new Size(703, 705);
            dataGridViewLoans.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(212, 70);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "search 🔍 ";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(212, 99);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(75, 23);
            buttonReturn.TabIndex = 6;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // textBoxPassport
            // 
            textBoxPassport.Location = new Point(12, 12);
            textBoxPassport.Name = "textBoxPassport";
            textBoxPassport.Size = new Size(275, 23);
            textBoxPassport.TabIndex = 7;
            // 
            // textBoxBook
            // 
            textBoxBook.Location = new Point(12, 41);
            textBoxBook.Name = "textBoxBook";
            textBoxBook.Size = new Size(275, 23);
            textBoxBook.TabIndex = 8;
            // 
            // BookLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(textBoxBook);
            Controls.Add(textBoxPassport);
            Controls.Add(buttonReturn);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridViewLoans);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "BookLoans";
            Text = " ";
            Load += BookLoans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLoans;
        private Button buttonSearch;
        private Button buttonReturn;
        private TextBox textBoxPassport;
        private TextBox textBoxBook;
    }
}