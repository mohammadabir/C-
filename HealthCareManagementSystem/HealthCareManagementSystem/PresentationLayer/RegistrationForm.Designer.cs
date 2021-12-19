
using System;

namespace HealthCareManagementSystem
{
    partial class RegistrationText
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
            this.PaitentRegistrationBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OtherradioButton = new System.Windows.Forms.RadioButton();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.RegistrationSubmitButton = new System.Windows.Forms.Button();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.Label();
            this.AgreecheckBox = new System.Windows.Forms.CheckBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.AgeLable = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.PaitentRegistrationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaitentRegistrationBox
            // 
            this.PaitentRegistrationBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PaitentRegistrationBox.Controls.Add(this.button2);
            this.PaitentRegistrationBox.Controls.Add(this.button1);
            this.PaitentRegistrationBox.Controls.Add(this.OtherradioButton);
            this.PaitentRegistrationBox.Controls.Add(this.AgetextBox);
            this.PaitentRegistrationBox.Controls.Add(this.RegistrationSubmitButton);
            this.PaitentRegistrationBox.Controls.Add(this.FemaleradioButton);
            this.PaitentRegistrationBox.Controls.Add(this.MaleradioButton);
            this.PaitentRegistrationBox.Controls.Add(this.Gender);
            this.PaitentRegistrationBox.Controls.Add(this.AgreecheckBox);
            this.PaitentRegistrationBox.Controls.Add(this.EmailtextBox);
            this.PaitentRegistrationBox.Controls.Add(this.PhoneNumbertextBox);
            this.PaitentRegistrationBox.Controls.Add(this.AddresstextBox);
            this.PaitentRegistrationBox.Controls.Add(this.AgeLable);
            this.PaitentRegistrationBox.Controls.Add(this.Address);
            this.PaitentRegistrationBox.Controls.Add(this.Number);
            this.PaitentRegistrationBox.Controls.Add(this.Email);
            this.PaitentRegistrationBox.Controls.Add(this.NametextBox);
            this.PaitentRegistrationBox.Controls.Add(this.Username);
            this.PaitentRegistrationBox.Location = new System.Drawing.Point(12, 26);
            this.PaitentRegistrationBox.Name = "PaitentRegistrationBox";
            this.PaitentRegistrationBox.Size = new System.Drawing.Size(789, 522);
            this.PaitentRegistrationBox.TabIndex = 0;
            this.PaitentRegistrationBox.TabStop = false;
            this.PaitentRegistrationBox.Text = "Registration";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtherradioButton
            // 
            this.OtherradioButton.AutoSize = true;
            this.OtherradioButton.Location = new System.Drawing.Point(456, 138);
            this.OtherradioButton.Name = "OtherradioButton";
            this.OtherradioButton.Size = new System.Drawing.Size(51, 17);
            this.OtherradioButton.TabIndex = 22;
            this.OtherradioButton.TabStop = true;
            this.OtherradioButton.Text = "Other";
            this.OtherradioButton.UseVisualStyleBackColor = true;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(165, 336);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(399, 20);
            this.AgetextBox.TabIndex = 21;
            this.AgetextBox.TextChanged += new System.EventHandler(this.AgetextBox_TextChanged);
            // 
            // RegistrationSubmitButton
            // 
            this.RegistrationSubmitButton.Location = new System.Drawing.Point(275, 444);
            this.RegistrationSubmitButton.Name = "RegistrationSubmitButton";
            this.RegistrationSubmitButton.Size = new System.Drawing.Size(157, 23);
            this.RegistrationSubmitButton.TabIndex = 20;
            this.RegistrationSubmitButton.Text = "Submit";
            this.RegistrationSubmitButton.UseVisualStyleBackColor = true;
            this.RegistrationSubmitButton.Click += new System.EventHandler(this.RegistrationSubmitButton_Click);
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(341, 138);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleradioButton.TabIndex = 19;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(221, 138);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleradioButton.TabIndex = 18;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(37, 138);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 17;
            this.Gender.Text = "Gender";
            // 
            // AgreecheckBox
            // 
            this.AgreecheckBox.AutoSize = true;
            this.AgreecheckBox.Location = new System.Drawing.Point(311, 421);
            this.AgreecheckBox.Name = "AgreecheckBox";
            this.AgreecheckBox.Size = new System.Drawing.Size(54, 17);
            this.AgreecheckBox.TabIndex = 16;
            this.AgreecheckBox.Text = "Agree";
            this.AgreecheckBox.UseVisualStyleBackColor = true;
            this.AgreecheckBox.CheckedChanged += new System.EventHandler(this.AgreecheckBox_CheckedChanged);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(165, 174);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(399, 20);
            this.EmailtextBox.TabIndex = 12;
            // 
            // PhoneNumbertextBox
            // 
            this.PhoneNumbertextBox.Location = new System.Drawing.Point(165, 230);
            this.PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            this.PhoneNumbertextBox.Size = new System.Drawing.Size(399, 20);
            this.PhoneNumbertextBox.TabIndex = 11;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(165, 280);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(399, 20);
            this.AddresstextBox.TabIndex = 8;
            // 
            // AgeLable
            // 
            this.AgeLable.AutoSize = true;
            this.AgeLable.Location = new System.Drawing.Point(37, 343);
            this.AgeLable.Name = "AgeLable";
            this.AgeLable.Size = new System.Drawing.Size(26, 13);
            this.AgeLable.TabIndex = 7;
            this.AgeLable.Text = "Age";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(37, 287);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(37, 233);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(44, 13);
            this.Number.TabIndex = 5;
            this.Number.Text = "Number";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(39, 181);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(153, 85);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(399, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(37, 88);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = " Username";
            // 
            // RegistrationText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 560);
            this.Controls.Add(this.PaitentRegistrationBox);
            this.Name = "RegistrationText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationText_FormClosing);
            this.PaitentRegistrationBox.ResumeLayout(false);
            this.PaitentRegistrationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox PaitentRegistrationBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button RegistrationSubmitButton;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.CheckBox AgreecheckBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhoneNumbertextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label AgeLable;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.RadioButton OtherradioButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

