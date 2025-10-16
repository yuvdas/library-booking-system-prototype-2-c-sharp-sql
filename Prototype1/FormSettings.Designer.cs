namespace Prototype1
{
    partial class FormSettings
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.textBoxPasswordNewConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPasswordNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettingsDashboard = new System.Windows.Forms.Button();
            this.buttonSettingsBookings = new System.Windows.Forms.Button();
            this.buttonSettingsBooks = new System.Windows.Forms.Button();
            this.buttonSettingsUsers = new System.Windows.Forms.Button();
            this.buttonSettingsLogOut = new System.Windows.Forms.Button();
            this.buttonSettingsSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonUnlock);
            this.panel2.Controls.Add(this.buttonChangePassword);
            this.panel2.Controls.Add(this.textBoxPasswordNewConfirm);
            this.panel2.Controls.Add(this.textBoxPasswordNew);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 274);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unlock Librarian Account";
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonUnlock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnlock.ForeColor = System.Drawing.Color.Black;
            this.buttonUnlock.Location = new System.Drawing.Point(8, 196);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(65, 28);
            this.buttonUnlock.TabIndex = 18;
            this.buttonUnlock.Text = "Unlock";
            this.buttonUnlock.UseVisualStyleBackColor = false;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonChangePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePassword.Location = new System.Drawing.Point(157, 135);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(65, 28);
            this.buttonChangePassword.TabIndex = 17;
            this.buttonChangePassword.Text = "Enter";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // textBoxPasswordNewConfirm
            // 
            this.textBoxPasswordNewConfirm.Location = new System.Drawing.Point(4, 109);
            this.textBoxPasswordNewConfirm.Name = "textBoxPasswordNewConfirm";
            this.textBoxPasswordNewConfirm.PasswordChar = '•';
            this.textBoxPasswordNewConfirm.Size = new System.Drawing.Size(214, 20);
            this.textBoxPasswordNewConfirm.TabIndex = 16;
            // 
            // textBoxPasswordNew
            // 
            this.textBoxPasswordNew.Location = new System.Drawing.Point(4, 60);
            this.textBoxPasswordNew.Name = "textBoxPasswordNew";
            this.textBoxPasswordNew.PasswordChar = '•';
            this.textBoxPasswordNew.Size = new System.Drawing.Size(214, 20);
            this.textBoxPasswordNew.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Librarian Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSettingsDashboard
            // 
            this.buttonSettingsDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsDashboard.Location = new System.Drawing.Point(12, 12);
            this.buttonSettingsDashboard.Name = "buttonSettingsDashboard";
            this.buttonSettingsDashboard.Size = new System.Drawing.Size(144, 37);
            this.buttonSettingsDashboard.TabIndex = 0;
            this.buttonSettingsDashboard.Text = "🏠︎Dashboard";
            this.buttonSettingsDashboard.UseVisualStyleBackColor = false;
            this.buttonSettingsDashboard.Click += new System.EventHandler(this.buttonSettingsDashboard_Click);
            // 
            // buttonSettingsBookings
            // 
            this.buttonSettingsBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsBookings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsBookings.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsBookings.Location = new System.Drawing.Point(161, 12);
            this.buttonSettingsBookings.Name = "buttonSettingsBookings";
            this.buttonSettingsBookings.Size = new System.Drawing.Size(123, 37);
            this.buttonSettingsBookings.TabIndex = 7;
            this.buttonSettingsBookings.Text = "🕒Bookings";
            this.buttonSettingsBookings.UseVisualStyleBackColor = false;
            this.buttonSettingsBookings.Click += new System.EventHandler(this.buttonSettingsBookings_Click);
            // 
            // buttonSettingsBooks
            // 
            this.buttonSettingsBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsBooks.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsBooks.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsBooks.Location = new System.Drawing.Point(289, 12);
            this.buttonSettingsBooks.Name = "buttonSettingsBooks";
            this.buttonSettingsBooks.Size = new System.Drawing.Size(101, 37);
            this.buttonSettingsBooks.TabIndex = 8;
            this.buttonSettingsBooks.Text = "🕮 Books";
            this.buttonSettingsBooks.UseVisualStyleBackColor = false;
            this.buttonSettingsBooks.Click += new System.EventHandler(this.buttonSettingsBooks_Click);
            // 
            // buttonSettingsUsers
            // 
            this.buttonSettingsUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsUsers.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsUsers.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsUsers.Location = new System.Drawing.Point(396, 12);
            this.buttonSettingsUsers.Name = "buttonSettingsUsers";
            this.buttonSettingsUsers.Size = new System.Drawing.Size(101, 37);
            this.buttonSettingsUsers.TabIndex = 9;
            this.buttonSettingsUsers.Text = "👤Users";
            this.buttonSettingsUsers.UseVisualStyleBackColor = false;
            this.buttonSettingsUsers.Click += new System.EventHandler(this.buttonSettingsUsers_Click);
            // 
            // buttonSettingsLogOut
            // 
            this.buttonSettingsLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsLogOut.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsLogOut.Location = new System.Drawing.Point(949, 12);
            this.buttonSettingsLogOut.Name = "buttonSettingsLogOut";
            this.buttonSettingsLogOut.Size = new System.Drawing.Size(95, 37);
            this.buttonSettingsLogOut.TabIndex = 10;
            this.buttonSettingsLogOut.Text = "Log Out";
            this.buttonSettingsLogOut.UseVisualStyleBackColor = false;
            this.buttonSettingsLogOut.Click += new System.EventHandler(this.buttonSettingsLogOut_Click);
            // 
            // buttonSettingsSettings
            // 
            this.buttonSettingsSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.buttonSettingsSettings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsSettings.Location = new System.Drawing.Point(501, 12);
            this.buttonSettingsSettings.Name = "buttonSettingsSettings";
            this.buttonSettingsSettings.Size = new System.Drawing.Size(113, 37);
            this.buttonSettingsSettings.TabIndex = 9;
            this.buttonSettingsSettings.Text = "⚙️Settings";
            this.buttonSettingsSettings.UseVisualStyleBackColor = false;
            this.buttonSettingsSettings.Click += new System.EventHandler(this.buttonSettingsSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.buttonSettingsSettings);
            this.panel1.Controls.Add(this.buttonSettingsLogOut);
            this.panel1.Controls.Add(this.buttonSettingsUsers);
            this.panel1.Controls.Add(this.buttonSettingsBooks);
            this.panel1.Controls.Add(this.buttonSettingsBookings);
            this.panel1.Controls.Add(this.buttonSettingsDashboard);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 57);
            this.panel1.TabIndex = 7;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSettings";
            this.Text = "Library Manager Settings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordNew;
        private System.Windows.Forms.TextBox textBoxPasswordNewConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUnlock;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonSettingsDashboard;
        private System.Windows.Forms.Button buttonSettingsBookings;
        private System.Windows.Forms.Button buttonSettingsBooks;
        private System.Windows.Forms.Button buttonSettingsUsers;
        private System.Windows.Forms.Button buttonSettingsLogOut;
        private System.Windows.Forms.Button buttonSettingsSettings;
        private System.Windows.Forms.Panel panel1;
    }
}