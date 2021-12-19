using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class LoginDataAccess : DatabaseConnection
    {
        
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM AdminT WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        
            public bool DoctorsLoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM LoginTable WHERE Username='" + username + "' AND Password='" + password +"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        

    }
}
