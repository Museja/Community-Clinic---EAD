namespace Communityclinic
{
    partial class SearchForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lbldropdownlist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitSearchForm = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(489, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(613, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All",
            "Patients",
            "Doctor",
            "Medical Notes"});
            this.cmbCategory.Location = new System.Drawing.Point(99, 145);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(109, 227);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(63, 20);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Results";
            // 
            // lbldropdownlist
            // 
            this.lbldropdownlist.AutoSize = true;
            this.lbldropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldropdownlist.Location = new System.Drawing.Point(235, 151);
            this.lbldropdownlist.Name = "lbldropdownlist";
            this.lbldropdownlist.Size = new System.Drawing.Size(147, 15);
            this.lbldropdownlist.TabIndex = 4;
            this.lbldropdownlist.Text = "Select from the dropdown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a \"Keyword\" or ID Number";
            // 
            // btnExitSearchForm
            // 
            this.btnExitSearchForm.BackColor = System.Drawing.Color.Red;
            this.btnExitSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSearchForm.ForeColor = System.Drawing.Color.White;
            this.btnExitSearchForm.Location = new System.Drawing.Point(712, 407);
            this.btnExitSearchForm.Name = "btnExitSearchForm";
            this.btnExitSearchForm.Size = new System.Drawing.Size(63, 31);
            this.btnExitSearchForm.TabIndex = 6;
            this.btnExitSearchForm.Text = "E&xit";
            this.btnExitSearchForm.UseVisualStyleBackColor = false;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(113, 262);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(563, 164);
            this.lbResults.TabIndex = 7;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnExitSearchForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldropdownlist);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lbldropdownlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitSearchForm;
        private System.Windows.Forms.ListBox lbResults;
    }
}