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
    public partial class Form3 : Form
    {
        public Form3(Form2 form2)
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 forma = this.Owner as Form2;
            listBox1.DataSource = File.ReadAllLines(@"dict.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            Form2 forma = this.Owner as Form2;
            string word = listBox1.SelectedItem.ToString();

            char[] vowels = new char[] { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            char[] array = word.ToLower().ToCharArray();

            foreach (char ch in array)  { 
                foreach (char cha in vowels) { 
                    if (ch == cha)
                    {
                        check = false;

                    }
       
                        } 
                }    
                if (!check)
                    {
                        var words = word.Split('	');
                        forma.textBox1.Text = words[1];
                        this.Close();
                    }
            if (check)
            {   
                MessageBox.Show("Это слово состоит из согласных!");
                File.WriteAllText("dict.txt", File.ReadAllText("dict.txt").Replace(word, null));
                listBox1.DataSource = File.ReadAllLines(@"dict.txt");
                
            }
            
            var lines = File.ReadAllLines(@"dict.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"dict.txt", lines);
            listBox1.DataSource = File.ReadAllLines(@"dict.txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool checking = true;

            Form2 forma = this.Owner as Form2;
            Random rand = new Random();
            char[] vowels = new char[] { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я' };


            string word = "";

            while (checking)
            {
            int id = rand.Next(listBox1.Items.Count);
            word = listBox1.Items[id].ToString();

                foreach (char ch in word)
                 {
                foreach (char cha in vowels)
                 {
                        if (ch == cha)
                        {
                            checking = false;
                        }
                }
                }
            }
            var words = word.Split('	');
            forma.textBox1.Text = words[1];
            this.Close();
            checking = false;

        }
    }
}