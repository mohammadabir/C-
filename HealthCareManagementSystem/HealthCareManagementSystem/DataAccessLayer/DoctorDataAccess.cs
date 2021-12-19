using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class DoctorDataAccess : DatabaseConnection
    {

        public List<Doctor> GetAllDoctors()
        {
            string sql = "SELECT * FROM Doctors";
            SqlDataReader reader = this.GetData(sql);
            List<Doctor> doctors = new List<Doctor>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.SL = (int)reader["SL"];
                doctor.DoctorID = reader["DoctorID"].ToString();
                doctor.Name = reader["Name"].ToString();
                doctor.Specialist = reader["Specialist"].ToString();
                doctor.AvailableTime = reader["AvailableTime"].ToString();
                doctor.VisitingFee = reader["VisitingFee"].ToString(); ;
                doctors.Add(doctor);
            }
            return doctors;
        }
        public bool AddDoctor(string doctorID, string name, string specialist, string availableTime, string visitingFee)
        {
            string sql = "INSERT INTO Doctors ( DoctorID, Name,Specialist,AvailableTime, VisitingFee) VALUES('" + doctorID + "','" + name + "','" + specialist + "','" + availableTime + "','" + visitingFee + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveDoctor(string doctorID)
        {
            string sql = "DELETE FROM Doctors WHERE DoctorID ='" + doctorID + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public string GetNameBySL(int sL)
        {
            string sql = "SELECT * FROM Doctors WHERE SL=" + sL;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["Name"].ToString();
            }
            return null;
        }

        public bool UpdateDoctor(int sL, string name, string specialist, string availableTime, string visitingFee)
        {
            string sql = "UPDATE Doctors SET Name='" + name + "',Specialist='" + specialist + "', AvailableTime='" + availableTime + "',VisitingFee='" + visitingFee + "' WHERE SL=" + sL;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public List<Doctor> GetDoctorByID(string doctorID)
        {
            string sql = "SELECT * FROM Doctors WHERE DoctorID LIKE '" + doctorID + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Doctor> doctors = new List<Doctor>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.SL = (int)reader["SL"];
                doctor.DoctorID = reader["DoctorID"].ToString();
                doctor.Name = reader["Name"].ToString();
                doctor.Specialist = reader["Specialist"].ToString();
                doctor.AvailableTime = reader["AvailableTime"].ToString();
                doctor.VisitingFee = reader["VisitingFee"].ToString();
                
                doctors.Add(doctor);
            }
            return doctors;
        }
        public List<Doctor> GetDoctorBySl(int sL)
        {



            string sql = "SELECT* FROM Doctors WHERE SL LIKE '" + sL + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Doctor> doctors = new List<Doctor>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.SL = (int)reader["SL"];
                doctor.DoctorID = reader["DoctorID"].ToString();
                doctor.Name = reader["Name"].ToString();
                doctor.Specialist = reader["Specialist"].ToString();
                doctor.AvailableTime = reader["AvailableTime"].ToString();
                doctor.VisitingFee = reader["VisitingFee"].ToString();

                doctors.Add(doctor);

            }
            return doctors;
        }
    }
}
