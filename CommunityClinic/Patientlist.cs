using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CommunityClinic.Models.Patient;

namespace CommunityClinic
{
    public partial class Patientlist : Form
    {
        public Patientlist()
        {
            InitializeComponent();
        }

        private void Patientlistdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patientlistdgv.ReadOnly = true;
            Patientlistdgv.AllowUserToAddRows = false;
            Patientlistdgv.AllowUserToDeleteRows = false;
            Patientlistdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure you want to exit the application?",
           "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
