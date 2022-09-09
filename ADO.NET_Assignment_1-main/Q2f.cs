using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2f
    {
        public static void DeleteMovie(int MovieId) //delete Movie
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TUF8GF9\SQLEXPRESS; Initial Catalog = StudentDB; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("Delete from Movie where MovieId=" + MovieId, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {

            DeleteMovie(25);
           // AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
           //  AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
        }
    }
}
