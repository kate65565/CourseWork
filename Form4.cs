using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CourseWorkSlovo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form2 frm2;


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length > 0 )
            {
                string s = textBox1.Text;
                System.IO.StreamWriter writer = new System.IO.StreamWriter("история.txt", true);
                writer.WriteLine("Игрок - " + s + ", количество попыток: 8");
                writer.Close();

                frm2 = new Form2(true);
                frm2.Owner = this;
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Введите имя!");
            }

        }
    }
    }

