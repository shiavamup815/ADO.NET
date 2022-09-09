using ADO_Dot_net_assingnment_1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Dot_net_assingnment_1
{
    internal class Q2a
    {
        public static void AddMovie(int MovieId, string Movie_Name, string Lang, string Actor, string Director) //add employee
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TUF8GF9\SQLEXPRESS; Initial Catalog = StudentDB; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into Movie values(@ID,@Name,@Language,@Actors,@Directors)", con);
                    ////passing values to sql parameter
                    cmd.Parameters.AddWithValue("@ID", MovieId);
                    cmd.Parameters.AddWithValue("@Name", Movie_Name);
                    cmd.Parameters.AddWithValue("@Language", Lang);
                    cmd.Parameters.AddWithValue("@Actors", Actor);
                    cmd.Parameters.AddWithValue("@Directors", Director);
                    // SqlParameter p = new SqlParameter("@Dept", dept);
                    ////add paramter to cmd 
                    // cmd.Parameters.Add(p);
                    // SqlCommand cmd = new SqlCommand($"insert into Employee values({emp},'{emp_fname}',{emp_lname},{dept})");
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
   
    
            AddMovie(25, "House of Dead", "Engish", "Peter", "dffdgg");
            AddMovie(26, "House of Sceret", "Hindi", "Unknown", "Ved Prakash");

            Console.ReadKey();
    }
  }
}
