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
        public bool AddDoctor(string DoctorID, string Name, string Specialist, string AvailableTime, string VisitingFee)
        {
            string sql = "INSERT INTO Doctors ( DoctorID, Name,Specialist,AvailableTime, VisitingFee) VALUES('" + DoctorID + "','" + Name + "','" + Specialist + "','" + AvailableTime + "','" + VisitingFee + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveDoctor(string DoctorID)
        {
            string sql = "DELETE FROM Doctors WHERE DoctorID ='" + DoctorID + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public string GetNameBySL(int SL)
        {
            string sql = "SELECT * FROM Doctors WHERE SL=" + SL;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return reader["Name"].ToString();
            }
            return null;
        }

        public bool UpdateDoctor(int SL, string Name, string Specialist, string AvailableTime, string VisitingFee)
        {
            string sql = "UPDATE Doctors SET Name='" + Name + "',Specialist='" + Specialist + "', AvailableTime='" + AvailableTime + "',VisitingFee='" + VisitingFee + "' WHERE SL=" + SL;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public List<Doctor> GetDoctorByID(string DoctorID)
        {
            string sql = "SELECT * FROM Doctors WHERE DoctorID LIKE '" + DoctorID + "%'";
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
        public List<Doctor> GetDoctorBySl(int SL)
        {



            string sql = "SELECT* FROM Doctors WHERE SL LIKE '" + SL + "%'";
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
