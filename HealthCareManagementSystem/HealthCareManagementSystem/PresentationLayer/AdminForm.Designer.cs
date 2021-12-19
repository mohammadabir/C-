
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Appointmen22tListFromAdmindataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PrescFrom2AdmintextBox1 = new System.Windows.Forms.TextBox();
            this.PatientInfogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsInfodataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointmen22tListFromAdmindataGridView1)).BeginInit();
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
            // 
            // PatientsInfodataGridView1
            // 
            this.PatientsInfodataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientsInfodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsInfodataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientsInfodataGridView1.Location = new System.Drawing.Point(21, 19);
            this.PatientsInfodataGridView1.Name = "PatientsInfodataGridView1";
            this.PatientsInfodataGridView1.Size = new System.Drawing.Size(886, 131);
            this.PatientsInfodataGridView1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Appointmen22tListFromAdmindataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(33, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment List ";
            // 
            // Appointmen22tListFromAdmindataGridView1
            // 
            this.Appointmen22tListFromAdmindataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Appointmen22tListFromAdmindataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointmen22tListFromAdmindataGridView1.Location = new System.Drawing.Point(6, 19);
            this.Appointmen22tListFromAdmindataGridView1.Name = "Appointmen22tListFromAdmindataGridView1";
            this.Appointmen22tListFromAdmindataGridView1.Size = new System.Drawing.Size(525, 99);
            this.Appointmen22tListFromAdmindataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prescription ID";
            // 
            // PrescFrom2AdmintextBox1
            // 
            this.PrescFrom2AdmintextBox1.Location = new System.Drawing.Point(645, 354);
            this.PrescFrom2AdmintextBox1.Name = "PrescFrom2AdmintextBox1";
            this.PrescFrom2AdmintextBox1.Size = new System.Drawing.Size(209, 20);
            this.PrescFrom2AdmintextBox1.TabIndex = 8;
            this.PrescFrom2AdmintextBox1.TextChanged += new System.EventHandler(this.PrescFromAdmintextBox1_TextChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.PrescFrom2AdmintextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IDOPlabel1);
            this.Controls.Add(this.Backbutton22);
            this.Controls.Add(this.LogOutbutton1);
            this.Controls.Add(this.RegistrationPagebutton);
            this.Controls.Add(this.PatientInfogroupBox);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.PatientInfogroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsInfodataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Appointmen22tListFromAdmindataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Appointmen22tListFromAdmindataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrescFrom2AdmintextBox1;

        //public EventHandler AdminForm_Load { get; private set; }
    }
}