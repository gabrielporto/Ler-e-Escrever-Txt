using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using System.IO;

namespace LerTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "c:\\test.txt";
            textBox1.Clear();

            string[] linesW = { "First line 11", "Second line 22", "Third line 33" };

            File.WriteAllLines(path, linesW);

            string[] linesR = File.ReadAllLines(path);

            for (int i = 0; i < linesR.Length; i++)
            {
                textBox1.Text += "\r\n" + linesR[i];
            }


            StreamReader sr = new StreamReader(path);
            string texto = sr.ReadToEnd();
            sr.Close();

            StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine(linesW);
            sw.WriteLine(texto);

            sw.Close();



        }
    }
}
