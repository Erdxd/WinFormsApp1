using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        OpenFileDialog f;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Завершите регистрацию", "Ошибка");
            }
            else
            {
                Class1.имя = textBox1.Text;
                Class1.фамилия = textBox2.Text;
                Class1.пароль = textBox3.Text;
                Class1.юзер = textBox4.Text;
                this.Close();
            }









        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f = new OpenFileDialog();
            f.Filter = "|*.JPG, *.PNG| All files (*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = new Bitmap(f.FileName);


        }
    }
}
