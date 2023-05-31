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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace text2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonOpen_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
            string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
{
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
}
            richTextBox1.Clear();
        }


      

        private void cuuty_click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void coopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasta_click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void vyr2_click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copy2_click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasta2_click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void clear_click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void clear2_click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.SelectionColor = selectedColor;
                richTextBox1.SelectionLength = 0;
            }

        }

        private void centre_click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        private void pravo_click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void levo_click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void shrift_click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                richTextBox1.SelectionFont = selectedFont;
                richTextBox1.SelectionLength = 0;
            }
        }

        private void otk_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void save_click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox1.Clear();
        }

        private void color2_click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox1.SelectionColor = selectedColor;
                richTextBox1.SelectionLength = 0;
            }
        }

        private void sh2_click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                richTextBox1.SelectionFont = selectedFont;
                richTextBox1.SelectionLength = 0;
            }
        }

        private void vydelit_click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void oproge_click(object sender, EventArgs e)
        {
            AboutBox1 abtbt = new AboutBox1();
            abtbt.ShowDialog();

        }

        private void vyh2_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vyh_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
