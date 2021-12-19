using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class Doctor
    {
        public int SL { get; set; }
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialist { get; set; }
        public string AvailableTime { get; set; }
        public string VisitingFee { get; set; }

    }
}
