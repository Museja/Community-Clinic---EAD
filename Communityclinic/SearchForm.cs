using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communityclinic
{
    public partial class SearchForm : Form
    {
        private string connectionString = "Your_Connection_String_Here";

        public SearchForm()
        {
            InitializeComponent();
            //Filters
            cmbCategory.Items.Add("Patients");
            cmbCategory.Items.Add("Doctors");
            cmbCategory.Items.Add("Admin");
            cmbCategory.SelectedIndex = 0; // Default to "Patients"
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string selectedFilter = cmbCategory.SelectedItem.ToString();

            // Perform the search based on the selected filter (Patients, Doctors, Admin)
            SearchDatabase(searchTerm, selectedFilter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }

        private void SearchDatabase(string searchTerm, string selectedFilter)
        {
            // Clear the previous results in the ListBox
            lbResults.Items.Clear();

            string query = "";

            // Set the query based on the selected filter (Patients, Doctors, Admin)
            if (selectedFilter == "Patients")
            {
                query = "SELECT Name FROM Patients WHERE Name LIKE @searchTerm";
            }
            else if (selectedFilter == "Doctors")
            {
                query = "SELECT Name FROM Doctors WHERE Name LIKE @searchTerm";
            }
            else if (selectedFilter == "Admin")
            {
                query = "SELECT Name FROM Admin WHERE Name LIKE @searchTerm";
            }
            else
            {
                MessageBox.Show("Invalid selection for search filter.");
                return;
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                // Open the connection
                connection.Open();

                // Execute the query and get the results
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Add the result to the ListBox
                    lbResults.Items.Add(reader["Name"].ToString());
                }
                reader.Close();

            }
        }

    }

}
