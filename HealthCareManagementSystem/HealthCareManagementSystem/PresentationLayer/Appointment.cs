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
            Prescriptionbutton1.Enabled = false;

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            RegistrationAccess registrationAccess = new RegistrationAccess();
            parientInfoShowdataGridView2.DataSource = registrationAccess.GetAllRegistratss();

            PrescriptionsAccess prescriptionsAccess = new PrescriptionsAccess();
            PrescriptiondataGridView1.DataSource = prescriptionsAccess.GetAllPrescriptions();

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prescriptionbutton1_Click(object sender, EventArgs e)
        {
            if (PatientRegistrationSltextBox2.Text == "")
            {
                MessageBox.Show("Please entry patient register ID");
            }

            else if (PrescriptiontextBox3.Text == "")
            {
                MessageBox.Show("please Write Description ");
            }

            else
            {
                if (PrescriptiontextBox3.Text== PatientRegistrationSltextBox2.Text)
                {
                    MessageBox.Show("Both doesnot match");
                }

                else
                {

                    Prescriptions prescriptions = new Prescriptions();


                  
                    prescriptions.RegSlNo = PatientRegistrationSltextBox2.Text;
                    prescriptions.Prescription = PrescriptiontextBox3.Text;

                    PrescriptionsAccess prescriptionsAccess = new PrescriptionsAccess();
                    if (prescriptionsAccess.Prescribed(prescriptions.RegSlNo, prescriptions.Prescription))
                    {
                        
                        MessageBox.Show("Prescription are given successfully");
                  
                        Appointment appointment = new Appointment();
                        appointment.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Prescription are not given");
                    }


                }
            }


        }

        private void patientcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (patientcheckBox1.Checked)
            {
                Prescriptionbutton1.Enabled = true;
            }
            else
            {
                Prescriptionbutton1.Enabled = true;

            }
        }
    }
}

