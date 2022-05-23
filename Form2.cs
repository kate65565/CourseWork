using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using CourseWorkSlovo.Properties;

namespace CourseWorkSlovo
{
    public partial class Form2 : Form
    {
        string a = "";
        string s = ""; 
        int count = 0;
        int sum = 0;

        bool newStart;


        public Form2(bool newStart )
        {
    
            InitializeComponent();
            this.newStart = newStart;
            this.Text = "Игра в слова";
            textBox1.Text = Properties.Settings.Default.ButName;
            textBox2.Text = Properties.Settings.Default.textBox;
            textBox3.Text = Properties.Settings.Default.ZagSl;
            textBox4.Text = (9 - Properties.Settings.Default.kolvo).ToString();
            a = Properties.Settings.Default.kkk;
            s = Properties.Settings.Default.se;
            count = Properties.Settings.Default.kolvo;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            s = s.ToLower();
            char[] word = new char[30];
            word = s.ToCharArray();
            MessageBox.Show("Игра началась!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            a = "";
            count = 0;
            sum = 0;
            pictureBox1.Image = null;   

            if (word.Length != 0 & word.Length > 2)
                {
                    textBox3.Text += s[0].ToString();
                    for (int i = 1; i < s.Length - 1; i++)
                    {
                        textBox3.Text += '-'.ToString();

                    }
                    textBox3.Text += s[s.Length - 1];
                    a = textBox3.Text;

            }
            else
            {
                MessageBox.Show("Введите слово более, чем из двух букв");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string symb = textBox2.Text;
            symb = symb.ToLower();
            char[] text2 = new char[a.Length];
            
            for (int i = 0; i < a.Length; i++)
            {
                text2[i] = a[i];
            }
            bool countFlag = false;
            if (textBox2.Text.Length == 1) // Для одной буквы
            {
                for (int i = 1; i < a.Length-1; i++)
                {
                    if (symb[0] == s[i])
                    {   
                        text2[i] = s[i];
                        sum++;
                        countFlag = true;
                    }
                    
                }     
                if(!countFlag)
                {
                    count += 1;

                }
            }


            textBox4.Text = (9 - count).ToString();
            string[] strS = File.ReadAllLines("история.txt");

            string phrase = strS[strS.Length - 1];
            string[] w = phrase.Split(':');
            strS[strS.Length - 1] = w[0] + ": " + (9 - count).ToString();

            File.WriteAllLines("история.txt", strS);

            if (count == 1)
            {
                pictureBox1.Load("1.jpg");
            }
            if (count == 2)
            {
                pictureBox1.Load("2.jpg");
            }
            if (count == 3)
            {
                pictureBox1.Load("3.jpg");
            }
            if (count == 4)
            {
                pictureBox1.Load("4.jpg");
            }
            if (count == 5)
            {
                pictureBox1.Load("5.jpg");
            }
            if (count == 6)
            {
                pictureBox1.Load("6.jpg");
            }
            if (count == 7)
            {
                pictureBox1.Load("7.jpg");
            }
            if (count == 8)
            {
                pictureBox1.Load("8.jpg");
            }
            if (count == 9)
            {
                pictureBox1.Load("9.jpg");
            }
            else if (textBox2.Text.Length >1)
            {
                MessageBox.Show("Введите 1 букву");
            }
                string c = new string(text2);
                textBox3.Text = c;
                a = textBox3.Text;
                if (sum == s.Length - 2)
                {
                    MessageBox.Show("Вы выиграли! :)");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                a = "";
                s = "";
                count = 0;
                sum = 0;

                MessageBox.Show("Игра окончена. Загадайте новое слово!");
                pictureBox1.Image = null;

            }
            if (count == 9)
            {
                MessageBox.Show("Вы проиграли! :(");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                a = "";
                s = "";
                count = 0;
                sum = 0;

                MessageBox.Show("Игра окончена. Загадайте новое слово!");    
                pictureBox1.Image = null; 
            }
        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (newStart)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                count = 0;
                a = "";
                s = "";
                
            }
            else
            {
                if (count == 1)
                {
                    pictureBox1.Load("1.jpg");
                }
                if (count == 2)
                {
                    pictureBox1.Load("2.jpg");
                }
                if (count == 3)
                {
                    pictureBox1.Load("3.jpg");
                }
                if (count == 4)
                {
                    pictureBox1.Load("4.jpg");
                }
                if (count == 5)
                {
                    pictureBox1.Load("5.jpg");
                }
                if (count == 6)
                {
                    pictureBox1.Load("6.jpg");
                }
                if (count == 7)
                {
                    pictureBox1.Load("7.jpg");
                }
                if (count == 8)
                {
                    pictureBox1.Load("8.jpg");
                }
                if (count == 9)
                {
                    pictureBox1.Load("9.jpg");
                }
            }           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           

        }

        private void выборДляЗагадываемогоСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form3 newForm = new Form3(this);
            newForm.Owner = this;
            newForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Owner = this;

            var path = @"dict.txt"; // Путь к произвольному текстовому файлу
            var myList = File.ReadAllLines(path);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1003;
            foreach (var item in myList)
            {
                progressBar1.Increment(+5);
               
            }
            
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void рандомноЗагадатьСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 forma3 = this.Owner as Form3;

            forma3.listBox1.DataSource = File.ReadAllLines(@"dict.txt");

            Random random = new Random();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false )
            {
                e.Handled = true;
              
            }
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            { 
                e.Handled = false;
            }
                
      
           
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;

            }
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.ButName = textBox1.Text;
            Properties.Settings.Default.textBox = textBox2.Text;
            Properties.Settings.Default.ZagSl = textBox3.Text;
            Properties.Settings.Default.kolvo =count;
            
            Properties.Settings.Default.se = s;
            Properties.Settings.Default.kkk = a;

            Properties.Settings.Default.Save();

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }


