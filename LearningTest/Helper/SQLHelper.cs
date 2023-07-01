using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LearningTest.Helper
{
    public static class SQLHelper
    {
        public static string connectionString = @"Server=DESKTOP-CMQ6066\SQLEXPRESS;Database=Learning_Test;Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(connectionString);

        public static DataTable FetchAllData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("Select * from ParentMenu p inner join ChildMenu cm on p.id=cm.ParentID", con);

                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                //SqlDataReader sdr = cmd.ExecuteReader();


                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                con.Close();
                da.Dispose();
            }
            catch(Exception ex) { 
            }
            return dataTable;
        }
    }
}