using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWorkSlovo.Properties;
using System.Drawing.Printing;


namespace CourseWorkSlovo
{
    public partial class Form5 : Form
    {   

     
        public Form5()
        {

            InitializeComponent();
       
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        
            this.LoadSettings();
  
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void LoadSettings()
        {
            textBox1.Text = System.IO.File.ReadAllText("история.txt ");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            var b = System.IO.File.ReadAllText("история.txt ");
            e.Graphics.DrawString(b, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
     