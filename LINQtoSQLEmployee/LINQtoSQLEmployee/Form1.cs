using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQLEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext dx = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = textBox1.Text,
                Department=comboBox1.Text,
                joiningDate=dateTimePicker1.Value
            };
            dx.Employees.InsertOnSubmit(emp);
            dx.SubmitChanges();
            MessageBox.Show("Data Has Been Inserted!");
            getData();
        }
        void getData()
        {
            var query = from v in dx.Employees select v;
            dataGridView1.DataSource = query;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDemoDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDemoDataSet.Employee);
            getData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var st = (from s in dx.Employees where s.Id == int.Parse(textBox2.Text) select s).First();
                textBox1.Text = st.Name;
                comboBox1.Text = st.Department;
                dateTimePicker1.Value = st.joiningDate;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var st = (from s in dx.Employees where s.Id == int.Parse(textBox2.Text) select s).First();
            st.Name = textBox1.Text;
            st.Department = comboBox1.Text;
            st.joiningDate = dateTimePicker1.Value;

            dx.SubmitChanges();
            MessageBox.Show("Record updated!");
            getData();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var st = (from s in dx.Employees where s.Id == int.Parse(textBox2.Text) select s).First();

            dx.Employees.DeleteOnSubmit(st);
            dx.SubmitChanges();
            MessageBox.Show("Record Deleted");
            getData();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            var st = from s in dx.Employees select s;
            dx.Employees.DeleteAllOnSubmit(st);
            dx.SubmitChanges();
            MessageBox.Show("Record Deleted");
            getData();
        }
    }
}
