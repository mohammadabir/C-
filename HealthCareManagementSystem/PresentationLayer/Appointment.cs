using HealthCareManagementSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareManagementSystem.PresentationLayer
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            RegistrationAccess registrationAccess = new RegistrationAccess();
            parientInfoShowdataGridView2.DataSource = registrationAccess.GetAllRegistratss();

        }

        private void Appointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DashbordOfDoctor dashbordOfDoctor = new DashbordOfDoctor();
            dashbordOfDoctor.Show();
            this.Hide();
        }

        private void Logoutbutton2_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void AppointSearchtextBox1_TextChanged(object sender, EventArgs e)
        {
            

            RegistrationAccess registrationAccess = new RegistrationAccess();
            RegistrationAccess registrationAccess1 = new RegistrationAccess();
            AppointdataGridView1.DataSource = registrationAccess.GetregisterByName(AppointSearchtextBox1.Text);
            AppointdataGridView1.DataSource = registrationAccess1.GetregisterBySl(Convert.ToInt32(AppointSearchtextBox1.Text));

        }
    }
}

