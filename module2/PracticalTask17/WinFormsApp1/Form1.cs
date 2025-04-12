using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int findIndex = 0;
        private string findText = string.Empty; 
        private string replaceText = string.Empty;

        private void OnLoad(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

            label1.Text = "Количество слов в тексте:" + 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            try
            {
                var reader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding("UTF-8"));
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (System.IO.FileNotFoundException Situation)
            {
                MessageBox.Show(Situation.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.SafeFileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var writen = new System.IO.StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding("UTF-8"));
                    writen.Write(richTextBox1.Text);
                    writen.Close();
                }
                catch (Exception Situation)
                {
                    MessageBox.Show(Situation.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            Clipboard.SetText(text);
            MessageBox.Show("Text has been coppied");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            Clipboard.SetText(text);
            richTextBox1.Text = "";
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowHelp = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog.Font;
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] words = richTextBox1.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            label1.Text = "Количество слов в тексте:" + words.Length;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var replaceDiolog = new Form2())
            {
                replaceDiolog.SearchText = findText;
                replaceDiolog.ReplaceText = replaceText;
                replaceDiolog.Show();

                //if (result == DialogResult.Cancel)
                //{
                //    return;
                //}
                findText = replaceDiolog.SearchText;
                replaceText = replaceDiolog.ReplaceText;


                if (string.IsNullOrEmpty(findText))
                {
                    MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
            }
        }

        public void FindAndHighlightText(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ищем текст без учета регистра
            int index = richTextBox1.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

            if (index != -1)
            {
                // Выделяем найденный текст
                richTextBox1.Select(index, searchText.Length);
                richTextBox1.ScrollToCaret();

                // Обновляем позицию для следующего поиска
                findIndex = index + searchText.Length;

                // Если достигнут конец текста, сбрасываем позицию на начало
                if (findIndex >= richTextBox1.TextLength)
                {
                    findIndex = 0;
                }
            }
            else
            {
                // Если текст не найден, сбрасываем позицию на начало
                findIndex = 0;
                MessageBox.Show("Текст не найден.", "Поиск завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReplaceTextInRichTextBox(string searchText, string replaceText)
        {
            int index = richTextBox1.Find(searchText, 0, RichTextBoxFinds.None);
            if (index != -1)
            {
                richTextBox1.SelectedText = replaceText;
                findIndex = index - 1;

                richTextBox1.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Текст не найден.", "Поиск завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
