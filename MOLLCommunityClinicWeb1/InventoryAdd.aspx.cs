using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MOLLCommunityClinicWeb1
{
    public partial class InventoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // SAVE
        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Inventory item saved successfully";
        }

        // UPDATE
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Blue;
            lblMessage.Text = "Inventory item updated successfully";
        }

        // CLEAR FORM
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtItem.Text = "";
            txtDateAdded.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtExpiration.Text = "";
            txtCategory.Text = "";
            txtUnit.Text = "";
            txtBatchNumber.Text = "";
            txtManufacturer.Text = "";
            txtSupplier.Text = "";
            txtStatus.Text = "";
            txtNotes.Text = "";

            lblMessage.Text = "";
        }

        // BACK TO MAIN MDI
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMDI.aspx");
        }

        // EXIT SYSTEM
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}