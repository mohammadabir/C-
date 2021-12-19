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
    public partial class DashbordOfDoctor : Form
    {
        public DashbordOfDoctor()
        {
            InitializeComponent();
        }

        //private void Logoutbutton_Click(object sender, EventArgs e)
        //{
        //    Userlogin userlogin = new Userlogin();
        //    userlogin.Show();
        //    this.Hide();
        //}

        private void appointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void DashbordOfDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }
    }
}
