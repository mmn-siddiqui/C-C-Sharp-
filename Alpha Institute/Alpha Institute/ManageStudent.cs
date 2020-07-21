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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaInstituteDataSet1.Student' table. You can move, or remove it, as needed.
            getData();

        }

        void getData()
        {
            this.studentTableAdapter.Fill(this.alphaInstituteDataSet1.Student);
            DataClasses1DataContext db = new DataClasses1DataContext();
            var students = from s in db.Students select s;
            dataGridView1.DataSource = students.ToList();

            listBox1.DataSource = students;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            txtStudentMarks.Text = txtStudentEmail.Text = txtStudentName.Text = txtStudentPhoneNo.Text = "";
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            try { 
            var sv = Convert.ToInt32(listBox1.SelectedValue);
            var selectedStudent = db.Students.First(s => s.Id == sv);

            txtStudentName.Text = selectedStudent.Name;
            txtStudentEmail.Text = selectedStudent.Email;
            txtStudentPhoneNo.Text = Convert.ToString(selectedStudent.PhoneNo);
            txtStudentMarks.Text = Convert.ToString(selectedStudent.Marks);
            }
            catch (Exception ex)
            {

            }

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var sv = Convert.ToInt32(listBox1.SelectedValue);
            var selectedStudent = db.Students.First(s => s.Id == sv);

            selectedStudent.Name = txtStudentName.Text;
            selectedStudent.Email = txtStudentEmail.Text;
            selectedStudent.PhoneNo = Convert.ToInt32(txtStudentPhoneNo.Text);
            selectedStudent.Marks = Convert.ToInt32(txtStudentMarks.Text);

            db.SubmitChanges();
            MessageBox.Show("Student Data Updated Successfully");
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var sv = Convert.ToInt32(comboBox1.SelectedValue);
            var selectedStudent = db.Students.First(s => s.Id == sv);

            db.Students.DeleteOnSubmit(selectedStudent);
            db.SubmitChanges();
            MessageBox.Show("Student Data Deleted Successfully");
            getData();
        }

        private void TabUpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
