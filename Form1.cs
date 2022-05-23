using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSlovo
{
    public partial class Form1 : Form
    {   
        Form7 frm7;
        Form5 frm5;
        public string userName = "";
        public Form1()
        {

            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            frm7 = new Form7();
            frm7.Owner = this;
            frm7.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("ddd dd MMMM yyyy HH:mm:ss");
           
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
   
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
            try
            {
                frm5 = new Form5();
                frm5.Show();

            }
            catch 
            {
                MessageBox.Show("Нет истории");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
