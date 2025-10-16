namespace Prototype1
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUsersSettings = new System.Windows.Forms.Button();
            this.buttonUsersLogOut = new System.Windows.Forms.Button();
            this.buttonUsersUsers = new System.Windows.Forms.Button();
            this.buttonUsersBooks = new System.Windows.Forms.Button();
            this.buttonUsersBookings = new System.Windows.Forms.Button();
            this.buttonUsersDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new Prototype1.DatabaseDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonUsersDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUsersDeleteUserID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsersUpdateUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsersUpdatePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsersUpdateAddress = new System.Windows.Forms.TextBox();
            this.buttonUsersUpdate = new System.Windows.Forms.Button();
            this.textBoxUsersUpdateSurname = new System.Windows.Forms.TextBox();
            this.textBoxUsersUpdateForename = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsersAddPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsersAddAddress = new System.Windows.Forms.TextBox();
            this.buttonUsersAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsersAddSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUsersAddForename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.databaseDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet4 = new Prototype1.DatabaseDataSet4();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Prototype1.DatabaseDataSet4TableAdapters.StaffTableAdapter();
            this.databaseDataSet5 = new Prototype1.DatabaseDataSet5();
            this.databaseDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Prototype1.DatabaseDataSet3TableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.buttonUsersSettings);
            this.panel1.Controls.Add(this.buttonUsersLogOut);
            this.panel1.Controls.Add(this.buttonUsersUsers);
            this.panel1.Controls.Add(this.buttonUsersBooks);
            this.panel1.Controls.Add(this.buttonUsersBookings);
            this.panel1.Controls.Add(this.buttonUsersDashboard);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 57);
            this.panel1.TabIndex = 8;
            // 
            // buttonUsersSettings
            // 
            this.buttonUsersSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersSettings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersSettings.ForeColor = System.Drawing.Color.White;
            this.buttonUsersSettings.Location = new System.Drawing.Point(501, 12);
            this.buttonUsersSettings.Name = "buttonUsersSettings";
            this.buttonUsersSettings.Size = new System.Drawing.Size(113, 37);
            this.buttonUsersSettings.TabIndex = 9;
            this.buttonUsersSettings.Text = "⚙️Settings";
            this.buttonUsersSettings.UseVisualStyleBackColor = false;
            this.buttonUsersSettings.Click += new System.EventHandler(this.buttonUsersSettings_Click);
            // 
            // buttonUsersLogOut
            // 
            this.buttonUsersLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonUsersLogOut.Location = new System.Drawing.Point(949, 12);
            this.buttonUsersLogOut.Name = "buttonUsersLogOut";
            this.buttonUsersLogOut.Size = new System.Drawing.Size(95, 37);
            this.buttonUsersLogOut.TabIndex = 10;
            this.buttonUsersLogOut.Text = "Log Out";
            this.buttonUsersLogOut.UseVisualStyleBackColor = false;
            this.buttonUsersLogOut.Click += new System.EventHandler(this.buttonUsersLogOut_Click);
            // 
            // buttonUsersUsers
            // 
            this.buttonUsersUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersUsers.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsersUsers.Location = new System.Drawing.Point(396, 12);
            this.buttonUsersUsers.Name = "buttonUsersUsers";
            this.buttonUsersUsers.Size = new System.Drawing.Size(101, 37);
            this.buttonUsersUsers.TabIndex = 9;
            this.buttonUsersUsers.Text = "👤Users";
            this.buttonUsersUsers.UseVisualStyleBackColor = false;
            this.buttonUsersUsers.Click += new System.EventHandler(this.buttonUsersUsers_Click);
            // 
            // buttonUsersBooks
            // 
            this.buttonUsersBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersBooks.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersBooks.ForeColor = System.Drawing.Color.White;
            this.buttonUsersBooks.Location = new System.Drawing.Point(289, 12);
            this.buttonUsersBooks.Name = "buttonUsersBooks";
            this.buttonUsersBooks.Size = new System.Drawing.Size(101, 37);
            this.buttonUsersBooks.TabIndex = 8;
            this.buttonUsersBooks.Text = "🕮 Books";
            this.buttonUsersBooks.UseVisualStyleBackColor = false;
            this.buttonUsersBooks.Click += new System.EventHandler(this.buttonUsersBooks_Click);
            // 
            // buttonUsersBookings
            // 
            this.buttonUsersBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersBookings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersBookings.ForeColor = System.Drawing.Color.White;
            this.buttonUsersBookings.Location = new System.Drawing.Point(161, 12);
            this.buttonUsersBookings.Name = "buttonUsersBookings";
            this.buttonUsersBookings.Size = new System.Drawing.Size(123, 37);
            this.buttonUsersBookings.TabIndex = 7;
            this.buttonUsersBookings.Text = "🕒Bookings";
            this.buttonUsersBookings.UseVisualStyleBackColor = false;
            this.buttonUsersBookings.Click += new System.EventHandler(this.buttonUsersBookings_Click);
            // 
            // buttonUsersDashboard
            // 
            this.buttonUsersDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonUsersDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonUsersDashboard.Location = new System.Drawing.Point(12, 12);
            this.buttonUsersDashboard.Name = "buttonUsersDashboard";
            this.buttonUsersDashboard.Size = new System.Drawing.Size(144, 37);
            this.buttonUsersDashboard.TabIndex = 0;
            this.buttonUsersDashboard.Text = "🏠︎Dashboard";
            this.buttonUsersDashboard.UseVisualStyleBackColor = false;
            this.buttonUsersDashboard.Click += new System.EventHandler(this.buttonUsersDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.dataGridViewUsers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(527, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 479);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.usersBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 34);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(501, 435);
            this.dataGridViewUsers.TabIndex = 11;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "fine";
            this.fineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            this.fineDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Users Viewer";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel7.Controls.Add(this.buttonUsersDelete);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.textBoxUsersDeleteUserID);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(12, 303);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(511, 93);
            this.panel7.TabIndex = 21;
            // 
            // buttonUsersDelete
            // 
            this.buttonUsersDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonUsersDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonUsersDelete.Location = new System.Drawing.Point(443, 59);
            this.buttonUsersDelete.Name = "buttonUsersDelete";
            this.buttonUsersDelete.Size = new System.Drawing.Size(65, 28);
            this.buttonUsersDelete.TabIndex = 18;
            this.buttonUsersDelete.Text = "Enter";
            this.buttonUsersDelete.UseVisualStyleBackColor = false;
            this.buttonUsersDelete.Click += new System.EventHandler(this.buttonUsersDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "UserID";
            // 
            // textBoxUsersDeleteUserID
            // 
            this.textBoxUsersDeleteUserID.Location = new System.Drawing.Point(7, 65);
            this.textBoxUsersDeleteUserID.Name = "textBoxUsersDeleteUserID";
            this.textBoxUsersDeleteUserID.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersDeleteUserID.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 27);
            this.label16.TabIndex = 3;
            this.label16.Text = "Delete User";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.textBoxUsersUpdateUserID);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.textBoxUsersUpdatePhone);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBoxUsersUpdateAddress);
            this.panel6.Controls.Add(this.buttonUsersUpdate);
            this.panel6.Controls.Add(this.textBoxUsersUpdateSurname);
            this.panel6.Controls.Add(this.textBoxUsersUpdateForename);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(11, 159);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(511, 140);
            this.panel6.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Forename";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "UserID";
            // 
            // textBoxUsersUpdateUserID
            // 
            this.textBoxUsersUpdateUserID.Location = new System.Drawing.Point(8, 114);
            this.textBoxUsersUpdateUserID.Name = "textBoxUsersUpdateUserID";
            this.textBoxUsersUpdateUserID.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersUpdateUserID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(326, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone";
            // 
            // textBoxUsersUpdatePhone
            // 
            this.textBoxUsersUpdatePhone.Location = new System.Drawing.Point(330, 65);
            this.textBoxUsersUpdatePhone.Name = "textBoxUsersUpdatePhone";
            this.textBoxUsersUpdatePhone.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersUpdatePhone.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email";
            // 
            // textBoxUsersUpdateAddress
            // 
            this.textBoxUsersUpdateAddress.Location = new System.Drawing.Point(221, 65);
            this.textBoxUsersUpdateAddress.Name = "textBoxUsersUpdateAddress";
            this.textBoxUsersUpdateAddress.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersUpdateAddress.TabIndex = 22;
            // 
            // buttonUsersUpdate
            // 
            this.buttonUsersUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonUsersUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUsersUpdate.Location = new System.Drawing.Point(443, 59);
            this.buttonUsersUpdate.Name = "buttonUsersUpdate";
            this.buttonUsersUpdate.Size = new System.Drawing.Size(65, 28);
            this.buttonUsersUpdate.TabIndex = 18;
            this.buttonUsersUpdate.Text = "Enter";
            this.buttonUsersUpdate.UseVisualStyleBackColor = false;
            this.buttonUsersUpdate.Click += new System.EventHandler(this.buttonUsersUpdate_Click);
            // 
            // textBoxUsersUpdateSurname
            // 
            this.textBoxUsersUpdateSurname.Location = new System.Drawing.Point(112, 65);
            this.textBoxUsersUpdateSurname.Name = "textBoxUsersUpdateSurname";
            this.textBoxUsersUpdateSurname.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersUpdateSurname.TabIndex = 1;
            // 
            // textBoxUsersUpdateForename
            // 
            this.textBoxUsersUpdateForename.Location = new System.Drawing.Point(7, 65);
            this.textBoxUsersUpdateForename.Name = "textBoxUsersUpdateForename";
            this.textBoxUsersUpdateForename.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersUpdateForename.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Update User";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.textBoxUsersAddPhone);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.textBoxUsersAddAddress);
            this.panel5.Controls.Add(this.buttonUsersAdd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBoxUsersAddSurname);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.textBoxUsersAddForename);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(11, 62);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 93);
            this.panel5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(326, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone";
            // 
            // textBoxUsersAddPhone
            // 
            this.textBoxUsersAddPhone.Location = new System.Drawing.Point(330, 65);
            this.textBoxUsersAddPhone.Name = "textBoxUsersAddPhone";
            this.textBoxUsersAddPhone.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersAddPhone.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email";
            // 
            // textBoxUsersAddAddress
            // 
            this.textBoxUsersAddAddress.Location = new System.Drawing.Point(221, 65);
            this.textBoxUsersAddAddress.Name = "textBoxUsersAddAddress";
            this.textBoxUsersAddAddress.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersAddAddress.TabIndex = 25;
            // 
            // buttonUsersAdd
            // 
            this.buttonUsersAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonUsersAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonUsersAdd.Location = new System.Drawing.Point(443, 59);
            this.buttonUsersAdd.Name = "buttonUsersAdd";
            this.buttonUsersAdd.Size = new System.Drawing.Size(65, 28);
            this.buttonUsersAdd.TabIndex = 18;
            this.buttonUsersAdd.Text = "Enter";
            this.buttonUsersAdd.UseVisualStyleBackColor = false;
            this.buttonUsersAdd.Click += new System.EventHandler(this.buttonUsersAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forename";
            // 
            // textBoxUsersAddSurname
            // 
            this.textBoxUsersAddSurname.Location = new System.Drawing.Point(112, 65);
            this.textBoxUsersAddSurname.Name = "textBoxUsersAddSurname";
            this.textBoxUsersAddSurname.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersAddSurname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(108, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Surname";
            // 
            // textBoxUsersAddForename
            // 
            this.textBoxUsersAddForename.Location = new System.Drawing.Point(7, 65);
            this.textBoxUsersAddForename.Name = "textBoxUsersAddForename";
            this.textBoxUsersAddForename.Size = new System.Drawing.Size(99, 20);
            this.textBoxUsersAddForename.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Add User";
            // 
            // databaseDataSet3BindingSource
            // 
            this.databaseDataSet3BindingSource.DataSource = this.databaseDataSet3;
            this.databaseDataSet3BindingSource.Position = 0;
            // 
            // databaseDataSet4
            // 
            this.databaseDataSet4.DataSetName = "DatabaseDataSet4";
            this.databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.databaseDataSet4;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet5
            // 
            this.databaseDataSet5.DataSetName = "DatabaseDataSet5";
            this.databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet5BindingSource
            // 
            this.databaseDataSet5BindingSource.DataSource = this.databaseDataSet5;
            this.databaseDataSet5BindingSource.Position = 0;
            // 
            // databaseDataSet4BindingSource
            // 
            this.databaseDataSet4BindingSource.DataSource = this.databaseDataSet4;
            this.databaseDataSet4BindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 549);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsers";
            this.Text = "Library Manager Users";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUsersSettings;
        private System.Windows.Forms.Button buttonUsersLogOut;
        private System.Windows.Forms.Button buttonUsersUsers;
        private System.Windows.Forms.Button buttonUsersBooks;
        private System.Windows.Forms.Button buttonUsersBookings;
        private System.Windows.Forms.Button buttonUsersDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonUsersDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUsersDeleteUserID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonUsersUpdate;
        private System.Windows.Forms.TextBox textBoxUsersUpdateSurname;
        private System.Windows.Forms.TextBox textBoxUsersUpdateForename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonUsersAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsersAddSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUsersAddForename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsersUpdateUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsersUpdatePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsersUpdateAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsersAddPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsersAddAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource databaseDataSet3BindingSource;
        private DatabaseDataSet3 databaseDataSet3;
        private DatabaseDataSet4 databaseDataSet4;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DatabaseDataSet4TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource databaseDataSet4BindingSource;
        private DatabaseDataSet5 databaseDataSet5;
        private System.Windows.Forms.BindingSource databaseDataSet5BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSet3TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
    }
}