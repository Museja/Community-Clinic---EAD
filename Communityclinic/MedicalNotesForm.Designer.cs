namespace Communityclinic
{
    partial class MedicalNotesForm
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
            this.lblMedicalNotes = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientIDNum = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientIDNum = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSubmitMNF = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMedicalNotes
            // 
            this.lblMedicalNotes.AutoSize = true;
            this.lblMedicalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalNotes.Location = new System.Drawing.Point(272, 45);
            this.lblMedicalNotes.Name = "lblMedicalNotes";
            this.lblMedicalNotes.Size = new System.Drawing.Size(204, 25);
            this.lblMedicalNotes.TabIndex = 0;
            this.lblMedicalNotes.Text = "Medical Notes Form";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(94, 120);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(105, 20);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblPatientIDNum
            // 
            this.lblPatientIDNum.AutoSize = true;
            this.lblPatientIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientIDNum.Location = new System.Drawing.Point(80, 187);
            this.lblPatientIDNum.Name = "lblPatientIDNum";
            this.lblPatientIDNum.Size = new System.Drawing.Size(144, 20);
            this.lblPatientIDNum.TabIndex = 2;
            this.lblPatientIDNum.Text = "Patient ID. Number";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(38, 143);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(234, 26);
            this.txtPatientName.TabIndex = 3;
            // 
            // txtPatientIDNum
            // 
            this.txtPatientIDNum.Location = new System.Drawing.Point(38, 210);
            this.txtPatientIDNum.Name = "txtPatientIDNum";
            this.txtPatientIDNum.Size = new System.Drawing.Size(234, 26);
            this.txtPatientIDNum.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(576, 81);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 5;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(38, 257);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(718, 131);
            this.txtNotes.TabIndex = 6;
            // 
            // btnSubmitMNF
            // 
            this.btnSubmitMNF.Location = new System.Drawing.Point(510, 403);
            this.btnSubmitMNF.Name = "btnSubmitMNF";
            this.btnSubmitMNF.Size = new System.Drawing.Size(75, 35);
            this.btnSubmitMNF.TabIndex = 7;
            this.btnSubmitMNF.Text = "&Submit";
            this.btnSubmitMNF.UseVisualStyleBackColor = true;
            this.btnSubmitMNF.Click += new System.EventHandler(this.btnSubmitMNF_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(653, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(626, 138);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(57, 20);
            this.lblDoctor.TabIndex = 9;
            this.lblDoctor.Text = "Doctor";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(542, 161);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(234, 26);
            this.txtDoctorName.TabIndex = 10;
            // 
            // MedicalNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmitMNF);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPatientIDNum);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientIDNum);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblMedicalNotes);
            this.Name = "MedicalNotesForm";
            this.Text = "MedicalNotesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicalNotes;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientIDNum;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientIDNum;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSubmitMNF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtDoctorName;
    }
}