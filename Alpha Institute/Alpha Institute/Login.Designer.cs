namespace Alpha_Institute
{
    partial class Login
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
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.btnFacultyLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterFaculty = new System.Windows.Forms.Button();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.Black;
            this.btnStudentLogin.Location = new System.Drawing.Point(116, 123);
            this.btnStudentLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(192, 35);
            this.btnStudentLogin.TabIndex = 0;
            this.btnStudentLogin.Text = "Login As Student";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // btnFacultyLogin
            // 
            this.btnFacultyLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacultyLogin.ForeColor = System.Drawing.Color.Black;
            this.btnFacultyLogin.Location = new System.Drawing.Point(398, 123);
            this.btnFacultyLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFacultyLogin.Name = "btnFacultyLogin";
            this.btnFacultyLogin.Size = new System.Drawing.Size(197, 35);
            this.btnFacultyLogin.TabIndex = 1;
            this.btnFacultyLogin.Text = "Login As Faculty";
            this.btnFacultyLogin.UseVisualStyleBackColor = true;
            this.btnFacultyLogin.Click += new System.EventHandler(this.btnFacultyLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Want to login as?";
            // 
            // btnRegisterFaculty
            // 
            this.btnRegisterFaculty.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFaculty.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterFaculty.Location = new System.Drawing.Point(398, 276);
            this.btnRegisterFaculty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegisterFaculty.Name = "btnRegisterFaculty";
            this.btnRegisterFaculty.Size = new System.Drawing.Size(197, 35);
            this.btnRegisterFaculty.TabIndex = 4;
            this.btnRegisterFaculty.Text = "Register As Faculty";
            this.btnRegisterFaculty.UseVisualStyleBackColor = true;
            this.btnRegisterFaculty.Click += new System.EventHandler(this.btnRegisterFaculty_Click);
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStudent.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterStudent.Location = new System.Drawing.Point(116, 276);
            this.btnRegisterStudent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(212, 35);
            this.btnRegisterStudent.TabIndex = 3;
            this.btnRegisterStudent.Text = "Register As Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t have any account?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(743, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegisterFaculty);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacultyLogin);
            this.Controls.Add(this.btnStudentLogin);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Button btnFacultyLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisterFaculty;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Label label2;
    }
}

