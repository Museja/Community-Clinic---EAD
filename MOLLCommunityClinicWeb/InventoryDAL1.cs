using MOLLCommunityClinicWeb;
using System.Configuration;
using System.Data.SqlClient;

public class InventoryDAL1
{
    // INSERT ITEM
    public bool InsertItem(inventoryitemsModels1 item)
    {
        using (SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["db"].ConnectionString))
        {
            string query = @"INSERT INTO Inventory
                (Item, DateAdded, Quantity, Description, Price, Expiration,
                 Category, Unit, BatchNumber, Manufacturer, Supplier, Status, Notes)
                VALUES
                (@Item, @DateAdded, @Quantity, @Description, @Price, @Expiration,
                 @Category, @Unit, @BatchNumber, @Manufacturer, @Supplier, @Status, @Notes)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Item", item.Item);
            cmd.Parameters.AddWithValue("@DateAdded", item.DateAdded);
            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@Description", item.Description);
            cmd.Parameters.AddWithValue("@Price", item.Price);
            cmd.Parameters.AddWithValue("@Expiration", item.Expiration);
            cmd.Parameters.AddWithValue("@Category", item.Category);
            cmd.Parameters.AddWithValue("@Unit", item.Unit);
            cmd.Parameters.AddWithValue("@BatchNumber", item.BatchNumber);
            cmd.Parameters.AddWithValue("@Manufacturer", item.Manufacturer);
            cmd.Parameters.AddWithValue("@Supplier", item.Supplier);
            cmd.Parameters.AddWithValue("@Status", item.Status);
            cmd.Parameters.AddWithValue("@Notes", item.Notes);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}