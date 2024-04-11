// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;


Console.WriteLine("Hello, World!");

//nugetyst
//Ctrl+.

// C# => Db
SqlConnectionStringBuilder s=new SqlConnectionStringBuilder();
s.DataSource = "IT-CZT";
s.InitialCatalog = "DotNetTrainingBatch4";
s.UserID = "sa";
s.Password = "cho123!";
SqlConnection connection = new SqlConnection(s.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open.");
string query = "Select * from Tbl_Blog";
    SqlCommand cmd=new SqlCommand(query,connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt=new DataTable();
sqlDataAdapter.Fill(dt);

  
    connection.Close();
Console.WriteLine("Connection Close.");
foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id => "+dr["BlogId"]);
    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
    Console.WriteLine("---------------------------");
}
Console.ReadKey();
