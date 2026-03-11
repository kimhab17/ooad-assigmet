using System;
using System.Data;
using System.Data.SqlClient;

namespace saleAndBillingSystem
{
    // 3. Repository Pattern: Abstracts data access logic, separating it from the UI layer.
    public class CategoryRepository
    {
        public DataTable GetAllCategories()
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "SELECT * FROM Categories ORDER BY CategoryID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddCategory(string categoryName)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "INSERT INTO Categories (CategoryName) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", categoryName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCategory(int id, string categoryName)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "UPDATE Categories SET CategoryName=@name WHERE CategoryID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", categoryName);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCategory(int id)
        {
            using (SqlConnection conn = DatabaseManager.Instance.GetConnection())
            {
                string query = "DELETE FROM Categories WHERE CategoryID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
