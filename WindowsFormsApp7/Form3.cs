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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            Form2 f2 = new Form2();
            f2.Add(a,b);
            
            this.Hide();
            //Form2.spisok.Add(b);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
