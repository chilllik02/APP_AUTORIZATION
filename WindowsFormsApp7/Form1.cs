using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        string logtrue = "12345";
        string passwtrue = "12345";
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            Form2 form = new Form2();
            
            if(a == logtrue &&  b == passwtrue)
            {
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный! Введите еще раз...");
            }

            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
