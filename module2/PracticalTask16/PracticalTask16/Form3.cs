using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTask16
{
    public partial class Form3 : Form
    {
        string fieled = "Начальный текст";
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = fieled;
        }
    }
}
