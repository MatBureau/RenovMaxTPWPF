using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenovMaxTP.Utils
{
    public static class BasicQueries
    {
        public static int Count(string table)
        {
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", DBConnector.Connection);
            int compte = 0;
            try
            {
                compte = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return compte;
        }
    }
}
