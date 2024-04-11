using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetTrainingBatch4.ConsoleApp
{
    internal class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "DotNetTrainingBatch4",
            UserID = "sa",
            Password = "cho123!"
        };


        public void Read()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection Open.");
            string query = "select * from Tbl_Blog";
            SqlCommand cmd=new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Close.");
            
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine("Blog Id=>" + dr["BlogId"]);
                Console.WriteLine("Blog Title=>" + dr["BlogTitle"]);
                Console.WriteLine("Blog Author=>" + dr["BlogAuthor"]);
                Console.WriteLine("Blog Content=>" + dr["BlogContent"]);
                Console.WriteLine("---------------------------");

            }
        }
        //public void Create(string title, string author, string content)
        //{
        //    SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
        //    s.DataSource = "IT-CZT";
        //    s.InitialCatalog = "DotNetTrainingBatch4";
        //    s.UserID = "sa";
        //    s.Password = "cho123!";
        //    SqlConnection connection = new SqlConnection(s.ConnectionString);
        //    connection.Open();
        //    Console.WriteLine("Connection Open.");
        //    string query = "Select * from Tbl_Blog";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sqlDataAdapter.Fill(dt);


        //    connection.Close();
        //}
    }
}
