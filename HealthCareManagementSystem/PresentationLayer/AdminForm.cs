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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void Backbutton22_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void RegistrationPagebutton_Click(object sender, EventArgs e)
        {

            //RegistrationForm registrationForm = new RegistrationForm();
            RegistrationText registrationText = new RegistrationText();
            registrationText.Show();
            this.Hide();
        }

        private void PatientRegistrationlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientInfogroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void PatientsInfodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RegistrationAccess registrationAccess = new RegistrationAccess();
            //PatientsInfodataGridView1.DataSource = registrationAccess.GetAllRegistrationTable();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RegistrationAccess registrationAccess = new RegistrationAccess();
            PatientsInfodataGridView1.DataSource = registrationAccess.GetAllRegistratss();

        }

        //private void AdminForm_Load(object sender, EventArgs e)
        //{

        //}




    }
}
