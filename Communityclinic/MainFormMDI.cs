using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communityclinic
{
    public partial class MainFormMDI : Form
    {
        public UserRole.Role CurrentUserRole { get; private set; }
        public int CurrentUserId { get; private set; }
        public MainFormMDI(UserRole.Role role, int userId)
        {
            InitializeComponent();
            CurrentUserRole = role;
            CurrentUserId = userId;

            SetRolePermissions();
           // ConfigureAccess();
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == childForm.GetType())
                {
                    frm.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }
        // Logout from system
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out!");
            this.Hide();

            LoginForm login = new LoginForm();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------
        //                          Patient Menu
        //---------------------------------------------------------------------

        private void viewMyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientPortalForm(CurrentUserId));
        }

        private void updateMyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientPortalForm(CurrentUserId));
        }

        //----------------------------------------------------------------------------
        //                          Doctor Menu                                    
        //----------------------------------------------------------------------------

        private void doctorViewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorPortalForm());
        }

        private void doctorUpdateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorPortalForm());
        }

        private void saveMedicalNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MedicalNotesForm());
        }

        //---------------------------------------------------------------------------
        //                      Records Menu
        //---------------------------------------------------------------------------

        private void newPatientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegistrationForm());
        }

        private void newDoctorRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegistrationForm());
        }

        private void newAdminRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegistrationForm());
        }

        private void doctorRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorPortalForm());
        }

        private void patientRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientdataForm());
        }

        private void adminRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminRecordsForm());
        }

        //---------------------------------------------------------------------------
        //                          Appointments Menus
        //---------------------------------------------------------------------------

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewAppointmentForm());
        }

        private void rescheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RescheduleForm());
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CancelAppointmentForm());
        }
        //---------------------------------------------------------------------------------
        //                                Find Menu
        //---------------------------------------------------------------------------------

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Healthcare System v1.0");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchForm());
        }

        //----------------------------------------------------------------------------------
        //                                  Dashboard Menu
        //----------------------------------------------------------------------------------

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (CurrentUserRole)
            {
                case UserRole.Role.Admin:
                    OpenChildForm(new AdminDashboardForm());
                    break;

                case UserRole.Role.Doctor:
                    OpenChildForm(new DoctorDashboardForm());
                    break;

                case UserRole.Role.Patient:
                    OpenChildForm(new PatientDashboardForm());
                    break;
            }
        }

        // Role Permission

        private void SetRolePermissions()
        {
            patientToolStripMenuItem.Visible = false;
            doctorToolStripMenuItem.Visible = false;
            recordsToolStripMenuItem.Visible = false;
            appointmentToolStripMenuItem.Visible = false;

            switch (CurrentUserRole)
            {
                case UserRole.Role.Admin:
                    patientToolStripMenuItem.Visible = true;
                    doctorToolStripMenuItem.Visible = true;
                    recordsToolStripMenuItem.Visible = true;
                    appointmentToolStripMenuItem.Visible = true;
                    break;

                case UserRole.Role.Doctor:
                    doctorToolStripMenuItem.Visible = true;
                    appointmentToolStripMenuItem.Visible = true;
                    break;

                case UserRole.Role.Patient:
                    patientToolStripMenuItem.Visible = true;
                    appointmentToolStripMenuItem.Visible = true;
                    break;
            }
        }
        //Status strip
        private void MainFormMDI_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Logged in as: " + CurrentUserRole;
        }


        //Notify Icon

        private void MainFormMDI_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "App Minimized", "Still running...", ToolTipIcon.Info);
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        
    }

}
