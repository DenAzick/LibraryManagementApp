namespace LibraryManagementApp.Forms
{
    partial class Users
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
            buttonAddUser = new Button();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            textBoxPassport = new TextBox();
            textBoxPhoneNumber = new TextBox();
            dataGridViewUsers = new DataGridView();
            buttonSearchPassport = new Button();
            textBoxSearchPassport = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(183, 128);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(75, 23);
            buttonAddUser.TabIndex = 0;
            buttonAddUser.Text = "Add user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(12, 12);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(246, 23);
            textBoxFName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(12, 41);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(246, 23);
            textBoxLName.TabIndex = 2;
            // 
            // textBoxPassport
            // 
            textBoxPassport.Location = new Point(12, 70);
            textBoxPassport.Name = "textBoxPassport";
            textBoxPassport.Size = new Size(246, 23);
            textBoxPassport.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(12, 99);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(246, 23);
            textBoxPhoneNumber.TabIndex = 4;
            textBoxPhoneNumber.Text = "+998 ";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(264, 12);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(732, 705);
            dataGridViewUsers.TabIndex = 5;
            // 
            // buttonSearchPassport
            // 
            buttonSearchPassport.Location = new Point(238, 694);
            buttonSearchPassport.Name = "buttonSearchPassport";
            buttonSearchPassport.Size = new Size(20, 23);
            buttonSearchPassport.TabIndex = 7;
            buttonSearchPassport.Text = "🔍 ";
            buttonSearchPassport.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPassport
            // 
            textBoxSearchPassport.Location = new Point(12, 694);
            textBoxSearchPassport.Name = "textBoxSearchPassport";
            textBoxSearchPassport.Size = new Size(220, 23);
            textBoxSearchPassport.TabIndex = 6;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(buttonSearchPassport);
            Controls.Add(textBoxSearchPassport);
            Controls.Add(dataGridViewUsers);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxPassport);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(buttonAddUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddUser;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private TextBox textBoxPassport;
        private TextBox textBoxPhoneNumber;
        private DataGridView dataGridViewUsers;
        private Button buttonSearchPassport;
        private TextBox textBoxSearchPassport;
    }
}