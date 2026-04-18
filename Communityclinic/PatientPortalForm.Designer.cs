namespace CommunityClinic
{
    public partial class PatientPortalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Logout = new System.Windows.Forms.Button();
            this.Profile1 = new System.Windows.Forms.TabControl();
            this.Profile = new System.Windows.Forms.TabPage();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.TabPage();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnRefreshAppointments = new System.Windows.Forms.Button();
            this.dgvappointments1 = new System.Windows.Forms.DataGridView();
            this.dgvHistory = new System.Windows.Forms.TabPage();
            this.dgvHistory1 = new System.Windows.Forms.DataGridView();
            this.dgvPrescriptions = new System.Windows.Forms.TabPage();
            this.dgvPrescriptions1 = new System.Windows.Forms.DataGridView();
            this.btnLoadHistory = new System.Windows.Forms.Button();
            this.btnLoadPrescriptions = new System.Windows.Forms.Button();
            this.Profile1.SuspendLayout();
            this.Profile.SuspendLayout();
            this.dgvAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments1)).BeginInit();
            this.dgvHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).BeginInit();
            this.dgvPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Logout.Location = new System.Drawing.Point(709, 402);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Profile1
            // 
            this.Profile1.Controls.Add(this.Profile);
            this.Profile1.Controls.Add(this.dgvAppointments);
            this.Profile1.Controls.Add(this.dgvHistory);
            this.Profile1.Controls.Add(this.dgvPrescriptions);
            this.Profile1.Location = new System.Drawing.Point(13, 13);
            this.Profile1.Name = "Profile1";
            this.Profile1.SelectedIndex = 0;
            this.Profile1.Size = new System.Drawing.Size(785, 383);
            this.Profile1.TabIndex = 12;
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.btnLoadProfile);
            this.Profile.Controls.Add(this.btnUpdateProfile);
            this.Profile.Controls.Add(this.txtFullName);
            this.Profile.Controls.Add(this.txtPhone);
            this.Profile.Controls.Add(this.txtEmail);
            this.Profile.Controls.Add(this.txtAddress);
            this.Profile.Controls.Add(this.txtDOB);
            this.Profile.Controls.Add(this.label5);
            this.Profile.Controls.Add(this.label4);
            this.Profile.Controls.Add(this.label3);
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.label1);
            this.Profile.Location = new System.Drawing.Point(4, 22);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(777, 357);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadProfile.Location = new System.Drawing.Point(150, 307);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProfile.TabIndex = 11;
            this.btnLoadProfile.Text = "Load";
            this.btnLoadProfile.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateProfile.Location = new System.Drawing.Point(24, 308);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProfile.TabIndex = 10;
            this.btnUpdateProfile.Text = "Update";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(115, 180);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 9;
            // 
            // textBox4
            // 
            this.txtAddress.Location = new System.Drawing.Point(115, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(115, 21);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
           // this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.Controls.Add(this.btnBookAppointment);
            this.dgvAppointments.Controls.Add(this.btnRefreshAppointments);
            this.dgvAppointments.Controls.Add(this.dgvappointments1);
            this.dgvAppointments.Location = new System.Drawing.Point(4, 22);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.dgvAppointments.Size = new System.Drawing.Size(777, 357);
            this.dgvAppointments.TabIndex = 1;
            this.dgvAppointments.Text = "Appointments";
            this.dgvAppointments.UseVisualStyleBackColor = true;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBookAppointment.Location = new System.Drawing.Point(103, 331);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnBookAppointment.TabIndex = 2;
            this.btnBookAppointment.Text = "Schedule";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            // 
            // btnRefreshAppointments
            // 
            this.btnRefreshAppointments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRefreshAppointments.Location = new System.Drawing.Point(7, 331);
            this.btnRefreshAppointments.Name = "btnRefreshAppointments";
            this.btnRefreshAppointments.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAppointments.TabIndex = 1;
            this.btnRefreshAppointments.Text = "Refresh";
            this.btnRefreshAppointments.UseVisualStyleBackColor = false;
            // 
            // dgvappointments1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvappointments1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvappointments1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvappointments1.Location = new System.Drawing.Point(0, 3);
            this.dgvappointments1.Name = "dgvappointments1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvappointments1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvappointments1.Size = new System.Drawing.Size(774, 321);
            this.dgvappointments1.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.Controls.Add(this.btnLoadHistory);
            this.dgvHistory.Controls.Add(this.dgvHistory1);
            this.dgvHistory.Location = new System.Drawing.Point(4, 22);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(777, 357);
            this.dgvHistory.TabIndex = 2;
            this.dgvHistory.Text = "Medical History";
            this.dgvHistory.UseVisualStyleBackColor = true;
            // 
            // dgvHistory1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistory1.Location = new System.Drawing.Point(0, 3);
            this.dgvHistory1.Name = "dgvHistory1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistory1.Size = new System.Drawing.Size(777, 320);
            this.dgvHistory1.TabIndex = 0;
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.Controls.Add(this.btnLoadPrescriptions);
            this.dgvPrescriptions.Controls.Add(this.dgvPrescriptions1);
            this.dgvPrescriptions.Location = new System.Drawing.Point(4, 22);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.Size = new System.Drawing.Size(777, 357);
            this.dgvPrescriptions.TabIndex = 3;
            this.dgvPrescriptions.Text = "Prescriptions";
            this.dgvPrescriptions.UseVisualStyleBackColor = true;
            // 
            // dgvPrescriptions1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescriptions1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrescriptions1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescriptions1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrescriptions1.Location = new System.Drawing.Point(0, 0);
            this.dgvPrescriptions1.Name = "dgvPrescriptions1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescriptions1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrescriptions1.Size = new System.Drawing.Size(774, 317);
            this.dgvPrescriptions1.TabIndex = 0;
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoadHistory.Location = new System.Drawing.Point(4, 330);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(75, 23);
            this.btnLoadHistory.TabIndex = 1;
            this.btnLoadHistory.Text = "Load";
            this.btnLoadHistory.UseVisualStyleBackColor = false;
            // 
            // btnLoadPrescriptions
            // 
            this.btnLoadPrescriptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoadPrescriptions.Location = new System.Drawing.Point(4, 324);
            this.btnLoadPrescriptions.Name = "btnLoadPrescriptions";
            this.btnLoadPrescriptions.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPrescriptions.TabIndex = 1;
            this.btnLoadPrescriptions.Text = "Load";
            this.btnLoadPrescriptions.UseVisualStyleBackColor = false;
            // 
            // PatientPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Profile1);
            this.Controls.Add(this.Logout);
            this.Name = "PatientPortalForm";
            this.Text = "PatientPortalForm";
            this.Profile1.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.dgvAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments1)).EndInit();
            this.dgvHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).EndInit();
            this.dgvPrescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TabControl Profile1;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage dgvAppointments;
        private System.Windows.Forms.TabPage dgvHistory;
        private System.Windows.Forms.TabPage dgvPrescriptions;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.DataGridView dgvappointments1;
        private System.Windows.Forms.DataGridView dgvHistory1;
        private System.Windows.Forms.DataGridView dgvPrescriptions1;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnRefreshAppointments;
        private System.Windows.Forms.Button btnLoadHistory;
        private System.Windows.Forms.Button btnLoadPrescriptions;
    }
}