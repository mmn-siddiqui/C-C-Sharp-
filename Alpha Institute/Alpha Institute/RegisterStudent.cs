using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Institute
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try { 
            Student stu = new Student()
            {
                Name = txtStudentName.Text,
                Password = Convert.ToInt32(txtStudentPassword.Text),
                Email = txtStudentEmail.Text,
                Education = txtStudentEducation.SelectedItem.ToString(),
                PhoneNo = Convert.ToInt32(txtStudentPhoneNo.Text),
                Marks = 0
            };

            db.Students.InsertOnSubmit(stu);
            db.SubmitChanges();
            
            MessageBox.Show("New Student Has Been Registered Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}