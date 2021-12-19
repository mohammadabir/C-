using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class PrescriptionsAccess:DatabaseConnection
    {
        public List<Prescriptions> GetAllPrescriptions()
        {

            string sql = "SELECT* FROM Prescriptions";
            SqlDataReader reader = this.GetData(sql);
            List<Prescriptions> prescriptions = new List<Prescriptions>();
            while (reader.Read())
            {
                Prescriptions prescription = new Prescriptions();
                prescription.PrescriptionID = (int)reader["PrescriptionID"];
                prescription.RegSlNo = reader["RegSlNo"].ToString();
                prescription.Prescription = reader["Prescription"].ToString();


                prescriptions.Add(prescription);
               
            }
            return prescriptions;

        }


        
        public bool Prescribed( String RegSlNo, String Prescription)
        {
            string sql = "INSERT INTO Prescriptions(RegSlNo,Prescription) VALUES('" + RegSlNo + "','" + Prescription + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }



        public List<Prescriptions> GetPrescriptionsID(int id)
        {

            string sql = "SELECT* FROM Prescriptions WHERE PrescriptionID LIKE '" + id + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Prescriptions> prescriptions = new List<Prescriptions>();
            while (reader.Read())
            {
                Prescriptions prescription = new Prescriptions();
                prescription.PrescriptionID = (int)reader["PrescriptionID"];
                prescription.RegSlNo = reader["RegSlNo"].ToString();
                prescription.Prescription = reader["Prescription"].ToString();


                prescriptions.Add(prescription);

            }
            return prescriptions;

        }

       
    }
}
