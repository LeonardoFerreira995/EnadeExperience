using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience
{
    public class Conexao
    {
        private static string _server = @"localhost\SQLEXPRESS";
        private static string _database = "AdLeste";
        //private static string user = "";
        //private static string password = "";

        private string connectionString = $"Data Source={_server};Initial Catalog={_database};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;max pool size=50000";
        //private string connectionString = @"Data Source=DESKTOP-MEQTHU1;Initial Catalog=AdLeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection _connection;

        public Conexao()
        {
            try
            {

                _connection = new SqlConnection(connectionString);
                _connection.Open();

            }
           catch(Exception ex)
            {
                throw new Exception("A conexão não foi fechada! " + ex);
            }
        }

        // Selects
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(sql, _connection);
            SqlDataAdapter da = new SqlDataAdapter(command);

            try
            {
                da.Fill(dataTable);
                return dataTable;
            }
            finally
            {
                _connection.Dispose();
                _connection.Close();
            }
            
        }

        // Executa Inserts, Updates e Deletes
        public void ExecutarComandoSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, _connection);
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Dispose();
                _connection.Close();
            }
            
        }

        //SqlConnection conn = new SqlConnection();

        //public Conexao()
        //{
        //    conn.ConnectionString = @"Data Source=DESKTOP-MEQTHU1;Initial Catalog=AdLeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //}
        //public SqlConnection Open()
        //{
        //    if(conn.State == System.Data.ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    return conn;
        //}

        //public SqlConnection Close()
        //{
        //    if (conn.State == System.Data.ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //    return conn;
        //}
    }
}
