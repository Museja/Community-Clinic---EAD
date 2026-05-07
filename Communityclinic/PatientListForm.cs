using System;
using System.Windows.Forms;

namespace CommunityClinic
{
    public partial class PatientListForm : Form
    {
        public PatientListForm()
        {
            InitializeComponent();
        }

        // SAVE BUTTON
        private void patientBindingNavigatorSaveItem_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                this.Validate();

                this.patientBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(
                    this.communityClinicLLOMDBDataSet);

                MessageBox.Show(
                    "Patient records saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving data: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // FORM LOAD
        private void PatientListForm_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                this.patientTableAdapter.Fill(
                    this.communityClinicLLOMDBDataSet.Patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading patients: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}