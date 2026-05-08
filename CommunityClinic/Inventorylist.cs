using System;
using System.Windows.Forms;

namespace CommunityClinic
{
    public partial class InventorylistForm : Form
    {
        private InventoryDAL dal = new InventoryDAL();

        public InventorylistForm()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private void InventorylistForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // LOAD DATA INTO GRID
        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = dal.GetItems();


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // EXIT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //REFRESH BUTTON 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can later fill textboxes here if needed
        }
    }
}