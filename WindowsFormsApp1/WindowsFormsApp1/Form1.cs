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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(textBox1.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.GetFiles(textBox1.Text).Length != 0 || Directory.GetDirectories(textBox1.Text).Length != 0)
                {

                    if (MessageBox.Show("Klasör dolu silmek istediğinize emin misiniz?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {

                        MessageBox.Show("Klasör silme işlemi başarılı!", "Silme İşlemi Gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Klasör silme işlemi başraısız.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Directory.Delete(textBox1.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(textBox1.Text))
                {
                    MessageBox.Show("Vardır!");

                }
                else
                {
                    MessageBox.Show("Yoktur!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string[] klasorler = Directory.GetDirectories(textBox1.Text);
                listBox1.Items.AddRange(klasorler);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                // listBox2.Items.AddRange(Directory.GetFiles(listBox1.SelectedItem.ToString()));
                string[] dosyalar = Directory.GetFiles(textBox1.Text);
                listBox2.Items.AddRange(dosyalar);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
                
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                string[] klasorler = Directory.GetDirectories(textBox1.Text);
                listBox1.Items.AddRange(klasorler);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
                
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Directory.GetLogicalDrives());
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
               
            }


        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Move(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
               
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }
    }
}
