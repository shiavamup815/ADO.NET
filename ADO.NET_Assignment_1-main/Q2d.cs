using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SqlDataAdapterDemo
{
    class Q2d
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");

        //SqlDataAdapter da = null;
       // DataSet ds = null;
        public  static void Main()
        {
            Console.WriteLine("Enter Actor Name Of Any Movie: ");
            string Actor =Console.ReadLine();

           // string cs = ConfigurationManager.ConnectionStrings["@Data Source=DESKTOP-TUF8GF9\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True"].ConnectionString;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("getMoviesbyActors", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Actors", Actor);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", row[0], row[1], row[2], row[3], row[4]);
            }

            //Console.WriteLine("-------------------------------");

            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4} {5}", row[0], row[1], row[2], row[3], row[4], row[5]);
            //}

            Console.ReadLine();

        }
    }
}