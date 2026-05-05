namespace Communityclinic
{
    partial class DoctorPortalForm
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
            this.lBLComingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBLComingSoon
            // 
            this.lBLComingSoon.AutoSize = true;
            this.lBLComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLComingSoon.Location = new System.Drawing.Point(215, 165);
            this.lBLComingSoon.Name = "lBLComingSoon";
            this.lBLComingSoon.Size = new System.Drawing.Size(323, 46);
            this.lBLComingSoon.TabIndex = 0;
            this.lBLComingSoon.Text = "COMING SOON";
            // 
            // DoctorPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBLComingSoon);
            this.Name = "DoctorPortalForm";
            this.Text = "DoctorPortalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBLComingSoon;
    }
}