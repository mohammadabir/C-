
namespace HealthCareManagementSystem.PresentationLayer
{
    partial class Appointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.AppointdataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppointSearchtextBox1 = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.Logoutbutton2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parientInfoShowdataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.patientcheckBox1 = new System.Windows.Forms.CheckBox();
            this.Prescriptionbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrescriptiontextBox3 = new System.Windows.Forms.TextBox();
            this.PatientRegistrationSltextBox2 = new System.Windows.Forms.TextBox();
            this.PrescriptiondataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointdataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parientInfoShowdataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptiondataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AppointdataGridView1);
            this.groupBox1.Controls.Add(this.AppointSearchtextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Registration Serial or Name";
            // 
            // AppointdataGridView1
            // 
            this.AppointdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AppointdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointdataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.AppointdataGridView1.Location = new System.Drawing.Point(18, 19);
            this.AppointdataGridView1.Name = "AppointdataGridView1";
            this.AppointdataGridView1.Size = new System.Drawing.Size(513, 157);
            this.AppointdataGridView1.TabIndex = 0;
            // 
            // AppointSearchtextBox1
            // 
            this.AppointSearchtextBox1.Location = new System.Drawing.Point(219, 198);
            this.AppointSearchtextBox1.Name = "AppointSearchtextBox1";
            this.AppointSearchtextBox1.Size = new System.Drawing.Size(262, 20);
            this.AppointSearchtextBox1.TabIndex = 2;
            this.AppointSearchtextBox1.TextChanged += new System.EventHandler(this.AppointSearchtextBox1_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(914, 23);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Logoutbutton2
            // 
            this.Logoutbutton2.Location = new System.Drawing.Point(995, 23);
            this.Logoutbutton2.Name = "Logoutbutton2";
            this.Logoutbutton2.Size = new System.Drawing.Size(75, 23);
            this.Logoutbutton2.TabIndex = 4;
            this.Logoutbutton2.Text = "Logout";
            this.Logoutbutton2.UseVisualStyleBackColor = true;
            this.Logoutbutton2.Click += new System.EventHandler(this.Logoutbutton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parientInfoShowdataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(635, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 233);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // parientInfoShowdataGridView2
            // 
            this.parientInfoShowdataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.parientInfoShowdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parientInfoShowdataGridView2.Location = new System.Drawing.Point(22, 19);
            this.parientInfoShowdataGridView2.Name = "parientInfoShowdataGridView2";
            this.parientInfoShowdataGridView2.Size = new System.Drawing.Size(395, 155);
            this.parientInfoShowdataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.PrescriptiondataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 280);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescription";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.patientcheckBox1);
            this.groupBox4.Controls.Add(this.Prescriptionbutton1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.PrescriptiontextBox3);
            this.groupBox4.Controls.Add(this.PatientRegistrationSltextBox2);
            this.groupBox4.Location = new System.Drawing.Point(18, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 193);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input Prescription";
            // 
            // patientcheckBox1
            // 
            this.patientcheckBox1.AutoSize = true;
            this.patientcheckBox1.Location = new System.Drawing.Point(85, 126);
            this.patientcheckBox1.Name = "patientcheckBox1";
            this.patientcheckBox1.Size = new System.Drawing.Size(82, 17);
            this.patientcheckBox1.TabIndex = 10;
            this.patientcheckBox1.Text = "All are done";
            this.patientcheckBox1.UseVisualStyleBackColor = true;
            this.patientcheckBox1.CheckedChanged += new System.EventHandler(this.patientcheckBox1_CheckedChanged);
            // 
            // Prescriptionbutton1
            // 
            this.Prescriptionbutton1.Location = new System.Drawing.Point(85, 149);
            this.Prescriptionbutton1.Name = "Prescriptionbutton1";
            this.Prescriptionbutton1.Size = new System.Drawing.Size(75, 23);
            this.Prescriptionbutton1.TabIndex = 9;
            this.Prescriptionbutton1.Text = "Submit";
            this.Prescriptionbutton1.UseVisualStyleBackColor = true;
            this.Prescriptionbutton1.Click += new System.EventHandler(this.Prescriptionbutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PatientRegistrationSl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prescription";
            // 
            // PrescriptiontextBox3
            // 
            this.PrescriptiontextBox3.Location = new System.Drawing.Point(121, 98);
            this.PrescriptiontextBox3.Name = "PrescriptiontextBox3";
            this.PrescriptiontextBox3.Size = new System.Drawing.Size(128, 20);
            this.PrescriptiontextBox3.TabIndex = 5;
            this.PrescriptiontextBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PatientRegistrationSltextBox2
            // 
            this.PatientRegistrationSltextBox2.Location = new System.Drawing.Point(121, 58);
            this.PatientRegistrationSltextBox2.Name = "PatientRegistrationSltextBox2";
            this.PatientRegistrationSltextBox2.Size = new System.Drawing.Size(128, 20);
            this.PatientRegistrationSltextBox2.TabIndex = 4;
            // 
            // PrescriptiondataGridView1
            // 
            this.PrescriptiondataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PrescriptiondataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptiondataGridView1.Location = new System.Drawing.Point(321, 36);
            this.PrescriptiondataGridView1.Name = "PrescriptiondataGridView1";
            this.PrescriptiondataGridView1.Size = new System.Drawing.Size(719, 228);
            this.PrescriptiondataGridView1.TabIndex = 1;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1133, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Logoutbutton2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appointment_FormClosing);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointdataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parientInfoShowdataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptiondataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AppointdataGridView1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Logoutbutton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView parientInfoShowdataGridView2;
        private System.Windows.Forms.TextBox AppointSearchtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PrescriptiontextBox3;
        private System.Windows.Forms.TextBox PatientRegistrationSltextBox2;
        private System.Windows.Forms.DataGridView PrescriptiondataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Prescriptionbutton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox patientcheckBox1;
    }
}