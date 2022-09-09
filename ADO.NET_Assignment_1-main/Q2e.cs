using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2e
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        
        public static void Main()
        {
            Console.WriteLine("Enter Director Name Of Any Movie: ");
            string Director = Console.ReadLine();

            // string cs = ConfigurationManager.ConnectionStrings["@Data Source=DESKTOP-TUF8GF9\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"].ConnectionString;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("getMoviesbyDirector", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Directors", Director);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", row[0], row[1], row[2], row[3], row[4]);
            }

            

            Console.ReadLine();

        }
    }
}
