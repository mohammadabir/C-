using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using HealthCareManagementSystem.DataAccessLayer;
using HealthCareManagementSystem.PresentationLayer;

namespace HealthCareManagementSystem
{
    public partial class RegistrationText : Form
    {
        public RegistrationText()
        {
            InitializeComponent();
            RegistrationSubmitButton.Enabled = false;
           
        }

       

        private void RegistrationText_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     
        private void AgreecheckBox_CheckedChanged(object sender, EventArgs e)
        {


            if (AgreecheckBox.Checked)
            {
                RegistrationSubmitButton.Enabled = true;
            }
            else
            {
                RegistrationSubmitButton.Enabled = false;

            }

        }
        private void RegistrationSubmitButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                MessageBox.Show("Please Enter paitent Name");
            }

            else if ((MaleradioButton.Checked == false) && (FemaleradioButton.Checked == false) && (OtherradioButton.Checked == false))
            {
                MessageBox.Show("Please Select a gender of Paitent");
            }


            else if (EmailtextBox.Text == "")
            {
                MessageBox.Show("Please Type your Email"); 
            }



            else if (PhoneNumbertextBox.Text == "")
            {
                MessageBox.Show("Please Enter Paitent's Phonenumber"); 
            }

            else if (AddresstextBox.Text == "")
            {
                MessageBox.Show("Please Enter Paitent's Address"); 
            }

            else if (AgetextBox.Text == "")
            {
                MessageBox.Show("Please Enter Paitent's Age");
            }
            else
            {


                if (AddresstextBox.Text == NametextBox.Text)
                
                {
                    MessageBox.Show("All condition  are not Satisfied");
                }

                else
                {

                    Registration registration = new Registration();
                    registration.Username = NametextBox.Text;
                    registration.Email = EmailtextBox.Text;

                    if (MaleradioButton.Checked)
                    {
                        registration.Gender = "Male";
                    }
                    else if (FemaleradioButton.Checked)
                    {
                        registration.Gender = "Female";
                    }
                    else
                    {
                        registration.Gender = "Other";
                    }


                    registration.Number = PhoneNumbertextBox.Text;
                    registration.Address = AddresstextBox.Text;
                    registration.Age = Convert.ToInt32(AgetextBox.Text);


                    RegistrationAccess registrationAccess = new RegistrationAccess();

                    if (registrationAccess.Register(registration.Username, registration.Gender, registration.Email, registration.Number, registration.Address, registration.Age))
                    {
                        MessageBox.Show("Patient info entered successfully");
                        //Login login = new Login();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Patient info entered not successfully ");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
