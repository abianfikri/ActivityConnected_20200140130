using System;
using System.Data.SqlClient;

namespace ActivityConnected_PABD
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = GetConnectionString();
            string query1 = "SELECT * FROM Pembimbing_Akademik where NIK=333";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using(SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    string query2 = "Update Pembimbing_Akademik SET Keahlian = 'Jaringan' Where NIK =333 ";
                    SqlCommand cmd2 = new SqlCommand(query2, cn);
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("Data has been Updated");
                }
            }
            Console.ReadLine();
        }

        private static string GetConnectionString()
        {
            return "data source=LAPTOP-91VJ4BQG;database=ProdiTI;MultipleActiveResultSets=True;User ID=sa;Password=abianfikri";
        }
    }
}
