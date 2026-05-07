using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

public partial class InventoryItem
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "Saved successfully!";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "Updated successfully!";
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

        lblMessage.Text = "";
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
