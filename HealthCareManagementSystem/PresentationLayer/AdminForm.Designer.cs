
using System;

namespace HealthCareManagementSystem.PresentationLayer
{
    partial class AdminForm
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
            this.PatientInfogroupBox = new System.Windows.Forms.GroupBox();
            this.PatientsInfodataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistrationPagebutton = new System.Windows.Forms.Button();
            this.LogOutbutton1 = new System.Windows.Forms.Button();
            this.Backbutton22 = new System.Windows.Forms.Button();
            this.IDOPlabel1 = new System.Windows.Forms.Label();
            this.PatientInfogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsInfodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientInfogroupBox
            // 
            this.PatientInfogroupBox.Controls.Add(this.PatientsInfodataGridView1);
            this.PatientInfogroupBox.Location = new System.Drawing.Point(12, 69);
            this.PatientInfogroupBox.Name = "PatientInfogroupBox";
            this.PatientInfogroupBox.Size = new System.Drawing.Size(921, 160);
            this.PatientInfogroupBox.TabIndex = 1;
            this.PatientInfogroupBox.TabStop = false;
            this.PatientInfogroupBox.Text = "Patient Information";
            this.PatientInfogroupBox.Enter += new System.EventHandler(this.PatientInfogroupBox_Enter);
            // 
            // PatientsInfodataGridView1
            // 
            this.PatientsInfodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsInfodataGridView1.Location = new System.Drawing.Point(21, 19);
            this.PatientsInfodataGridView1.Name = "PatientsInfodataGridView1";
            this.PatientsInfodataGridView1.Size = new System.Drawing.Size(886, 131);
            this.PatientsInfodataGridView1.TabIndex = 0;
            this.PatientsInfodataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsInfodataGridView1_CellContentClick);
            // 
            // RegistrationPagebutton
            // 
            this.RegistrationPagebutton.Location = new System.Drawing.Point(400, 261);
            this.RegistrationPagebutton.Name = "RegistrationPagebutton";
            this.RegistrationPagebutton.Size = new System.Drawing.Size(75, 23);
            this.RegistrationPagebutton.TabIndex = 2;
            this.RegistrationPagebutton.Text = "Registration";
            this.RegistrationPagebutton.UseVisualStyleBackColor = true;
            this.RegistrationPagebutton.Click += new System.EventHandler(this.RegistrationPagebutton_Click);
            // 
            // LogOutbutton1
            // 
            this.LogOutbutton1.Location = new System.Drawing.Point(844, 12);
            this.LogOutbutton1.Name = "LogOutbutton1";
            this.LogOutbutton1.Size = new System.Drawing.Size(75, 23);
            this.LogOutbutton1.TabIndex = 3;
            this.LogOutbutton1.Text = "Logout";
            this.LogOutbutton1.UseVisualStyleBackColor = true;
            this.LogOutbutton1.Click += new System.EventHandler(this.LogOutbutton1_Click);
            // 
            // Backbutton22
            // 
            this.Backbutton22.Location = new System.Drawing.Point(763, 12);
            this.Backbutton22.Name = "Backbutton22";
            this.Backbutton22.Size = new System.Drawing.Size(75, 23);
            this.Backbutton22.TabIndex = 4;
            this.Backbutton22.Text = "Back";
            this.Backbutton22.UseVisualStyleBackColor = true;
            this.Backbutton22.Click += new System.EventHandler(this.Backbutton22_Click);
            // 
            // IDOPlabel1
            // 
            this.IDOPlabel1.AutoSize = true;
            this.IDOPlabel1.Location = new System.Drawing.Point(362, 245);
            this.IDOPlabel1.Name = "IDOPlabel1";
            this.IDOPlabel1.Size = new System.Drawing.Size(136, 13);
            this.IDOPlabel1.TabIndex = 5;
            this.IDOPlabel1.Text = "Input documents of patient ";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.IDOPlabel1);
            this.Controls.Add(this.Backbutton22);
            this.Controls.Add(this.LogOutbutton1);
            this.Controls.Add(this.RegistrationPagebutton);
            this.Controls.Add(this.PatientInfogroupBox);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.PatientInfogroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsInfodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void AdminForm_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.GroupBox PatientInfogroupBox;
        private System.Windows.Forms.Button RegistrationPagebutton;
        private System.Windows.Forms.Button LogOutbutton1;
        private System.Windows.Forms.Button Backbutton22;
        private System.Windows.Forms.Label IDOPlabel1;
        private System.Windows.Forms.DataGridView PatientsInfodataGridView1;

        //public EventHandler AdminForm_Load { get; private set; }
    }
}