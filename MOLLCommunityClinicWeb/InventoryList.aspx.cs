using System;
using System.Data;

namespace MOLLCommunityClinicWeb
{
    public partial class InventoryList : System.Web.UI.Page
    {
        InventoryDAL1 dal = new InventoryDAL1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInventory();
            }
        }

        private void LoadInventory()
        {
            try
            {
                DataTable dt = dal.GetItems(); 

                gvInventory.DataSource = dt;
                gvInventory.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error loading inventory: " + ex.Message);
            }
        }
    }
}