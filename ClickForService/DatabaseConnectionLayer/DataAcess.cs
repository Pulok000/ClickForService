using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickForService.DatabaseConnectionLayer
{
    class DataAcess
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAcess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);
            this.connection.Open();    
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteNonQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }

        public void ConnectionClose()
        {
            this.connection.Close();
        }
    }
}
