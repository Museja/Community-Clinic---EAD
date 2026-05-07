using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace MOLLCommunityClinicWeb
{
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Restricts access if not logged in
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            lblMessage.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            lblMessage.CssClass = "text-success";
            lblMessage.Text = "Item saved successfully!";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            lblMessage.CssClass = "text-success";
            lblMessage.Text = "Item updated successfully!";
        }

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

            lblMessage.Visible = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InventoryList.aspx");
        }
    }
}