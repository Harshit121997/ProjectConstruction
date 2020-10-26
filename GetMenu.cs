using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectConstruction
{
    public class GetMenu
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public DataTable GetMenus (int parentMenuId)
        {
            SqlCommand command = new SqlCommand();
            DataTable dtUserMaster = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                command.CommandText = "Sp_GetMenu";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparentMenuId = new SqlParameter("@parentMenuId", SqlDbType.Int);
                sqlparentMenuId.Value = parentMenuId;
                command.Parameters.Add(sqlparentMenuId);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtUserMaster);
            }
            return dtUserMaster;
        }

    }
}