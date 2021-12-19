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
        //public bool RegistertionForm( string username, string gender, string email, string number, string address, int age)
        //{
        //    string sql = "INSERT INTO Registrations(Username,Gender,Email,Number,Address,Age) VALUES('" + username + "','" + gender + "','" +email + "','" + number + "','" + address + "','" + age + "')";
        //    int result = this.ExecuteQuery(sql);
        //    if (result > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
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
        //internal static bool LoginValidation(string text1, string text2)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
