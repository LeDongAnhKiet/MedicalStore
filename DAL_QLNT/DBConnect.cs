using DTO_QLNT;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL_QLNT
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        // protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2P5RCL0;Initial Catalog=QLNT;Integrated Security=True");

        protected NhaThuoc _medical;

    }
}
