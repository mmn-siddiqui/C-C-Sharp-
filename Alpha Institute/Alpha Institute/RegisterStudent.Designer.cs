namespace Alpha_Institute
{
    partial class RegisterStudent
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
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.txtStudentEducation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegisterStudent.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterStudent.Location = new System.Drawing.Point(357, 334);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(187, 39);
            this.btnRegisterStudent.TabIndex = 17;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentPassword.Location = new System.Drawing.Point(178, 148);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.PasswordChar = '*';
            this.txtStudentPassword.Size = new System.Drawing.Size(181, 27);
            this.txtStudentPassword.TabIndex = 16;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentName.Location = new System.Drawing.Point(178, 103);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(181, 27);
            this.txtStudentName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Register Student";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentEmail.Location = new System.Drawing.Point(178, 190);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(181, 27);
            this.txtStudentEmail.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Education";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(40, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "PhoneNo.";
            // 
            // txtStudentPhoneNo
            // 
            this.txtStudentPhoneNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentPhoneNo.Location = new System.Drawing.Point(178, 288);
            this.txtStudentPhoneNo.Mask = "9999 0000000";
            this.txtStudentPhoneNo.Name = "txtStudentPhoneNo";
            this.txtStudentPhoneNo.Size = new System.Drawing.Size(181, 27);
            this.txtStudentPhoneNo.TabIndex = 23;
            // 
            // txtStudentEducation
            // 
            this.txtStudentEducation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentEducation.FormattingEnabled = true;
            this.txtStudentEducation.Items.AddRange(new object[] {
            "Matric",
            "Intermediate",
            "Bachelors"});
            this.txtStudentEducation.Location = new System.Drawing.Point(178, 243);
            this.txtStudentEducation.Name = "txtStudentEducation";
            this.txtStudentEducation.Size = new System.Drawing.Size(181, 28);
            this.txtStudentEducation.TabIndex = 24;
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(552, 385);
            this.Controls.Add(this.txtStudentEducation);
            this.Controls.Add(this.txtStudentPhoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.txtStudentPassword);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegisterStudent";
            this.Text = "RegisterStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtStudentPhoneNo;
        private System.Windows.Forms.ComboBox txtStudentEducation;
    }
}