
using System;
using System.Windows.Forms;

namespace HealthCareManagementSystem.PresentationLayer
{
    partial class DoctorInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoctorInformationdataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SLtextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Updatebutton4 = new System.Windows.Forms.Button();
            this.Searchbutton3 = new System.Windows.Forms.Button();
            this.RemoveButton2 = new System.Windows.Forms.Button();
            this.AddDoctorbutton1 = new System.Windows.Forms.Button();
            this.VisitingfeetextBox5 = new System.Windows.Forms.TextBox();
            this.SpecialisttextBox4 = new System.Windows.Forms.TextBox();
            this.AvailabletimetextBox3 = new System.Windows.Forms.TextBox();
            this.NametextBox2 = new System.Windows.Forms.TextBox();
            this.doctorIDtextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton1 = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchDoctortextBox1 = new System.Windows.Forms.TextBox();
            this.Searchlabel7 = new System.Windows.Forms.Label();
            this.SearchDoctordataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorInformationdataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDoctordataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoctorInformationdataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(38, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // DoctorInformationdataGridView1
            // 
            this.DoctorInformationdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorInformationdataGridView1.Location = new System.Drawing.Point(26, 13);
            this.DoctorInformationdataGridView1.Name = "DoctorInformationdataGridView1";
            this.DoctorInformationdataGridView1.Size = new System.Drawing.Size(832, 137);
            this.DoctorInformationdataGridView1.TabIndex = 0;
            this.DoctorInformationdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorInformationdataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SLtextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Updatebutton4);
            this.groupBox2.Controls.Add(this.Searchbutton3);
            this.groupBox2.Controls.Add(this.RemoveButton2);
            this.groupBox2.Controls.Add(this.AddDoctorbutton1);
            this.groupBox2.Controls.Add(this.VisitingfeetextBox5);
            this.groupBox2.Controls.Add(this.SpecialisttextBox4);
            this.groupBox2.Controls.Add(this.AvailabletimetextBox3);
            this.groupBox2.Controls.Add(this.NametextBox2);
            this.groupBox2.Controls.Add(this.doctorIDtextBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Doctor Information";
            // 
            // SLtextBox1
            // 
            this.SLtextBox1.Location = new System.Drawing.Point(126, 183);
            this.SLtextBox1.Name = "SLtextBox1";
            this.SLtextBox1.Size = new System.Drawing.Size(226, 20);
            this.SLtextBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SL";
            // 
            // Updatebutton4
            // 
            this.Updatebutton4.Location = new System.Drawing.Point(394, 161);
            this.Updatebutton4.Name = "Updatebutton4";
            this.Updatebutton4.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton4.TabIndex = 13;
            this.Updatebutton4.Text = "Update";
            this.Updatebutton4.UseVisualStyleBackColor = true;
            this.Updatebutton4.Click += new System.EventHandler(this.Updatebutton4_Click);
            // 
            // Searchbutton3
            // 
            this.Searchbutton3.Location = new System.Drawing.Point(394, 118);
            this.Searchbutton3.Name = "Searchbutton3";
            this.Searchbutton3.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton3.TabIndex = 12;
            this.Searchbutton3.Text = "Search";
            this.Searchbutton3.UseVisualStyleBackColor = true;
            this.Searchbutton3.Click += new System.EventHandler(this.Searchbutton3_Click);
            // 
            // RemoveButton2
            // 
            this.RemoveButton2.Location = new System.Drawing.Point(394, 66);
            this.RemoveButton2.Name = "RemoveButton2";
            this.RemoveButton2.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton2.TabIndex = 11;
            this.RemoveButton2.Text = "Remove";
            this.RemoveButton2.UseVisualStyleBackColor = true;
            this.RemoveButton2.Click += new System.EventHandler(this.RemoveButton2_Click);
            // 
            // AddDoctorbutton1
            // 
            this.AddDoctorbutton1.Location = new System.Drawing.Point(394, 21);
            this.AddDoctorbutton1.Name = "AddDoctorbutton1";
            this.AddDoctorbutton1.Size = new System.Drawing.Size(75, 23);
            this.AddDoctorbutton1.TabIndex = 10;
            this.AddDoctorbutton1.Text = "Add";
            this.AddDoctorbutton1.UseVisualStyleBackColor = true;
            this.AddDoctorbutton1.Click += new System.EventHandler(this.AddDoctorbutton1_Click_1);
            // 
            // VisitingfeetextBox5
            // 
            this.VisitingfeetextBox5.Location = new System.Drawing.Point(126, 153);
            this.VisitingfeetextBox5.Name = "VisitingfeetextBox5";
            this.VisitingfeetextBox5.Size = new System.Drawing.Size(226, 20);
            this.VisitingfeetextBox5.TabIndex = 9;
            // 
            // SpecialisttextBox4
            // 
            this.SpecialisttextBox4.Location = new System.Drawing.Point(126, 121);
            this.SpecialisttextBox4.Name = "SpecialisttextBox4";
            this.SpecialisttextBox4.Size = new System.Drawing.Size(226, 20);
            this.SpecialisttextBox4.TabIndex = 8;
            // 
            // AvailabletimetextBox3
            // 
            this.AvailabletimetextBox3.Location = new System.Drawing.Point(126, 88);
            this.AvailabletimetextBox3.Name = "AvailabletimetextBox3";
            this.AvailabletimetextBox3.Size = new System.Drawing.Size(226, 20);
            this.AvailabletimetextBox3.TabIndex = 7;
            // 
            // NametextBox2
            // 
            this.NametextBox2.Location = new System.Drawing.Point(126, 54);
            this.NametextBox2.Name = "NametextBox2";
            this.NametextBox2.Size = new System.Drawing.Size(226, 20);
            this.NametextBox2.TabIndex = 6;
            // 
            // doctorIDtextBox1
            // 
            this.doctorIDtextBox1.Location = new System.Drawing.Point(126, 23);
            this.doctorIDtextBox1.Name = "doctorIDtextBox1";
            this.doctorIDtextBox1.Size = new System.Drawing.Size(226, 20);
            this.doctorIDtextBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VisitingFee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specialist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AvailableTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DoctorID";
            // 
            // Backbutton1
            // 
            this.Backbutton1.Location = new System.Drawing.Point(615, 12);
            this.Backbutton1.Name = "Backbutton1";
            this.Backbutton1.Size = new System.Drawing.Size(75, 23);
            this.Backbutton1.TabIndex = 2;
            this.Backbutton1.Text = "back";
            this.Backbutton1.UseVisualStyleBackColor = true;
            this.Backbutton1.Click += new System.EventHandler(this.Backbutton1_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(696, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchDoctortextBox1);
            this.groupBox3.Controls.Add(this.Searchlabel7);
            this.groupBox3.Controls.Add(this.SearchDoctordataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(38, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(879, 277);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Doctor";
            // 
            // SearchDoctortextBox1
            // 
            this.SearchDoctortextBox1.Location = new System.Drawing.Point(393, 202);
            this.SearchDoctortextBox1.Name = "SearchDoctortextBox1";
            this.SearchDoctortextBox1.Size = new System.Drawing.Size(259, 20);
            this.SearchDoctortextBox1.TabIndex = 2;
            this.SearchDoctortextBox1.TextChanged += new System.EventHandler(this.SearchDoctortextBox1_TextChanged);
            // 
            // Searchlabel7
            // 
            this.Searchlabel7.AutoSize = true;
            this.Searchlabel7.Location = new System.Drawing.Point(303, 205);
            this.Searchlabel7.Name = "Searchlabel7";
            this.Searchlabel7.Size = new System.Drawing.Size(59, 13);
            this.Searchlabel7.TabIndex = 1;
            this.Searchlabel7.Text = "Serial or ID";
            // 
            // SearchDoctordataGridView1
            // 
            this.SearchDoctordataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDoctordataGridView1.Location = new System.Drawing.Point(126, 19);
            this.SearchDoctordataGridView1.Name = "SearchDoctordataGridView1";
            this.SearchDoctordataGridView1.Size = new System.Drawing.Size(702, 154);
            this.SearchDoctordataGridView1.TabIndex = 0;
            // 
            // DoctorInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.Backbutton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoctorInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorInformation_FormClosing);
            this.Load += new System.EventHandler(this.DoctorInformation_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorInformationdataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDoctordataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void AddDoctorbutton1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DoctorInformationdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DoctorInformationdataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Updatebutton4;
        private System.Windows.Forms.Button Searchbutton3;
        private System.Windows.Forms.Button RemoveButton2;
        private System.Windows.Forms.Button AddDoctorbutton1;
        private System.Windows.Forms.TextBox VisitingfeetextBox5;
        private System.Windows.Forms.TextBox SpecialisttextBox4;
        private System.Windows.Forms.TextBox AvailabletimetextBox3;
        private System.Windows.Forms.TextBox NametextBox2;
        private System.Windows.Forms.TextBox doctorIDtextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox SLtextBox1;
        private Label label6;
        private Button Backbutton1;
        private Button LogoutButton;
        private GroupBox groupBox3;
        private Label Searchlabel7;
        private DataGridView SearchDoctordataGridView1;
        private TextBox SearchDoctortextBox1;
    }
}