namespace Communityclinic
{
    partial class DoctorDashboardForm
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
            this.lblWelcomeDoctor = new System.Windows.Forms.Label();
            this.lblTodayCount = new System.Windows.Forms.Label();
            this.dgvAppointmentsDD = new System.Windows.Forms.DataGridView();
            this.PatientNameDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExitDD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsDD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeDoctor
            // 
            this.lblWelcomeDoctor.AutoSize = true;
            this.lblWelcomeDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDoctor.Location = new System.Drawing.Point(243, 42);
            this.lblWelcomeDoctor.Name = "lblWelcomeDoctor";
            this.lblWelcomeDoctor.Size = new System.Drawing.Size(245, 32);
            this.lblWelcomeDoctor.TabIndex = 0;
            this.lblWelcomeDoctor.Text = "Welcome, Doctor";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(278, 95);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(172, 20);
            this.lblTodayCount.TabIndex = 1;
            this.lblTodayCount.Text = "Appointments Today: 0";
            // 
            // dgvAppointmentsDD
            // 
            this.dgvAppointmentsDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientNameDD,
            this.TimeDD,
            this.StatusDD});
            this.dgvAppointmentsDD.Location = new System.Drawing.Point(122, 146);
            this.dgvAppointmentsDD.Name = "dgvAppointmentsDD";
            this.dgvAppointmentsDD.RowHeadersWidth = 62;
            this.dgvAppointmentsDD.RowTemplate.Height = 28;
            this.dgvAppointmentsDD.Size = new System.Drawing.Size(510, 104);
            this.dgvAppointmentsDD.TabIndex = 2;
            // 
            // PatientNameDD
            // 
            this.PatientNameDD.HeaderText = "Patient Name";
            this.PatientNameDD.MinimumWidth = 8;
            this.PatientNameDD.Name = "PatientNameDD";
            this.PatientNameDD.Width = 150;
            // 
            // TimeDD
            // 
            this.TimeDD.HeaderText = "Time";
            this.TimeDD.MinimumWidth = 8;
            this.TimeDD.Name = "TimeDD";
            this.TimeDD.Width = 150;
            // 
            // StatusDD
            // 
            this.StatusDD.HeaderText = "Status";
            this.StatusDD.MinimumWidth = 8;
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Width = 150;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(186, 306);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(137, 50);
            this.btnMarkCompleted.TabIndex = 3;
            this.btnMarkCompleted.Text = "Mark as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(394, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 55);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExitDD
            // 
            this.btnExitDD.BackColor = System.Drawing.Color.Red;
            this.btnExitDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDD.ForeColor = System.Drawing.Color.White;
            this.btnExitDD.Location = new System.Drawing.Point(700, 395);
            this.btnExitDD.Name = "btnExitDD";
            this.btnExitDD.Size = new System.Drawing.Size(71, 34);
            this.btnExitDD.TabIndex = 5;
            this.btnExitDD.Text = "E&xit";
            this.btnExitDD.UseVisualStyleBackColor = false;
            // 
            // DoctorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitDD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.dgvAppointmentsDD);
            this.Controls.Add(this.lblTodayCount);
            this.Controls.Add(this.lblWelcomeDoctor);
            this.Name = "DoctorDashboardForm";
            this.Text = "DoctorDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDoctor;
        private System.Windows.Forms.Label lblTodayCount;
        private System.Windows.Forms.DataGridView dgvAppointmentsDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNameDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDD;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExitDD;
    }
}