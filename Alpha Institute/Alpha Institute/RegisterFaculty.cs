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
    public partial class RegisterFaculty : Form
    {
        public RegisterFaculty()
        {
            InitializeComponent();
        }

        private void btnRegisterFaculty_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try { 
                Faculty fac = new Faculty()
                {
                    Name = txtFacultyName.Text,
                    Password = Convert.ToInt32(txtFacultyPassword.Text),
                    Email = txtFacultyEmail.Text,
                    Education = txtFacultyEducation.SelectedItem.ToString(),
                    PhoneNo = Convert.ToInt32(txtFacultyPhoneNo.Text),
                    Specialization = txtFacultySpec.SelectedItem.ToString()
            };

                db.Faculties.InsertOnSubmit(fac);
                db.SubmitChanges();

                MessageBox.Show("New Faculty Has Been Registered Successfully!");
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
