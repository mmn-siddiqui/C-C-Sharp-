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
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaInstituteDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.alphaInstituteDataSet.Student);
            DataClasses1DataContext db = new DataClasses1DataContext();
            var students = from s in db.Students select s;
            dataGridView1.DataSource = students.ToList();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
            
        }
    }
}
