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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Здравствуйте!";
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.Violet;
            label1.Text = "Начать работу";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "До свидания!";
        }
    }
}
