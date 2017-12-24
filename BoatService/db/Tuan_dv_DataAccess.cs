using System.Data;
using System.Data.SqlClient;

namespace BoatService.db
{
    public class Tuan_dv_DataAccess
    {
        public static SqlConnection con=  new SqlConnection(@"Data Source=DESKTOP-HS87TDC\SQLEXPRESS;Initial Catalog=boat;Integrated Security=True");
       
      
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static DataSet ExecQuery(string query, params SqlParameter[] sp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da;
            if (query.Contains(" "))
            {
                da = new SqlDataAdapter(query, con);
            }
            else
            {
                SqlCommand sc = new SqlCommand(query, con);
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                    {
                        sc.Parameters.Add(p);
                    }
                }
                da = new SqlDataAdapter(sc);
            }
            DataSet dt = new DataSet();
            
            da.Fill(dt);
            con.Close();
            return dt;
        }
        /// <summary>
        /// POST
        /// </summary>
        /// <param name="command"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static int ExecNonQuery(string command, params SqlParameter[] sp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand sc = new SqlCommand(command, con);
            if (command.Contains(" "))
            {
                sc.CommandType = CommandType.Text;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                    {
                        sc.Parameters.Add(p);
                    }
                }
            }
            else
            {
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                    {
                        sc.Parameters.Add(p);
                    }
                }
            }
            int kq = sc.ExecuteNonQuery();

            con.Close();
            return kq;
        }
    }
}