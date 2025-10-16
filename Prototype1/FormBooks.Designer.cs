namespace Prototype1
{
    partial class FormBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBooksSettings = new System.Windows.Forms.Button();
            this.buttonBooksLogOut = new System.Windows.Forms.Button();
            this.buttonBooksUsers = new System.Windows.Forms.Button();
            this.buttonBooksBooks = new System.Windows.Forms.Button();
            this.buttonBooksBookings = new System.Windows.Forms.Button();
            this.buttonBooksDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBooksBorrow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBooksBorrowUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBooksBorrowBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBooksReturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBooksReturnUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBooksReturnBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonBooksAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBooksAddAuthor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBooksAddTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonBooksUpdate = new System.Windows.Forms.Button();
            this.textBoxBooksUpdateBookID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBooksUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBooksUpdateTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonBooksDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBooksDeleteBookID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.buttonBooksSettings);
            this.panel1.Controls.Add(this.buttonBooksLogOut);
            this.panel1.Controls.Add(this.buttonBooksUsers);
            this.panel1.Controls.Add(this.buttonBooksBooks);
            this.panel1.Controls.Add(this.buttonBooksBookings);
            this.panel1.Controls.Add(this.buttonBooksDashboard);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 57);
            this.panel1.TabIndex = 8;
            // 
            // buttonBooksSettings
            // 
            this.buttonBooksSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksSettings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksSettings.ForeColor = System.Drawing.Color.White;
            this.buttonBooksSettings.Location = new System.Drawing.Point(501, 12);
            this.buttonBooksSettings.Name = "buttonBooksSettings";
            this.buttonBooksSettings.Size = new System.Drawing.Size(113, 37);
            this.buttonBooksSettings.TabIndex = 9;
            this.buttonBooksSettings.Text = "⚙️Settings";
            this.buttonBooksSettings.UseVisualStyleBackColor = false;
            this.buttonBooksSettings.Click += new System.EventHandler(this.buttonBooksSettings_Click);
            // 
            // buttonBooksLogOut
            // 
            this.buttonBooksLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonBooksLogOut.Location = new System.Drawing.Point(949, 12);
            this.buttonBooksLogOut.Name = "buttonBooksLogOut";
            this.buttonBooksLogOut.Size = new System.Drawing.Size(95, 37);
            this.buttonBooksLogOut.TabIndex = 10;
            this.buttonBooksLogOut.Text = "Log Out";
            this.buttonBooksLogOut.UseVisualStyleBackColor = false;
            this.buttonBooksLogOut.Click += new System.EventHandler(this.buttonBooksLogOut_Click);
            // 
            // buttonBooksUsers
            // 
            this.buttonBooksUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksUsers.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksUsers.ForeColor = System.Drawing.Color.White;
            this.buttonBooksUsers.Location = new System.Drawing.Point(396, 12);
            this.buttonBooksUsers.Name = "buttonBooksUsers";
            this.buttonBooksUsers.Size = new System.Drawing.Size(101, 37);
            this.buttonBooksUsers.TabIndex = 9;
            this.buttonBooksUsers.Text = "👤Users";
            this.buttonBooksUsers.UseVisualStyleBackColor = false;
            this.buttonBooksUsers.Click += new System.EventHandler(this.buttonBooksUsers_Click);
            // 
            // buttonBooksBooks
            // 
            this.buttonBooksBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksBooks.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksBooks.ForeColor = System.Drawing.Color.White;
            this.buttonBooksBooks.Location = new System.Drawing.Point(289, 12);
            this.buttonBooksBooks.Name = "buttonBooksBooks";
            this.buttonBooksBooks.Size = new System.Drawing.Size(101, 37);
            this.buttonBooksBooks.TabIndex = 8;
            this.buttonBooksBooks.Text = "🕮 Books";
            this.buttonBooksBooks.UseVisualStyleBackColor = false;
            this.buttonBooksBooks.Click += new System.EventHandler(this.buttonBooksBooks_Click);
            // 
            // buttonBooksBookings
            // 
            this.buttonBooksBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksBookings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksBookings.ForeColor = System.Drawing.Color.White;
            this.buttonBooksBookings.Location = new System.Drawing.Point(161, 12);
            this.buttonBooksBookings.Name = "buttonBooksBookings";
            this.buttonBooksBookings.Size = new System.Drawing.Size(123, 37);
            this.buttonBooksBookings.TabIndex = 7;
            this.buttonBooksBookings.Text = "🕒Bookings";
            this.buttonBooksBookings.UseVisualStyleBackColor = false;
            this.buttonBooksBookings.Click += new System.EventHandler(this.buttonBooksBookings_Click);
            // 
            // buttonBooksDashboard
            // 
            this.buttonBooksDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonBooksDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonBooksDashboard.Location = new System.Drawing.Point(12, 12);
            this.buttonBooksDashboard.Name = "buttonBooksDashboard";
            this.buttonBooksDashboard.Size = new System.Drawing.Size(144, 37);
            this.buttonBooksDashboard.TabIndex = 0;
            this.buttonBooksDashboard.Text = "🏠︎Dashboard";
            this.buttonBooksDashboard.UseVisualStyleBackColor = false;
            this.buttonBooksDashboard.Click += new System.EventHandler(this.buttonBooksDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.dataGridViewBooks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(527, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 479);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(7, 34);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 62;
            this.dataGridViewBooks.RowTemplate.Height = 28;
            this.dataGridViewBooks.Size = new System.Drawing.Size(501, 435);
            this.dataGridViewBooks.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Viewer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.buttonBooksBorrow);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxBooksBorrowUserID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxBooksBorrowBookID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(11, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 144);
            this.panel3.TabIndex = 12;
            // 
            // buttonBooksBorrow
            // 
            this.buttonBooksBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonBooksBorrow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksBorrow.ForeColor = System.Drawing.Color.Black;
            this.buttonBooksBorrow.Location = new System.Drawing.Point(180, 106);
            this.buttonBooksBorrow.Name = "buttonBooksBorrow";
            this.buttonBooksBorrow.Size = new System.Drawing.Size(65, 28);
            this.buttonBooksBorrow.TabIndex = 18;
            this.buttonBooksBorrow.Text = "Enter";
            this.buttonBooksBorrow.UseVisualStyleBackColor = false;
            this.buttonBooksBorrow.Click += new System.EventHandler(this.buttonBooksBorrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "BookID";
            // 
            // textBoxBooksBorrowUserID
            // 
            this.textBoxBooksBorrowUserID.Location = new System.Drawing.Point(8, 114);
            this.textBoxBooksBorrowUserID.Name = "textBoxBooksBorrowUserID";
            this.textBoxBooksBorrowUserID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksBorrowUserID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "UserID";
            // 
            // textBoxBooksBorrowBookID
            // 
            this.textBoxBooksBorrowBookID.Location = new System.Drawing.Point(7, 65);
            this.textBoxBooksBorrowBookID.Name = "textBoxBooksBorrowBookID";
            this.textBoxBooksBorrowBookID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksBorrowBookID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrow/Extend Book";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel4.Controls.Add(this.buttonBooksReturn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxBooksReturnUserID);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxBooksReturnBookID);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(263, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 144);
            this.panel4.TabIndex = 13;
            // 
            // buttonBooksReturn
            // 
            this.buttonBooksReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonBooksReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksReturn.ForeColor = System.Drawing.Color.Black;
            this.buttonBooksReturn.Location = new System.Drawing.Point(192, 106);
            this.buttonBooksReturn.Name = "buttonBooksReturn";
            this.buttonBooksReturn.Size = new System.Drawing.Size(65, 28);
            this.buttonBooksReturn.TabIndex = 18;
            this.buttonBooksReturn.Text = "Enter";
            this.buttonBooksReturn.UseVisualStyleBackColor = false;
            this.buttonBooksReturn.Click += new System.EventHandler(this.buttonBooksReturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "BookID";
            // 
            // textBoxBooksReturnUserID
            // 
            this.textBoxBooksReturnUserID.Location = new System.Drawing.Point(7, 114);
            this.textBoxBooksReturnUserID.Name = "textBoxBooksReturnUserID";
            this.textBoxBooksReturnUserID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksReturnUserID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "UserID";
            // 
            // textBoxBooksReturnBookID
            // 
            this.textBoxBooksReturnBookID.Location = new System.Drawing.Point(7, 65);
            this.textBoxBooksReturnBookID.Name = "textBoxBooksReturnBookID";
            this.textBoxBooksReturnBookID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksReturnBookID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Return Book";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel5.Controls.Add(this.buttonBooksAdd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBoxBooksAddAuthor);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.textBoxBooksAddTitle);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(12, 210);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 93);
            this.panel5.TabIndex = 14;
            // 
            // buttonBooksAdd
            // 
            this.buttonBooksAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonBooksAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonBooksAdd.Location = new System.Drawing.Point(443, 59);
            this.buttonBooksAdd.Name = "buttonBooksAdd";
            this.buttonBooksAdd.Size = new System.Drawing.Size(65, 28);
            this.buttonBooksAdd.TabIndex = 18;
            this.buttonBooksAdd.Text = "Enter";
            this.buttonBooksAdd.UseVisualStyleBackColor = false;
            this.buttonBooksAdd.Click += new System.EventHandler(this.buttonBooksAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Title";
            // 
            // textBoxBooksAddAuthor
            // 
            this.textBoxBooksAddAuthor.Location = new System.Drawing.Point(112, 65);
            this.textBoxBooksAddAuthor.Name = "textBoxBooksAddAuthor";
            this.textBoxBooksAddAuthor.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksAddAuthor.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(108, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Author";
            // 
            // textBoxBooksAddTitle
            // 
            this.textBoxBooksAddTitle.Location = new System.Drawing.Point(7, 65);
            this.textBoxBooksAddTitle.Name = "textBoxBooksAddTitle";
            this.textBoxBooksAddTitle.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksAddTitle.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Add Book";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.buttonBooksUpdate);
            this.panel6.Controls.Add(this.textBoxBooksUpdateBookID);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.textBoxBooksUpdateAuthor);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.textBoxBooksUpdateTitle);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(12, 307);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(511, 93);
            this.panel6.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(213, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "BookID";
            // 
            // buttonBooksUpdate
            // 
            this.buttonBooksUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonBooksUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonBooksUpdate.Location = new System.Drawing.Point(443, 59);
            this.buttonBooksUpdate.Name = "buttonBooksUpdate";
            this.buttonBooksUpdate.Size = new System.Drawing.Size(65, 28);
            this.buttonBooksUpdate.TabIndex = 18;
            this.buttonBooksUpdate.Text = "Enter";
            this.buttonBooksUpdate.UseVisualStyleBackColor = false;
            this.buttonBooksUpdate.Click += new System.EventHandler(this.buttonBooksUpdate_Click);
            // 
            // textBoxBooksUpdateBookID
            // 
            this.textBoxBooksUpdateBookID.Location = new System.Drawing.Point(217, 65);
            this.textBoxBooksUpdateBookID.Name = "textBoxBooksUpdateBookID";
            this.textBoxBooksUpdateBookID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksUpdateBookID.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Title";
            // 
            // textBoxBooksUpdateAuthor
            // 
            this.textBoxBooksUpdateAuthor.Location = new System.Drawing.Point(112, 65);
            this.textBoxBooksUpdateAuthor.Name = "textBoxBooksUpdateAuthor";
            this.textBoxBooksUpdateAuthor.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksUpdateAuthor.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(108, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Author";
            // 
            // textBoxBooksUpdateTitle
            // 
            this.textBoxBooksUpdateTitle.Location = new System.Drawing.Point(7, 65);
            this.textBoxBooksUpdateTitle.Name = "textBoxBooksUpdateTitle";
            this.textBoxBooksUpdateTitle.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksUpdateTitle.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Update Book";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel7.Controls.Add(this.buttonBooksDelete);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.textBoxBooksDeleteBookID);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(12, 404);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(511, 93);
            this.panel7.TabIndex = 16;
            // 
            // buttonBooksDelete
            // 
            this.buttonBooksDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonBooksDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooksDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonBooksDelete.Location = new System.Drawing.Point(443, 59);
            this.buttonBooksDelete.Name = "buttonBooksDelete";
            this.buttonBooksDelete.Size = new System.Drawing.Size(65, 28);
            this.buttonBooksDelete.TabIndex = 18;
            this.buttonBooksDelete.Text = "Enter";
            this.buttonBooksDelete.UseVisualStyleBackColor = false;
            this.buttonBooksDelete.Click += new System.EventHandler(this.buttonBooksDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "BookID";
            // 
            // textBoxBooksDeleteBookID
            // 
            this.textBoxBooksDeleteBookID.Location = new System.Drawing.Point(7, 65);
            this.textBoxBooksDeleteBookID.Name = "textBoxBooksDeleteBookID";
            this.textBoxBooksDeleteBookID.Size = new System.Drawing.Size(99, 20);
            this.textBoxBooksDeleteBookID.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 27);
            this.label16.TabIndex = 3;
            this.label16.Text = "Delete Book";
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 549);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBooks";
            this.Text = "Library Manager Books";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBooksSettings;
        private System.Windows.Forms.Button buttonBooksLogOut;
        private System.Windows.Forms.Button buttonBooksUsers;
        private System.Windows.Forms.Button buttonBooksBooks;
        private System.Windows.Forms.Button buttonBooksBookings;
        private System.Windows.Forms.Button buttonBooksDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBooksBorrowUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBooksBorrowBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBooksReturnUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBooksReturnBookID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBooksAddAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBooksAddTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBooksBorrow;
        private System.Windows.Forms.Button buttonBooksReturn;
        private System.Windows.Forms.Button buttonBooksAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonBooksUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBooksUpdateAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBooksUpdateTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonBooksDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBooksDeleteBookID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxBooksUpdateBookID;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
    }
}