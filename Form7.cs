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
    public partial class Form7 : Form
    {
        Form4 frm4;
        Form2 frm2;
        Form7 frm7;
        public Form7()
        {
            InitializeComponent();

        }
        public Form7(Form2 f)
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm4 = new Form4();
            frm4.Owner = this;
            frm4.Show();
            Form2 forma = this.Owner as Form2;

   


        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(false);
            frm2.Owner = this;
            frm2.Show();
           
        }
    }
}
