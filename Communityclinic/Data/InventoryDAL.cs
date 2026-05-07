
using System;
using System.Data;
using System.Data.SqlClient;
using CommunityClinic.Models;

namespace CommunityClinic
{
        public class InventoryDAL
        {
            private string connectionString =
                "Data Source=23.95.235.16;Initial Catalog=CommunityClinicLLOMDB;User ID=vtdi_student;Password=P@ssword1;";

            // GET ALL ITEMS (FOR GRIDVIEW)
            public DataTable GetItems()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Inventory";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;
                }
            }

            // INSERT ITEM
            public bool InsertItem(Inventoryitems item)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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

            // UPDATE ITEM
         
            public bool Update(Inventoryitems item)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Inventory SET
                    Item=@Item,
                    DateAdded=@DateAdded,
                    Quantity=@Quantity,
                    Description=@Description,
                    Price=@Price,
                    Expiration=@Expiration,
                    Category=@Category,
                    Unit=@Unit,
                    BatchNumber=@BatchNumber,
                    Manufacturer=@Manufacturer,
                    Supplier=@Supplier,
                    Status=@Status,
                    Notes=@Notes
                    WHERE BatchNumber=@BatchNumber";

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
}