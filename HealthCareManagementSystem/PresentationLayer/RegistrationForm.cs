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
            //RegistrationAccess registrationAccess = new RegistrationAccess();
            //registrationAccess.DataSource = registrationAccess;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationText_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Name cannot be empty");
            }

            else if ((MaleradioButton.Checked == false) && (FemaleradioButton.Checked == false) && (OtherradioButton.Checked == false))
            {
                MessageBox.Show("Select a gender");
            }


            else if (EmailtextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }



            else if (PhoneNumbertextBox.Text == "")
            {
                MessageBox.Show("Phonenumbercannot be empty");
            }

            else if (AddresstextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }

            else if (AgetextBox.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
            }




            else
            {

                //if (AgreecheckBox.Checked == true)
                //{
                //    MessageBox.Show("All condition are Satisfied");

                //}
                //else if (AgreecheckBox.Checked == false)
                //{
                //    MessageBox.Show("All condition not are Satisfied");
                //}

                


                    
                if (AddresstextBox.Text== NametextBox.Text)
                 //if(RegistrationSubmitButton == true)
                {
                    MessageBox.Show("All condition not are Satisfied");
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

                    //RegistrationSubmitButton.Enabled = true;





                    RegistrationAccess registrationAccess = new RegistrationAccess();

                    if (registrationAccess.Register(registration.Username, registration.Gender, registration.Email, registration.Number, registration.Address,registration.Age))
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

        private void RegistrationText_Load(object sender, EventArgs e)
        {

        }
    }
}
