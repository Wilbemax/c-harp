namespace PracticalTask16
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(181, 209);
            button1.Name = "button1";
            button1.Size = new Size(450, 165);
            button1.TabIndex = 0;
            button1.Text = "Начало";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(360, 97);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 1;
            button2.Text = "Обновить кнопку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}