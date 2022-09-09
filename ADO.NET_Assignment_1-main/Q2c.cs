using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2c
    {
        public static void GetAllMovies() //Get All the Products
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            try
            {
                //con.ConnectionString = @"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Training1DB;Integrated Security=True";
                con.Open(); //open connection
                SqlCommand cmd = new SqlCommand("Select * from Movie", con);

                SqlDataReader dr = cmd.ExecuteReader(); //ExecureReader() method stores result set data into DataReader object

                while (dr.Read())
                {

                    Console.WriteLine(" Movieid:{0} Moviename:{1} Language:{2} Actor:{3} director:{4}", dr["MovieId"], dr["Movie_Name"], dr["Lang"], dr["Actor"], dr["Director"]);

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        static void Main()
        {

            GetAllMovies();
            //AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            // AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
        }

    }
}