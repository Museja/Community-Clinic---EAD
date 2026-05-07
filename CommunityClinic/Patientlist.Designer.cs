namespace CommunityClinic
{
    partial class Patientlist
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
            this.Patientlistdgv = new System.Windows.Forms.DataGridView();
            this.communityClinicLLOMDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communityClinicLLOMDBDataSet = new CommunityClinic.CommunityClinicLLOMDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patientlistdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Patientlistdgv
            // 
            this.Patientlistdgv.AutoGenerateColumns = false;
            this.Patientlistdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patientlistdgv.DataSource = this.communityClinicLLOMDBDataSetBindingSource;
            this.Patientlistdgv.Location = new System.Drawing.Point(13, 33);
            this.Patientlistdgv.Name = "Patientlistdgv";
            this.Patientlistdgv.Size = new System.Drawing.Size(756, 405);
            this.Patientlistdgv.TabIndex = 0;
            this.Patientlistdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patientlistdgv_CellContentClick);
            // 
            // communityClinicLLOMDBDataSetBindingSource
            // 
            this.communityClinicLLOMDBDataSetBindingSource.DataSource = this.communityClinicLLOMDBDataSet;
            this.communityClinicLLOMDBDataSetBindingSource.Position = 0;
            // 
            // communityClinicLLOMDBDataSet
            // 
            this.communityClinicLLOMDBDataSet.DataSetName = "CommunityClinicLLOMDBDataSet";
            this.communityClinicLLOMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(677, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Patientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Patientlistdgv);
            this.Name = "Patientlist";
            this.Text = "Patientlist";
            ((System.ComponentModel.ISupportInitialize)(this.Patientlistdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communityClinicLLOMDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Patientlistdgv;
        private System.Windows.Forms.BindingSource communityClinicLLOMDBDataSetBindingSource;
        private CommunityClinicLLOMDBDataSet communityClinicLLOMDBDataSet;
        private System.Windows.Forms.Button button1;
    }
}