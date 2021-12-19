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
    public partial class DoctorInformation : Form
    {
        public DoctorInformation()
        {
            InitializeComponent();
            //DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            //SearchDoctordataGridView1.DataSource = doctorDataAccess.GetDoctorByName(SearchDoctortextBox1.Text);
        }



        private void DoctorInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void DoctorInformation_Load(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            DoctorInformationdataGridView1.DataSource = doctorDataAccess.GetAllDoctors();
            //LoadDoctorList();
        }


        void LoadDoctorList()
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            DoctorInformationdataGridView1.DataSource = doctorDataAccess.GetAllDoctors();
        }
        //private void AddDoctorbutton1_Click(object sender, EventArgs e)
        //{
        //    DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
        //    if (doctorDataAccess.AddNewDoctor(doctorIDtextBox1.Text, NametextBox2.Text, AvailabletimetextBox3.Text, SpecialisttextBox4.Text, Convert.ToInt32(VisitingfeetextBox5)))
        //    {
        //        MessageBox.Show("Specialist added successfully");
        //        LoadDoctorList();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Specialist is empty");
        //    }
        //}

        private void AddDoctorbutton1_Click_1(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            if (doctorDataAccess.AddDoctor(doctorIDtextBox1.Text, NametextBox2.Text, SpecialisttextBox4.Text,AvailabletimetextBox3.Text,VisitingfeetextBox5.Text))
            {
                MessageBox.Show("New Doctor added successfully");
                LoadDoctorList();
            }
            else
            {
                MessageBox.Show("Doctor is empty");
            }

        }
        private void RemoveButton2_Click(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            if (doctorDataAccess.RemoveDoctor(doctorIDtextBox1.Text))
            {
                MessageBox.Show("Remove Doctor successfully");
                LoadDoctorList();
            }
            else
            {
                MessageBox.Show("Doctor is empty");
            }

        }
        //private void searchButton_Click(object sender, EventArgs e)
        //{
        //    CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
        //    string value = categoryDataAccess.GetCategoryNameById(Convert.ToInt32(searchCategoryTextBox.Text));
        //    if (value == null)
        //    {
        //        MessageBox.Show("Category not found");
        //        updateCategoryNameTextBox.Text = "";
        //    }
        //    else
        //    {
        //        updateCategoryNameTextBox.Text = value;
        //    }
        //}
        private void Searchbutton3_Click(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            string value = doctorDataAccess.GetNameBySL(Convert.ToInt32(SLtextBox1.Text));
            if (value == null)
            {
                MessageBox.Show("Can not found");
                NametextBox2.Text = "";
            }
            else
            {
                NametextBox2.Text = value;
            }
           

        }

        private void Updatebutton4_Click(object sender, EventArgs e)
        {
            if ((SLtextBox1.Text == "") || (NametextBox2.Text == "") || (SpecialisttextBox4.Text == "") || (AvailabletimetextBox3.Text == "") || (VisitingfeetextBox5.Text == ""))
            {
                MessageBox.Show("Search proper Doctor to update");
            }
            else
            {
                DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
                if (doctorDataAccess.UpdateDoctor(Convert.ToInt32(SLtextBox1.Text), NametextBox2.Text, SpecialisttextBox4.Text,AvailabletimetextBox3.Text, VisitingfeetextBox5.Text))
                {
                    MessageBox.Show("Doctor List updated");
                    LoadDoctorList();
                }
                else
                {
                    MessageBox.Show("Error in updating");
                }
            }

        }
        private void SearchDoctortextBox1_TextChanged(object sender, EventArgs e)
        {
            DoctorDataAccess doctorDataAccess = new DoctorDataAccess();
            DoctorDataAccess doctorDataAccess1 = new DoctorDataAccess();

            SearchDoctordataGridView1.DataSource = doctorDataAccess.GetDoctorByID(SearchDoctortextBox1.Text);
            SearchDoctordataGridView1.DataSource = doctorDataAccess1.GetDoctorBySl(Convert.ToInt32(SearchDoctortextBox1.Text));
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

       

       
    }
}
