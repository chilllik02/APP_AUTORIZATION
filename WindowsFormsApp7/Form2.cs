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
    public partial class Form2 : Form
    {
        public static Dictionary<string,string>spisok; // обьявляем в классе (Form2)
        public Form2()
        {
            InitializeComponent();
            spisok = new Dictionary<string,string>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public  void Add(string a,string b)
        {
            spisok.Add(a,b);
        }
        public void update()
        {
            
            foreach(KeyValuePair<string, string> s in spisok)
            {
                listBox1.Items.Add($"{s.Key} {s.Value}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
