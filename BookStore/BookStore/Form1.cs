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

namespace BookStore
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-1OAGRHR;Initial Catalog=EMS;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.BookDetail' table. You can move, or remove it, as needed.
            this.bookDetailTableAdapter.Fill(this.eMSDataSet.BookDetail);
            LoadDatafromDB();
        }

        private void LoadDatafromDB()
        {
            string query = "Select * from BookDetail";
            conn.Open();
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "BookDetail");
            dataGridView1.DataSource = ds.Tables["BookDetail"];
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["BookDetail"].NewRow();
            row["booktitle"] = textBox1.Text;
            row["language"] = textBox2.Text;
            row["author"] = textBox3.Text;
            row["pages"] = Convert.ToInt32(textBox4.Text);
            row["price"] = Convert.ToDouble(textBox5.Text);

            ds.Tables["BookDetail"].Rows.Add(row);

            builder = new SqlCommandBuilder(da);
            da.Update(ds, "BookDetail");
            LoadDatafromDB();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            DataColumn [] keycol = new DataColumn[1];
            keycol[0] = ds.Tables["BookDetail"].Columns["Id"];
            ds.Tables["BookDetail"].PrimaryKey = keycol;
            DataRow updaterow = ds.Tables["BookDetail"].Rows.Find(Convert.ToInt32(dr.Cells[0].Value));
            updaterow["booktitle"] = textBox1.Text;
            updaterow["language"] = textBox2.Text;
            updaterow["author"] = textBox3.Text;
            updaterow["pages"] = Convert.ToInt32(textBox4.Text);
            updaterow["price"] = Convert.ToDouble(textBox5.Text);
            builder = new SqlCommandBuilder(da);
            da.Update(ds, "BookDetail");
            LoadDatafromDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            DataColumn[] keycol = new DataColumn[1];
            keycol[0] = ds.Tables["BookDetail"].Columns["Id"];
            ds.Tables["BookDetail"].PrimaryKey =  keycol;
            DataRow delrow = ds.Tables["BookDetail"].Rows.Find(Convert.ToInt32(dr.Cells[0].Value));
            delrow.Delete();
            builder = new SqlCommandBuilder(da);
            da.Update(ds, "BookDetail");
            LoadDatafromDB();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
