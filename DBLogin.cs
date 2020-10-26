using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProjectConstruction
{
    public class DBLogin
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public DataTable ValidateLogin(string emailId, string password)
        {
            SqlCommand command = new SqlCommand();
            DataTable dtUserMaster = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                command.CommandText = "Sp_GetUser";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlEmail = new SqlParameter("@UserEmail", SqlDbType.VarChar, 100);
                sqlEmail.Value = emailId;
                command.Parameters.Add(sqlEmail);
                SqlParameter sqlpassword = new SqlParameter("@Password", SqlDbType.VarChar, 100);
                sqlpassword.Value = password;
                command.Parameters.Add(sqlpassword);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtUserMaster);
            }
            return dtUserMaster;
        }

    }
}