using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRent.Database
{
    class Database
    {
        private SqlConnection Con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        //constructor
        public Database()
        {
            string constring = @"Data Source=DESKTOP-89NTJEN\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            Con.ConnectionString = constring;
            cmd.Connection = Con;
        }

        //Methode to fill the data grid view with the class DGV
        public DataTable FillDGV(string querySelect)
        {
            //database class
            DataTable dt = new DataTable();
            //fill by the query
            using (da = new SqlDataAdapter(querySelect, Con))
            {
                Con.Open();
                da.Fill(dt);
                Con.Close();
            }
        
            return dt;
        }
    }
}
