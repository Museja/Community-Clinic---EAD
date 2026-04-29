namespace CommunityClinic
{
    partial class PatientPortalForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnRefreshAppointments = new System.Windows.Forms.Button();
            this.dgvappointments1 = new System.Windows.Forms.DataGridView();
            this.communityClinicLLOMDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communityClinicLLOMDBDataSet1 = new Communityclinic.CommunityClinicLLOMDBDataSet1();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnLoadHistory = new System.Windows.Forms.Button();
            this.dgvHistory1 = new System.Windows.Forms.DataGridView();
            this.tabPrescriptions = new System.Windows.Forms.TabPage();
            this.btnLoadPrescriptions = new System.Windows.Forms.Button();
            this.dgvPrescriptions1 = new System.Windows.Forms.DataGridView();
            this.Logout = new System.Windows.Forms.Button();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).BeginInit();
            this.tabPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Controls.Add(this.tabAppointments);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabPrescriptions);
            this.tabControl1.Location = new System.Drawing.Point(26, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.dtDOB);
            this.tabProfile.Controls.Add(this.btnLoadProfile);
            this.tabProfile.Controls.Add(this.label5);
            this.tabProfile.Controls.Add(this.label4);
            this.tabProfile.Controls.Add(this.label3);
            this.tabProfile.Controls.Add(this.label2);
            this.tabProfile.Controls.Add(this.label1);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.txtAddress);
            this.tabProfile.Controls.Add(this.txtEmail);
            this.tabProfile.Controls.Add(this.txtPhone);
            this.tabProfile.Controls.Add(this.txtFullName);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(754, 367);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            this.tabProfile.Click += new System.EventHandler(this.PatientPortalForm_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateProfile.Location = new System.Drawing.Point(113, 329);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProfile.TabIndex = 6;
            this.btnUpdateProfile.Text = "Update";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(124, 173);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(124, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(124, 24);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.btnBookAppointment);
            this.tabAppointments.Controls.Add(this.btnRefreshAppointments);
            this.tabAppointments.Controls.Add(this.dgvappointments1);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(754, 367);
            this.tabAppointments.TabIndex = 1;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBookAppointment.Location = new System.Drawing.Point(88, 338);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnBookAppointment.TabIndex = 2;
            this.btnBookAppointment.Text = "Book";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnRefreshAppointments
            // 
            this.btnRefreshAppointments.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRefreshAppointments.Location = new System.Drawing.Point(7, 338);
            this.btnRefreshAppointments.Name = "btnRefreshAppointments";
            this.btnRefreshAppointments.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshAppointments.TabIndex = 1;
            this.btnRefreshAppointments.Text = "Refresh";
            this.btnRefreshAppointments.UseVisualStyleBackColor = false;
            this.btnRefreshAppointments.Click += new System.EventHandler(this.btnRefreshAppointments_Click);
            // 
            // dgvappointments1
            // 
            this.dgvappointments1.AutoGenerateColumns = false;
            this.dgvappointments1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvappointments1.DataSource = this.communityClinicLLOMDBDataSet1BindingSource;
            this.dgvappointments1.Location = new System.Drawing.Point(7, 7);
            this.dgvappointments1.Name = "dgvappointments1";
            this.dgvappointments1.Size = new System.Drawing.Size(741, 320);
            this.dgvappointments1.TabIndex = 0;
            // 
            // communityClinicLLOMDBDataSet1BindingSource
            // 
            this.communityClinicLLOMDBDataSet1BindingSource.DataSource = this.communityClinicLLOMDBDataSet1;
            this.communityClinicLLOMDBDataSet1BindingSource.Position = 0;
            // 
            // communityClinicLLOMDBDataSet1
            // 
            this.communityClinicLLOMDBDataSet1.DataSetName = "CommunityClinicLLOMDBDataSet1";
            this.communityClinicLLOMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.btnLoadHistory);
            this.tabHistory.Controls.Add(this.dgvHistory1);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(754, 367);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "Medical History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLoadHistory.Location = new System.Drawing.Point(7, 342);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(75, 23);
            this.btnLoadHistory.TabIndex = 1;
            this.btnLoadHistory.Text = "Load";
            this.btnLoadHistory.UseVisualStyleBackColor = false;
            this.btnLoadHistory.Click += new System.EventHandler(this.btnLoadHistory_Click);
            // 
            // dgvHistory1
            // 
            this.dgvHistory1.AutoGenerateColumns = false;
            this.dgvHistory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory1.DataSource = this.communityClinicLLOMDBDataSet1BindingSource;
            this.dgvHistory1.Location = new System.Drawing.Point(6, 7);
            this.dgvHistory1.Name = "dgvHistory1";
            this.dgvHistory1.Size = new System.Drawing.Size(742, 328);
            this.dgvHistory1.TabIndex = 0;
            // 
            // tabPrescriptions
            // 
            this.tabPrescriptions.Controls.Add(this.btnLoadPrescriptions);
            this.tabPrescriptions.Controls.Add(this.dgvPrescriptions1);
            this.tabPrescriptions.Location = new System.Drawing.Point(4, 22);
            this.tabPrescriptions.Name = "tabPrescriptions";
            this.tabPrescriptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrescriptions.Size = new System.Drawing.Size(754, 367);
            this.tabPrescriptions.TabIndex = 3;
            this.tabPrescriptions.Text = "Prescriptions";
            this.tabPrescriptions.UseVisualStyleBackColor = true;
            // 
            // btnLoadPrescriptions
            // 
            this.btnLoadPrescriptions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLoadPrescriptions.Location = new System.Drawing.Point(7, 338);
            this.btnLoadPrescriptions.Name = "btnLoadPrescriptions";
            this.btnLoadPrescriptions.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPrescriptions.TabIndex = 1;
            this.btnLoadPrescriptions.Text = "Load";
            this.btnLoadPrescriptions.UseVisualStyleBackColor = false;
            this.btnLoadPrescriptions.Click += new System.EventHandler(this.btnLoadPrescriptions_Click);
            // 
            // dgvPrescriptions1
            // 
            this.dgvPrescriptions1.AutoGenerateColumns = false;
            this.dgvPrescriptions1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions1.DataSource = this.communityClinicLLOMDBDataSet1BindingSource;
            this.dgvPrescriptions1.Location = new System.Drawing.Point(7, 7);
            this.dgvPrescriptions1.Name = "dgvPrescriptions1";
            this.dgvPrescriptions1.Size = new System.Drawing.Size(741, 326);
            this.dgvPrescriptions1.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Logout.Location = new System.Drawing.Point(703, 415);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoadProfile.Location = new System.Drawing.Point(20, 328);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProfile.TabIndex = 12;
            this.btnLoadProfile.Text = "Load";
            this.btnLoadProfile.UseVisualStyleBackColor = false;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(104, 227);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 13;
            // 
            // PatientPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "PatientPortalForm";
            this.Text = "PatientPortalForm";
            this.Load += new System.EventHandler(this.PatientPortalForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvappointments1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1)).EndInit();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).EndInit();
            this.tabPrescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabPrescriptions;
        private System.Windows.Forms.DataGridView dgvappointments1;
        private System.Windows.Forms.BindingSource communityClinicLLOMDBDataSet1BindingSource;
        private Communityclinic.CommunityClinicLLOMDBDataSet1 communityClinicLLOMDBDataSet1;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnRefreshAppointments;
        private System.Windows.Forms.DataGridView dgvHistory1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btnLoadHistory;
        private System.Windows.Forms.Button btnLoadPrescriptions;
        private System.Windows.Forms.DataGridView dgvPrescriptions1;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.DateTimePicker dtDOB;
    }
}