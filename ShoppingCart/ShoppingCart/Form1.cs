using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int amount = 0;
        int quantity; 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = comboBox1.SelectedItem.ToString();
            pictureBox1.Image = new Bitmap(s);
            listBox1.Items.Clear();

            if (comboBox1.Text == @"D:\Mubashir\ShoppingCart\imgs\3.jpg")
            {
                listBox1.Items.Add("Supreme : Rs 1200");
            }
            else if (comboBox1.Text == @"D:\Mubashir\ShoppingCart\imgs\1.jpg")
            { 
                listBox1.Items.Add("Adidas : Rs 7800");
            }
            else if (comboBox1.Text == @"D:\Mubashir\ShoppingCart\imgs\2.jpg")
            {
                listBox1.Items.Add("Puma : Rs 1200");
               
            }
            else if (comboBox1.Text == @"D:\Mubashir\ShoppingCart\imgs\4.jpg")
            {
                listBox1.Items.Add("Zara Man : Rs 12000");
               
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem.ToString() == "Supreme : Rs 1200")
            {

                quantity = Convert.ToInt32(numericUpDown1.Value);
                amount += 1200 * quantity;
                textBox1.Text = Convert.ToString(amount);

            }
            /* else if(listBox1.SelectedItem.ToString() == "Superman : Rs 1000")
             {
                 quantity = Convert.ToInt32(numericUpDown1.Value);
                 amount += 1000 * quantity;
                 lblAmount.Text = Convert.ToString(amount);
             }
             else if (listBox1.SelectedItem.ToString() == "Levis : Rs 5000")
             {
                 quantity = Convert.ToInt32(numericUpDown1.Value);
                 amount += 5000 * quantity;
                 lblAmount.Text = Convert.ToString(amount);
             }*/
            /* else if (listBox1.SelectedItem.ToString() == "Outfitters: Rs 4000")
             {
                 quantity = Convert.ToInt32(numericUpDown1.Value);
                 amount += 4000 * quantity;
                 lblAmount.Text = Convert.ToString(amount);
             }
             else if (listBox1.SelectedItem.ToString() == "Nike : Rs 8000")
             {
                 quantity = Convert.ToInt32(numericUpDown1.Value);
                 amount += 8000 * quantity;
                 lblAmount.Text = Convert.ToString(amount);
             }*/
            else if (listBox1.SelectedItem.ToString() == "Adidas : Rs 7800")
            {
                quantity = Convert.ToInt32(numericUpDown1.Value);
                amount += 7800 * quantity;
                textBox1.Text = Convert.ToString(amount);
            }
            else if (listBox1.SelectedItem.ToString() == "Puma : Rs 1200")
            {
                
                 quantity = Convert.ToInt32(numericUpDown1.Value);
                 amount += 1200 * quantity;
                 textBox1.Text = Convert.ToString(amount);
            }
           /* else if (listBox1.SelectedItem.ToString() == "Adidas : Rs 1400")
            {
                quantity = Convert.ToInt32(numericUpDown1.Value);
                amount += 1400 * quantity;
                label5.Text = Convert.ToString(amount);
            }*/
            else if (listBox1.SelectedItem.ToString() == "Zara Man : Rs 12000")
            {
               
                quantity = Convert.ToInt32(numericUpDown1.Value);
                amount += 12000 * quantity;
                textBox1.Text = Convert.ToString(amount);
            }
           /* else if (listBox1.SelectedItem.ToString() == "Outfitters : Rs 9000")
            {
                quantity = Convert.ToInt32(numericUpDown1.Value);
                amount += 9000 * quantity;
                lblAmount.Text = Convert.ToString(amount);
            }*/
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been placed");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            string[] imgs = Directory.GetFiles(@"D:\Mubashir\ShoppingCart\imgs");
            foreach (string file in imgs)
            {
                comboBox1.Text = "Select Data";
                comboBox1.Items.Add(file);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            amount = 0;
        }
    }

}