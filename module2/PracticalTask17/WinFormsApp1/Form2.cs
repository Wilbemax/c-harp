using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text; // Текст для поиска

            

            // Вызываем метод поиска в основной форме
            var mainForm = Application.OpenForms["Form1"] as Form1; // Получаем ссылку на основную форму
            mainForm?.FindAndHighlightText(searchText);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            //this.Close();

        }
        public string SearchText
        {
            get => textBox1.Text; 
            set => textBox1.Text = value; 
        }
        public string ReplaceText
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
