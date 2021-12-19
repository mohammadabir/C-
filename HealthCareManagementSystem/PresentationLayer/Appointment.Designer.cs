
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PrescribedataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointdataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parientInfoShowdataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescribedataGridView1)).BeginInit();
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
            this.AppointdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.groupBox2.Size = new System.Drawing.Size(435, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // parientInfoShowdataGridView2
            // 
            this.parientInfoShowdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parientInfoShowdataGridView2.Location = new System.Drawing.Point(22, 19);
            this.parientInfoShowdataGridView2.Name = "parientInfoShowdataGridView2";
            this.parientInfoShowdataGridView2.Size = new System.Drawing.Size(395, 155);
            this.parientInfoShowdataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PrescribedataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 219);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescription";
            // 
            // PrescribedataGridView1
            // 
            this.PrescribedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescribedataGridView1.Location = new System.Drawing.Point(219, 19);
            this.PrescribedataGridView1.Name = "PrescribedataGridView1";
            this.PrescribedataGridView1.Size = new System.Drawing.Size(806, 194);
            this.PrescribedataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Logoutbutton2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescribedataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PrescribedataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}