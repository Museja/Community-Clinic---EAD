namespace Communityclinic
{
    partial class PatientDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUpcomingAppointments = new System.Windows.Forms.Label();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnViewPrescription = new System.Windows.Forms.Button();
            this.btnExitPD = new System.Windows.Forms.Button();
            this.dgvAppointmentsPDB = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTimePD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsPDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(243, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(253, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Patient";
            // 
            // lblUpcomingAppointments
            // 
            this.lblUpcomingAppointments.AutoSize = true;
            this.lblUpcomingAppointments.Location = new System.Drawing.Point(282, 97);
            this.lblUpcomingAppointments.Name = "lblUpcomingAppointments";
            this.lblUpcomingAppointments.Size = new System.Drawing.Size(184, 20);
            this.lblUpcomingAppointments.TabIndex = 1;
            this.lblUpcomingAppointments.Text = "Upcoming Appointments";
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(224, 314);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(111, 65);
            this.btnBookAppointment.TabIndex = 3;
            this.btnBookAppointment.Text = "Book \r\nAppointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            // 
            // btnViewPrescription
            // 
            this.btnViewPrescription.Location = new System.Drawing.Point(450, 314);
            this.btnViewPrescription.Name = "btnViewPrescription";
            this.btnViewPrescription.Size = new System.Drawing.Size(122, 65);
            this.btnViewPrescription.TabIndex = 4;
            this.btnViewPrescription.Text = "View Prescription";
            this.btnViewPrescription.UseVisualStyleBackColor = true;
            // 
            // btnExitPD
            // 
            this.btnExitPD.BackColor = System.Drawing.Color.Red;
            this.btnExitPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPD.ForeColor = System.Drawing.Color.White;
            this.btnExitPD.Location = new System.Drawing.Point(689, 382);
            this.btnExitPD.Name = "btnExitPD";
            this.btnExitPD.Size = new System.Drawing.Size(65, 36);
            this.btnExitPD.TabIndex = 5;
            this.btnExitPD.Text = "E&xit";
            this.btnExitPD.UseVisualStyleBackColor = false;
            // 
            // dgvAppointmentsPDB
            // 
            this.dgvAppointmentsPDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsPDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Doctor,
            this.Status,
            this.AppointmentTimePD});
            this.dgvAppointmentsPDB.Location = new System.Drawing.Point(82, 157);
            this.dgvAppointmentsPDB.Name = "dgvAppointmentsPDB";
            this.dgvAppointmentsPDB.RowHeadersWidth = 62;
            this.dgvAppointmentsPDB.RowTemplate.Height = 28;
            this.dgvAppointmentsPDB.Size = new System.Drawing.Size(642, 113);
            this.dgvAppointmentsPDB.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 8;
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // AppointmentTimePD
            // 
            this.AppointmentTimePD.HeaderText = "Time";
            this.AppointmentTimePD.MinimumWidth = 8;
            this.AppointmentTimePD.Name = "AppointmentTimePD";
            this.AppointmentTimePD.Width = 150;
            // 
            // PatientDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAppointmentsPDB);
            this.Controls.Add(this.btnExitPD);
            this.Controls.Add(this.btnViewPrescription);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.lblUpcomingAppointments);
            this.Controls.Add(this.lblWelcome);
            this.Name = "PatientDashboardForm";
            this.Text = "PatientDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsPDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUpcomingAppointments;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnViewPrescription;
        private System.Windows.Forms.Button btnExitPD;
        private System.Windows.Forms.DataGridView dgvAppointmentsPDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTimePD;
    }
}