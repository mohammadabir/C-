
namespace HealthCareManagementSystem.PresentationLayer
{
    partial class Userlogin
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
            this.Login = new System.Windows.Forms.GroupBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.LogingroupBox1 = new System.Windows.Forms.GroupBox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.Passwordlabel2 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.Usernamelabel1 = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.LogingroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.Loginbutton);
            this.Login.Controls.Add(this.PasswordtextBox);
            this.Login.Controls.Add(this.UserNametextBox);
            this.Login.Controls.Add(this.Passwordlabel);
            this.Login.Controls.Add(this.UserNamelabel);
            this.Login.Location = new System.Drawing.Point(29, 27);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(466, 398);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "User Login";
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(168, 315);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 6;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(184, 212);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox.TabIndex = 3;
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(184, 126);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNametextBox.TabIndex = 2;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(78, 219);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.Passwordlabel.TabIndex = 1;
            this.Passwordlabel.Text = "Password";
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(78, 129);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(55, 13);
            this.UserNamelabel.TabIndex = 0;
            this.UserNamelabel.Text = "Username";
            // 
            // LogingroupBox1
            // 
            this.LogingroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogingroupBox1.Controls.Add(this.Loginbutton1);
            this.LogingroupBox1.Controls.Add(this.PasswordtextBox2);
            this.LogingroupBox1.Controls.Add(this.Passwordlabel2);
            this.LogingroupBox1.Controls.Add(this.UsernametextBox1);
            this.LogingroupBox1.Controls.Add(this.Usernamelabel1);
            this.LogingroupBox1.Location = new System.Drawing.Point(12, 12);
            this.LogingroupBox1.Name = "LogingroupBox1";
            this.LogingroupBox1.Size = new System.Drawing.Size(260, 237);
            this.LogingroupBox1.TabIndex = 0;
            this.LogingroupBox1.TabStop = false;
            this.LogingroupBox1.Text = "Login";
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.AllowDrop = true;
            this.Loginbutton1.AutoEllipsis = true;
            this.Loginbutton1.Location = new System.Drawing.Point(66, 175);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton1.TabIndex = 4;
            this.Loginbutton1.Text = "Login";
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.AcceptsReturn = true;
            this.PasswordtextBox2.AcceptsTab = true;
            this.PasswordtextBox2.AllowDrop = true;
            this.PasswordtextBox2.Location = new System.Drawing.Point(80, 108);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.PasswordChar = '*';
            this.PasswordtextBox2.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox2.TabIndex = 3;
            // 
            // Passwordlabel2
            // 
            this.Passwordlabel2.AutoSize = true;
            this.Passwordlabel2.Location = new System.Drawing.Point(7, 115);
            this.Passwordlabel2.Name = "Passwordlabel2";
            this.Passwordlabel2.Size = new System.Drawing.Size(53, 13);
            this.Passwordlabel2.TabIndex = 2;
            this.Passwordlabel2.Text = "Password";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.AcceptsReturn = true;
            this.UsernametextBox1.AcceptsTab = true;
            this.UsernametextBox1.AllowDrop = true;
            this.UsernametextBox1.Location = new System.Drawing.Point(80, 40);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(100, 20);
            this.UsernametextBox1.TabIndex = 1;
            // 
            // Usernamelabel1
            // 
            this.Usernamelabel1.AutoSize = true;
            this.Usernamelabel1.Location = new System.Drawing.Point(7, 40);
            this.Usernamelabel1.Name = "Usernamelabel1";
            this.Usernamelabel1.Size = new System.Drawing.Size(55, 13);
            this.Usernamelabel1.TabIndex = 0;
            this.Usernamelabel1.Text = "Username";
            // 
            // Userlogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LogingroupBox1);
            this.Name = "Userlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Userlogin_FormClosing);
            //this.Load += new System.EventHandler(this.Userlogin_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.LogingroupBox1.ResumeLayout(false);
            this.LogingroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.GroupBox LogingroupBox1;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.Label Passwordlabel2;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.Label Usernamelabel1;
    }
}