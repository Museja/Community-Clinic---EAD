namespace EAD_project
{
    partial class frmBookingForm
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
            lblHeading = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 24F);
            lblHeading.Location = new Point(80, 20);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(375, 45);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Request an Appointment";
            // 
            // frmBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Name = "frmBookingForm";
            Text = "Booking Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
    }
}