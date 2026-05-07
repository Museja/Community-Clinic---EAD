using System.Windows.Forms;

namespace CommunityClinic
{
    public partial class InventorylistForm : Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.communityClinicLLOMDBDataSet1 = new CommunityClinic.CommunityClinicLLOMDBDataSet();
            this.communityClinicLLOMDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(696, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.communityClinicLLOMDBDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 405);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // communityClinicLLOMDBDataSet1
            // 
            this.communityClinicLLOMDBDataSet1.DataSetName = "CommunityClinicLLOMDBDataSet";
            this.communityClinicLLOMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // communityClinicLLOMDBDataSet1BindingSource
            // 
            this.communityClinicLLOMDBDataSet1BindingSource.DataSource = this.communityClinicLLOMDBDataSet1;
            this.communityClinicLLOMDBDataSet1BindingSource.Position = 0;
            // 
            // Inventorylist
            // 
            this.ClientSize = new System.Drawing.Size(783, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Inventorylist";
            this.Load += new System.EventHandler(this.Inventorylist_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource communityClinicLLOMDBDataSet1BindingSource;
        private CommunityClinicLLOMDBDataSet communityClinicLLOMDBDataSet1;
    }
}