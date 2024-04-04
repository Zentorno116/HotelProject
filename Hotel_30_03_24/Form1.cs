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
using NLog;
using NLog.Config;



namespace Hotel_30_03_24
{
    public partial class Form1 : Form
    {
        
        string[,] people = new string[100, 6];
        int peopleCount;
        string checked_category;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            checked_category = radioButton1.Text;
            using (StreamReader sr = new StreamReader("Super encrypted database.txt"))
            {
                string line;
                int i = 0;
                int j = 0;
                while ((line = sr.ReadLine()) != "end")
                {
                    if (j == 6)
                    {
                        j = 0;
                        i++;
                        continue;
                    }
                    people[i, j] = line;
                    j++;
                }
                peopleCount = i + 1;

                
            }



        }
        public void textBox1click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox1.ForeColor = Color.Black;
        }
        private void textBoxNotActive(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Поиск";
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            this.ActiveControl = null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = listBox1.SelectedItem.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void ShowTime(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fio = listBox2.SelectedItem.ToString();
            label4.Text = fio;
            for (int i = 0; i < peopleCount; i++)
            {
                if (people[i, 3] == fio)
                {
                    label13.Text = people[i, 0];
                    pictureBox1.Image = Image.FromFile(people[i, 1]);
                    label5.Text = people[i, 2];
                    label9.Text = people[i, 4];
                    label10.Text = people[i, 5];
                    break;
                }
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
                return;
            checked_category = radioButton1.Text;
            listBox2.Items.Clear();
            for (int i = 0; i < peopleCount; i++)
            {
                string fio = people[i, 3];
                if (people[i, 2] == radioButton1.Text)
                {
                    listBox2.Items.Add(fio);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
                return;
            checked_category = radioButton2.Text;
            listBox2.Items.Clear();
            for (int i = 0; i < peopleCount; i++)
            {
                string fio = people[i, 3];
                if (people[i, 2] == radioButton2.Text)
                {
                    listBox2.Items.Add(fio);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton3.Checked)
                return;
            checked_category = radioButton3.Text;
            listBox2.Items.Clear();
            for (int i = 0; i < peopleCount; i++)
            {
                string fio = people[i, 3];
                if (people[i, 2] == radioButton3.Text)
                {
                    listBox2.Items.Add(fio);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked)
                return;
            checked_category = radioButton4.Text;
            listBox2.Items.Clear();
            for (int i = 0; i < peopleCount; i++)
            {
                string fio = people[i, 3];
                if (people[i, 2] == radioButton4.Text)
                {
                    listBox2.Items.Add(fio);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchKeyPress(object sender, KeyPressEventArgs e)
        {
            string substring = textBox1.Text;
            listBox2.Items.Clear();
            for (int i = 0; i < peopleCount; i++)
            {
                string fio = people[i, 3];
                if (fio.Contains(substring) && people[i, 2] == checked_category)
                {
                    listBox2.Items.Add(fio);
                }
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
