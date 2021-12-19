using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class RegistrationAccess : DatabaseConnection
    {
        //public RegistrationAccess DataSource { get; internal set; }
        //public Registration PatientsInfodataGridView1 { get; private set; }

        public List<Registration> GetAllRegistratss()
        {

            string sql = "SELECT* FROM Registrations";
            SqlDataReader reader = this.GetData(sql);
            List<Registration> registrations = new List<Registration>();
            while (reader.Read())
            {
                Registration registration = new Registration();
                registration.RegSlNo = (int)reader["RegSlNo"];

                registration.Username = reader["Username"].ToString();
                registration.Gender = reader["Gender"].ToString();
                registration.Email = reader["Email"].ToString();
                registration.Number = reader["Number"].ToString();
                registration.Address = reader["Address"].ToString();
                registration.Age = (int)reader["Age"];
                registrations.Add(registration);
                //PatientsInfodataGridView1 = registration;
            }
            return registrations;

        }

        
        public bool Register(string name, string gender, string email, string number, string address, int age)
        {
            string sql = "INSERT INTO Registrations(Username,Gender,Email,Number,Address,age) VALUES('" + name + "','" + gender + "','" + email + "','" + number + "','" + address + "','" + age + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }


        //public List<Registration> GetRegistrationByName(String Name)
        //{

        //    string sql = "SELECT * FROM Registrations WHERE Username LIKE '" + Name;
        //    List<Registration> registrations = new List<Registration>();
        //    SqlDataReader reader = this.GetData(sql);
        //    while (reader.Read())
        //    {
        //        Registration registration = new Registration();
        //        registration.RegSlNo = (int)reader["RegSlNo"];
        //        registration.Username = reader["Username"].ToString();
        //        registration.Gender = reader["Gender"].ToString();
        //        registration.Email = reader["Email"].ToString();
        //        registration.Number = reader["Number"].ToString();
        //        registration.Address = reader["Address"].ToString();
        //        registration.Age = (int)reader["Age"];
        //        registrations.Add(registration);
        //    }
        //    return registrations;
        //}

        public List<Registration> GetregisterByName(String name)
        {



            string sql = "SELECT* FROM Registrations WHERE Username LIKE '" + name + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Registration> registrations = new List<Registration>();
            while (reader.Read())
            {
                Registration registration = new Registration();
                registration.RegSlNo = (int)reader["RegSlNo"];



                registration.Username = reader["Username"].ToString();
                registration.Gender = reader["Gender"].ToString();
                registration.Email = reader["Email"].ToString();
                registration.Number = reader["Number"].ToString();
                registration.Address = reader["Address"].ToString();
                registration.Age = (int)reader["Age"];
                registrations.Add(registration);

            }
            return registrations;




        }



        public List<Registration> GetregisterBySl(int regSlNo)
        {



            string sql = "SELECT* FROM Registrations WHERE RegSlNo LIKE '" + regSlNo + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Registration> registrations = new List<Registration>();
            while (reader.Read())
            {
                Registration registration = new Registration();
                registration.RegSlNo = (int)reader["RegSlNo"];



                registration.Username = reader["Username"].ToString();
                registration.Gender = reader["Gender"].ToString();
                registration.Email = reader["Email"].ToString();
                registration.Number = reader["Number"].ToString();
                registration.Address = reader["Address"].ToString();
                registration.Age = (int)reader["Age"];
                registrations.Add(registration);

            }
            return registrations;




        }









    }
}
