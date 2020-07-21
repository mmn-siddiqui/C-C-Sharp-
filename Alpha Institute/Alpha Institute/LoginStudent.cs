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
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string Name = txtStudentName.Text;
            string Password = txtStudentPassword.Text;

            if (Name == "")
                errorProvider1.SetError(txtStudentName, "Name is missing");
            else if (Password == "")
                errorProvider1.SetError(txtStudentPassword, "Password is missing");

            else
            {
                var con = new SqlConnection("Data Source=DESKTOP-1OAGRHR;Initial Catalog=AlphaInstitute;Integrated Security=True");
                var com = con.CreateCommand();
                com.CommandText = "Select * from Student where Name='" + Name + "' And Password='" + Password + "'";

                con.Open();

                SqlDataReader reader = com.ExecuteReader();
               
                StudentRecord sr = new StudentRecord();
                sr.Show();
                this.Hide();

                con.Close();

            }
        }
    }
}
