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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter yazıcı = File.CreateText(openFileDialog1.FileName);
                yazıcı.WriteLine(richTextBox1.Text);
                yazıcı.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter yazıcı = File.AppendText(saveFileDialog1.FileName);
                yazıcı.WriteLine(richTextBox1.Text);
                yazıcı.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                TextReader okuyucu = File.OpenText(openFileDialog1.FileName);

                string satir = okuyucu.ReadLine();
                while (satir != null)
                {
                    richTextBox1.Text += satir + "\n";
                    satir = okuyucu.ReadLine();
                }



                okuyucu.Close();
            }
        }
    }
}
