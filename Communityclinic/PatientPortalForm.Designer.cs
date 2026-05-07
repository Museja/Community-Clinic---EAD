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
            this.SuspendLayout();
            // 
            // PatientPortalForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "PatientPortal";
            this.Load += new System.EventHandler(this.PatientPortal_Load_1);
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
        private CommunityClinic.CommunityClinicLLOMDBDataSet1 CommunityClinicLLOMDBDataSet1;
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
        private System.Windows.Forms.Button button1;
    }
}