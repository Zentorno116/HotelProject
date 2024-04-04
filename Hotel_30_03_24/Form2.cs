using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_30_03_24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void textBox1click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNotActive(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ФИО";
            }
            this.ActiveControl = null;
        }

        private void dateofBirthleave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Дата рождения";
            }
            this.ActiveControl = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
            textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
            textBox2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text) <=99 )
            {
                label3.Text = (int.Parse(label3.Text) + 1).ToString();
            }
            else 
            {
                label3.Text = "99";
                MessageBox.Show("Кол-во дней не должно превышать 99");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text) > 1)
            {
                label3.Text = (int.Parse(label3.Text) - 1).ToString();
            }
            else
            {
                label3.Text = "1";
                MessageBox.Show("Кол-во дней не может быть <1");
            }
        }

        
    }
}
