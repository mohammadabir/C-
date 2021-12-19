using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class DatabaseConnection:IDisposable
    {
        protected SqlConnection sqlconnection;
        protected SqlCommand sqlcommand;

        public DatabaseConnection()
        {
            this.sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HealthCare"].ConnectionString);
            this.sqlconnection.Open();

        }

        public SqlDataReader GetData(string sql)
        {
            this.sqlcommand = new SqlCommand(sql, sqlconnection);
            return this.sqlcommand.ExecuteReader();
        }



        public int ExecuteQuery(string sql)
        {
            this.sqlcommand = new SqlCommand(sql, sqlconnection);
            return this.sqlcommand.ExecuteNonQuery();
        }

        public void  Dispose()
        {
            this.sqlconnection.Close();
        }
    }
}
