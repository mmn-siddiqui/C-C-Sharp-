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
    public partial class LoginFaculty : Form
    {
        public LoginFaculty()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string Name = txtFacultyName.Text;
            string Password = txtFacultyPassword.Text;

            if (Name == "")
                errorProvider1.SetError(txtFacultyName, "Name is missing");
            else if (Password == "")
                errorProvider1.SetError(txtFacultyPassword, "Password is missing");

            else
            {
                var con = new SqlConnection("Data Source=DESKTOP-1OAGRHR;Initial Catalog=AlphaInstitute;Integrated Security=True");
                var com = con.CreateCommand();
                com.CommandText = "Select * from Faculty where Name='" + Name + "' And Password='" + Password + "'";

                con.Open();

                SqlDataReader reader = com.ExecuteReader();

                ManageStudent ms = new ManageStudent();
                ms.Show();
                this.Hide();

                con.Close();

            }
        }
    }
}
