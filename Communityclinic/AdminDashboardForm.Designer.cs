namespace Communityclinic
{
    partial class AdminDashboardForm
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
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.lblTotalDoctors = new System.Windows.Forms.Label();
            this.lblDoctorsTitle = new System.Windows.Forms.Label();
            this.pnlPatient = new System.Windows.Forms.Panel();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.lblPatientTitle = new System.Windows.Forms.Label();
            this.pnlAppointments = new System.Windows.Forms.Panel();
            this.lblTotalAppointments = new System.Windows.Forms.Label();
            this.lblAppointmentsTitle = new System.Windows.Forms.Label();
            this.dgvDoctorsToday = new System.Windows.Forms.DataGridView();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAppointmentsToday = new System.Windows.Forms.DataGridView();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecentRegister = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegister = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnExitAdminDB = new System.Windows.Forms.Button();
            this.pnlDoctors.SuspendLayout();
            this.pnlPatient.SuspendLayout();
            this.pnlAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.lblTotalDoctors);
            this.pnlDoctors.Controls.Add(this.lblDoctorsTitle);
            this.pnlDoctors.Location = new System.Drawing.Point(97, 69);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(157, 89);
            this.pnlDoctors.TabIndex = 0;
            // 
            // lblTotalDoctors
            // 
            this.lblTotalDoctors.AutoSize = true;
            this.lblTotalDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoctors.Location = new System.Drawing.Point(49, 48);
            this.lblTotalDoctors.Name = "lblTotalDoctors";
            this.lblTotalDoctors.Size = new System.Drawing.Size(31, 32);
            this.lblTotalDoctors.TabIndex = 1;
            this.lblTotalDoctors.Text = "0";
            // 
            // lblDoctorsTitle
            // 
            this.lblDoctorsTitle.AutoSize = true;
            this.lblDoctorsTitle.Location = new System.Drawing.Point(15, 11);
            this.lblDoctorsTitle.Name = "lblDoctorsTitle";
            this.lblDoctorsTitle.Size = new System.Drawing.Size(104, 20);
            this.lblDoctorsTitle.TabIndex = 0;
            this.lblDoctorsTitle.Text = "Total Doctors";
            // 
            // pnlPatient
            // 
            this.pnlPatient.Controls.Add(this.lblTotalPatients);
            this.pnlPatient.Controls.Add(this.lblPatientTitle);
            this.pnlPatient.Location = new System.Drawing.Point(329, 69);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Size = new System.Drawing.Size(156, 89);
            this.pnlPatient.TabIndex = 1;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatients.Location = new System.Drawing.Point(56, 48);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(31, 32);
            this.lblTotalPatients.TabIndex = 1;
            this.lblTotalPatients.Text = "0";
            // 
            // lblPatientTitle
            // 
            this.lblPatientTitle.AutoSize = true;
            this.lblPatientTitle.Location = new System.Drawing.Point(23, 11);
            this.lblPatientTitle.Name = "lblPatientTitle";
            this.lblPatientTitle.Size = new System.Drawing.Size(106, 20);
            this.lblPatientTitle.TabIndex = 0;
            this.lblPatientTitle.Text = "Total Patients";
            // 
            // pnlAppointments
            // 
            this.pnlAppointments.Controls.Add(this.lblTotalAppointments);
            this.pnlAppointments.Controls.Add(this.lblAppointmentsTitle);
            this.pnlAppointments.Location = new System.Drawing.Point(552, 69);
            this.pnlAppointments.Name = "pnlAppointments";
            this.pnlAppointments.Size = new System.Drawing.Size(166, 89);
            this.pnlAppointments.TabIndex = 2;
            // 
            // lblTotalAppointments
            // 
            this.lblTotalAppointments.AutoSize = true;
            this.lblTotalAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAppointments.Location = new System.Drawing.Point(65, 51);
            this.lblTotalAppointments.Name = "lblTotalAppointments";
            this.lblTotalAppointments.Size = new System.Drawing.Size(31, 32);
            this.lblTotalAppointments.TabIndex = 1;
            this.lblTotalAppointments.Text = "0";
            // 
            // lblAppointmentsTitle
            // 
            this.lblAppointmentsTitle.AutoSize = true;
            this.lblAppointmentsTitle.Location = new System.Drawing.Point(3, 14);
            this.lblAppointmentsTitle.Name = "lblAppointmentsTitle";
            this.lblAppointmentsTitle.Size = new System.Drawing.Size(147, 20);
            this.lblAppointmentsTitle.TabIndex = 0;
            this.lblAppointmentsTitle.Text = "Total Appointments";
            // 
            // dgvDoctorsToday
            // 
            this.dgvDoctorsToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorsToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorName,
            this.Specialty,
            this.Status});
            this.dgvDoctorsToday.Location = new System.Drawing.Point(12, 206);
            this.dgvDoctorsToday.Name = "dgvDoctorsToday";
            this.dgvDoctorsToday.RowHeadersWidth = 62;
            this.dgvDoctorsToday.RowTemplate.Height = 28;
            this.dgvDoctorsToday.Size = new System.Drawing.Size(447, 88);
            this.dgvDoctorsToday.TabIndex = 3;
            // 
            // DoctorName
            // 
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.MinimumWidth = 8;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Width = 150;
            // 
            // Specialty
            // 
            this.Specialty.HeaderText = "Specialty";
            this.Specialty.MinimumWidth = 8;
            this.Specialty.Name = "Specialty";
            this.Specialty.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // dgvAppointmentsToday
            // 
            this.dgvAppointmentsToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientName,
            this.Doctor,
            this.Time,
            this.PatientStatus});
            this.dgvAppointmentsToday.Location = new System.Drawing.Point(465, 206);
            this.dgvAppointmentsToday.Name = "dgvAppointmentsToday";
            this.dgvAppointmentsToday.RowHeadersWidth = 62;
            this.dgvAppointmentsToday.RowTemplate.Height = 28;
            this.dgvAppointmentsToday.Size = new System.Drawing.Size(443, 88);
            this.dgvAppointmentsToday.TabIndex = 4;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.MinimumWidth = 8;
            this.PatientName.Name = "PatientName";
            this.PatientName.Width = 150;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 8;
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 150;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // PatientStatus
            // 
            this.PatientStatus.HeaderText = "Status";
            this.PatientStatus.MinimumWidth = 8;
            this.PatientStatus.Name = "PatientStatus";
            this.PatientStatus.Width = 150;
            // 
            // dgvRecentRegister
            // 
            this.dgvRecentRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type,
            this.DateRegister});
            this.dgvRecentRegister.Location = new System.Drawing.Point(181, 326);
            this.dgvRecentRegister.Name = "dgvRecentRegister";
            this.dgvRecentRegister.RowHeadersWidth = 62;
            this.dgvRecentRegister.RowTemplate.Height = 28;
            this.dgvRecentRegister.Size = new System.Drawing.Size(485, 87);
            this.dgvRecentRegister.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // DateRegister
            // 
            this.DateRegister.HeaderText = "Date Register";
            this.DateRegister.MinimumWidth = 8;
            this.DateRegister.Name = "DateRegister";
            this.DateRegister.Width = 150;
            // 
            // btnViewReports
            // 
            this.btnViewReports.Location = new System.Drawing.Point(373, 434);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(112, 49);
            this.btnViewReports.TabIndex = 6;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(304, 19);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(242, 32);
            this.lblWelcomeAdmin.TabIndex = 7;
            this.lblWelcomeAdmin.Text = "Welcome, Admin";
            // 
            // btnExitAdminDB
            // 
            this.btnExitAdminDB.BackColor = System.Drawing.Color.Red;
            this.btnExitAdminDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAdminDB.ForeColor = System.Drawing.Color.White;
            this.btnExitAdminDB.Location = new System.Drawing.Point(806, 496);
            this.btnExitAdminDB.Name = "btnExitAdminDB";
            this.btnExitAdminDB.Size = new System.Drawing.Size(69, 32);
            this.btnExitAdminDB.TabIndex = 8;
            this.btnExitAdminDB.Text = "E&xit";
            this.btnExitAdminDB.UseVisualStyleBackColor = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.btnExitAdminDB);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.dgvRecentRegister);
            this.Controls.Add(this.dgvAppointmentsToday);
            this.Controls.Add(this.dgvDoctorsToday);
            this.Controls.Add(this.pnlAppointments);
            this.Controls.Add(this.pnlPatient);
            this.Controls.Add(this.pnlDoctors);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            this.pnlAppointments.ResumeLayout(false);
            this.pnlAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorsToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctors;
        private System.Windows.Forms.Label lblDoctorsTitle;
        private System.Windows.Forms.Label lblTotalDoctors;
        private System.Windows.Forms.Panel pnlPatient;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblPatientTitle;
        private System.Windows.Forms.Panel pnlAppointments;
        private System.Windows.Forms.Label lblTotalAppointments;
        private System.Windows.Forms.Label lblAppointmentsTitle;
        private System.Windows.Forms.DataGridView dgvDoctorsToday;
        private System.Windows.Forms.DataGridView dgvAppointmentsToday;
        private System.Windows.Forms.DataGridView dgvRecentRegister;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegister;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnExitAdminDB;
    }
}