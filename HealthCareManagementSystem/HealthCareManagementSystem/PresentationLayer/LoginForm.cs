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
    public partial class Userlogin : Form
    {
        public Userlogin()
        {
            InitializeComponent();
        }

        private void Userlogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }



        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            LoginDataAccess loginDataAccess = new LoginDataAccess();
            LoginDataAccess loginDataAccess1 = new LoginDataAccess();
            if (UsernametextBox1.Text == "")
            {
                MessageBox.Show("Please Type Username");
            }
            else if (PasswordtextBox2.Text == "")
            {
                MessageBox.Show("Please Type Correct Password");
            }
           
            else
            {
                if (loginDataAccess.LoginValidation(UsernametextBox1.Text, PasswordtextBox2.Text) == true)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
               
                else if (loginDataAccess1.DoctorsLoginValidation(UsernametextBox1.Text, PasswordtextBox2.Text) == true)
                { 
                    DashbordOfDoctor dashbordOfDoctor = new DashbordOfDoctor();
                    dashbordOfDoctor.Show();
                    this.Hide();
                }

                else
                { 
                    MessageBox.Show("Invalid Username or Password");
                }

                
            }


        }

       
    }
}



