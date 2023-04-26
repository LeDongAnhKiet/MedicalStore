/*
using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Configuration;
using System.Data.SqlClient;

namespace DTO_QLNT
{
    public class ReadSQL
    {
        public void ExecuteScript(string sqlFile)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            ServerConnection serverConnection = new ServerConnection(connection);
            Server server = new Server(serverConnection);
            string script = File.ReadAllText(sqlFile);
            server.ConnectionContext.ExecuteNonQuery(script);
        }

    }
}
*/