using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO.DataAccess
{
    public class DbContext
    {
        SqlConnection conn;
        public DbContext()
        {
            conn = new SqlConnection("Server=LAPTOP-O4QV4AAI;Database=ADO_Proj;Trusted_Connection=True;TrustServerCertificate=True");

        }
        public DataTable ExcuteQuery(string commandText) 
        { 
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(commandText, conn);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }


        //Insert ,Update, Delete Will be done using connected because its better in CRUD because the DataBase is Always Updated
        public int ExcuteNonQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, conn);
            int rowsAffected = 0;
            try
            {
                conn.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsAffected;
        }
    
    }
}
