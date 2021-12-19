


using HealthCareManagementSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           Application.Run(new Userlogin());
            // Application.Run(new DoctorsArrangement());
            //Application.Run(new RegistrationText());
            //Application.Run(new AdminForm());

            //Application.Run(new DoctorInformation());
        }
    }
}
