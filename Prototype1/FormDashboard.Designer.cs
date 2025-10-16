namespace Prototype1
{
    partial class FormDashboard
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
            this.buttonDashboardDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDashboardSettings = new System.Windows.Forms.Button();
            this.buttonDashboardLogOut = new System.Windows.Forms.Button();
            this.buttonDashboardUsers = new System.Windows.Forms.Button();
            this.buttonDashboardBooks = new System.Windows.Forms.Button();
            this.buttonDashboardBookings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new Prototype1.DatabaseDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewUpcomingDeadlines = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Prototype1.DatabaseDataSet1();
            this.databaseDataSet = new Prototype1.DatabaseDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Prototype1.DatabaseDataSetTableAdapters.BooksTableAdapter();
            this.booksTableAdapter1 = new Prototype1.DatabaseDataSet1TableAdapters.BooksTableAdapter();
            this.bookingsTableAdapter = new Prototype1.DatabaseDataSet2TableAdapters.BookingsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingDeadlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDashboardDashboard
            // 
            this.buttonDashboardDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardDashboard.Location = new System.Drawing.Point(12, 12);
            this.buttonDashboardDashboard.Name = "buttonDashboardDashboard";
            this.buttonDashboardDashboard.Size = new System.Drawing.Size(144, 37);
            this.buttonDashboardDashboard.TabIndex = 0;
            this.buttonDashboardDashboard.Text = "🏠︎Dashboard";
            this.buttonDashboardDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboardDashboard.Click += new System.EventHandler(this.buttonDashboardDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.buttonDashboardSettings);
            this.panel1.Controls.Add(this.buttonDashboardLogOut);
            this.panel1.Controls.Add(this.buttonDashboardUsers);
            this.panel1.Controls.Add(this.buttonDashboardBooks);
            this.panel1.Controls.Add(this.buttonDashboardBookings);
            this.panel1.Controls.Add(this.buttonDashboardDashboard);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 57);
            this.panel1.TabIndex = 6;
            // 
            // buttonDashboardSettings
            // 
            this.buttonDashboardSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardSettings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardSettings.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardSettings.Location = new System.Drawing.Point(501, 12);
            this.buttonDashboardSettings.Name = "buttonDashboardSettings";
            this.buttonDashboardSettings.Size = new System.Drawing.Size(113, 37);
            this.buttonDashboardSettings.TabIndex = 9;
            this.buttonDashboardSettings.Text = "⚙️Settings";
            this.buttonDashboardSettings.UseVisualStyleBackColor = false;
            this.buttonDashboardSettings.Visible = false;
            this.buttonDashboardSettings.Click += new System.EventHandler(this.buttonDashboardSettings_Click);
            // 
            // buttonDashboardLogOut
            // 
            this.buttonDashboardLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardLogOut.Location = new System.Drawing.Point(949, 12);
            this.buttonDashboardLogOut.Name = "buttonDashboardLogOut";
            this.buttonDashboardLogOut.Size = new System.Drawing.Size(95, 37);
            this.buttonDashboardLogOut.TabIndex = 10;
            this.buttonDashboardLogOut.Text = "Log Out";
            this.buttonDashboardLogOut.UseVisualStyleBackColor = false;
            this.buttonDashboardLogOut.Click += new System.EventHandler(this.buttonDashboardLogOut_Click);
            // 
            // buttonDashboardUsers
            // 
            this.buttonDashboardUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardUsers.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardUsers.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardUsers.Location = new System.Drawing.Point(396, 12);
            this.buttonDashboardUsers.Name = "buttonDashboardUsers";
            this.buttonDashboardUsers.Size = new System.Drawing.Size(100, 37);
            this.buttonDashboardUsers.TabIndex = 9;
            this.buttonDashboardUsers.Text = "👤Users";
            this.buttonDashboardUsers.UseVisualStyleBackColor = false;
            this.buttonDashboardUsers.Click += new System.EventHandler(this.buttonDashboardUsers_Click);
            // 
            // buttonDashboardBooks
            // 
            this.buttonDashboardBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardBooks.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardBooks.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardBooks.Location = new System.Drawing.Point(289, 12);
            this.buttonDashboardBooks.Name = "buttonDashboardBooks";
            this.buttonDashboardBooks.Size = new System.Drawing.Size(101, 37);
            this.buttonDashboardBooks.TabIndex = 8;
            this.buttonDashboardBooks.Text = "🕮 Books";
            this.buttonDashboardBooks.UseVisualStyleBackColor = false;
            this.buttonDashboardBooks.Click += new System.EventHandler(this.buttonDashboardBooks_Click);
            // 
            // buttonDashboardBookings
            // 
            this.buttonDashboardBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonDashboardBookings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardBookings.ForeColor = System.Drawing.Color.White;
            this.buttonDashboardBookings.Location = new System.Drawing.Point(161, 12);
            this.buttonDashboardBookings.Name = "buttonDashboardBookings";
            this.buttonDashboardBookings.Size = new System.Drawing.Size(123, 37);
            this.buttonDashboardBookings.TabIndex = 7;
            this.buttonDashboardBookings.Text = "🕒Bookings";
            this.buttonDashboardBookings.UseVisualStyleBackColor = false;
            this.buttonDashboardBookings.Click += new System.EventHandler(this.buttonDashboardBookings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.dataGridViewUpcomingEvents);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 479);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewUpcomingEvents
            // 
            this.dataGridViewUpcomingEvents.AllowUserToAddRows = false;
            this.dataGridViewUpcomingEvents.AllowUserToDeleteRows = false;
            this.dataGridViewUpcomingEvents.AllowUserToOrderColumns = true;
            this.dataGridViewUpcomingEvents.AutoGenerateColumns = false;
            this.dataGridViewUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomDataGridViewTextBoxColumn,
            this.eventDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridViewUpcomingEvents.DataSource = this.bookingsBindingSource;
            this.dataGridViewUpcomingEvents.Location = new System.Drawing.Point(7, 34);
            this.dataGridViewUpcomingEvents.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUpcomingEvents.Name = "dataGridViewUpcomingEvents";
            this.dataGridViewUpcomingEvents.ReadOnly = true;
            this.dataGridViewUpcomingEvents.RowHeadersWidth = 62;
            this.dataGridViewUpcomingEvents.RowTemplate.Height = 28;
            this.dataGridViewUpcomingEvents.Size = new System.Drawing.Size(501, 435);
            this.dataGridViewUpcomingEvents.TabIndex = 11;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "room";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventDataGridViewTextBoxColumn
            // 
            this.eventDataGridViewTextBoxColumn.DataPropertyName = "event";
            this.eventDataGridViewTextBoxColumn.HeaderText = "event";
            this.eventDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            this.eventDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upcoming Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Upcoming Deadlines";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.dataGridViewUpcomingDeadlines);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(530, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 479);
            this.panel3.TabIndex = 10;
            // 
            // dataGridViewUpcomingDeadlines
            // 
            this.dataGridViewUpcomingDeadlines.AllowUserToAddRows = false;
            this.dataGridViewUpcomingDeadlines.AllowUserToDeleteRows = false;
            this.dataGridViewUpcomingDeadlines.AllowUserToOrderColumns = true;
            this.dataGridViewUpcomingDeadlines.AutoGenerateColumns = false;
            this.dataGridViewUpcomingDeadlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingDeadlines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.dataGridViewUpcomingDeadlines.DataSource = this.booksBindingSource1;
            this.dataGridViewUpcomingDeadlines.Location = new System.Drawing.Point(7, 34);
            this.dataGridViewUpcomingDeadlines.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUpcomingDeadlines.Name = "dataGridViewUpcomingDeadlines";
            this.dataGridViewUpcomingDeadlines.ReadOnly = true;
            this.dataGridViewUpcomingDeadlines.RowHeadersWidth = 62;
            this.dataGridViewUpcomingDeadlines.RowTemplate.Height = 28;
            this.dataGridViewUpcomingDeadlines.Size = new System.Drawing.Size(501, 435);
            this.dataGridViewUpcomingDeadlines.TabIndex = 12;
            this.dataGridViewUpcomingDeadlines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpcomingDeadlines_CellContentClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "return_date";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "return_date";
            this.returndateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            this.returndateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returndateDataGridViewTextBoxColumn.Width = 150;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 150;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.databaseDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashboard";
            this.Text = "Library Manager Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingDeadlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDashboardDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDashboardBookings;
        private System.Windows.Forms.Button buttonDashboardSettings;
        private System.Windows.Forms.Button buttonDashboardLogOut;
        private System.Windows.Forms.Button buttonDashboardUsers;
        private System.Windows.Forms.Button buttonDashboardBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingDeadlines;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DatabaseDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private DatabaseDataSet1TableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DatabaseDataSet2TableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
    }
}