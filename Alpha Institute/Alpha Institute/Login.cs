using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha_Institute
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            LoginStudent ls = new LoginStudent();
            ls.Show();
            this.Hide();
        }

        private void btnFacultyLogin_Click(object sender, EventArgs e)
        {
            LoginFaculty lf = new LoginFaculty();
            lf.Show();
            this.Hide();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            RegisterStudent rs = new RegisterStudent();
            rs.Show();
            this.Hide();
        }

        private void btnRegisterFaculty_Click(object sender, EventArgs e)
        {
            RegisterFaculty rf = new RegisterFaculty();
            rf.Show();
            this.Hide();
        }
    }
}
