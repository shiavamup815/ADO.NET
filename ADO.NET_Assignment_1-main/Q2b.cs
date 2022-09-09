using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2b
    {
        public static void GetMoviesbyName(string Movie_Name)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TUF8GF9\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True");
            try
            {
                //con.ConnectionString = @"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Training1DB;Integrated Security=True";
                con.Open(); //open connection

                SqlCommand cmd = new SqlCommand($"Select MovieId,Movie_Name,Lang,Actor,Director from Movie where Movie_Name='{Movie_Name}'", con);
                SqlDataReader dr = cmd.ExecuteReader(); //ExecureReader() method stores result set data into DataReader object
                if (dr.HasRows)
                {
                    dr.Read();


                    Console.WriteLine(" Movieid:{0} Moviename:{1} Language:{2} Actor:{3} director:{4}", dr["MovieId"], dr["Movie_Name"], dr["Lang"], dr["Actor"], dr["Director"]);
                }
                else
                    Console.WriteLine("Invalid Name");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection i.e disconnected from database
            }

        }

        static void Main()
        {
            Q2b Movie = new Q2b();
            //AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            // Movie.GetMovie();
            GetMoviesbyName("Harry Potter");
            //GetAll();
            Console.ReadKey();
        }
    }
}