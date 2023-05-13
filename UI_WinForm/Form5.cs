using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForm
{
    public partial class Form5 : Form
    {
        private CitireScriereFisier citireScriereFisier;

        public Form5()
        {
            InitializeComponent();

            string numeFisier = "questions.txt";
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            citireScriereFisier = new CitireScriereFisier(caleCompletaFisier);

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = (int)(screenWidth * 0.8);
            int formHeight = (int)(screenHeight * 0.8);
            this.Size = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label label6 = new Label();
            label6.Text = "Add question";
            label6.ForeColor = Color.White;
            label6.AutoSize = true;
            label6.Font = new Font(label6.Font.FontFamily, 24);

            label1.Text = "Question:";
            label1.Font = new Font(label1.Font.FontFamily, 14);

            radioButton1.Font = new Font(radioButton1.Font.FontFamily, 12);
            radioButton2.Font = new Font(radioButton2.Font.FontFamily, 12);
            radioButton3.Font = new Font(radioButton3.Font.FontFamily, 12);
            radioButton4.Font = new Font(radioButton4.Font.FontFamily, 12);

            textBox1.Font = new Font(textBox1.Font.FontFamily, 14);
            textBox1.Size = new Size(500, 30);

            textBox2.Font = new Font(textBox2.Font.FontFamily, 12);
            textBox2.Size = new Size(500, 20);

            textBox3.Font = new Font(textBox3.Font.FontFamily, 12);
            textBox3.Size = new Size(500, 20);

            textBox4.Font = new Font(textBox4.Font.FontFamily, 12);
            textBox4.Size = new Size(500, 20);

            textBox5.Font = new Font(textBox5.Font.FontFamily, 12);
            textBox5.Size = new Size(500, 20);

            int centerX = formWidth / 2;
            int centerY = formHeight / 3;

            int labelX = centerX - (label1.Width + textBox1.Width + 10) / 2;
            int textBoxX = labelX + label1.Width;

            label6.Location = new Point(centerX - label6.Width / 2, centerY - label6.Height * 3);

            label1.Location = new Point(labelX-5, centerY);
            textBox1.Location = new Point(textBoxX, centerY);

            centerY += label1.Height + 20;

            radioButton1.Location = new Point(labelX-5, centerY);
            textBox2.Location = new Point(textBoxX, centerY);

            centerY += radioButton1.Height + 20;

            radioButton2.Location = new Point(labelX-5, centerY);
            textBox3.Location = new Point(textBoxX, centerY);

            centerY += radioButton2.Height + 20;

            radioButton3.Location = new Point(labelX-5, centerY);
            textBox4.Location = new Point(textBoxX, centerY);

            centerY += radioButton3.Height + 20;

            radioButton4.Location = new Point(labelX - 5, centerY);
            textBox5.Location = new Point(textBoxX, centerY);

            centerY += radioButton4.Height + 20;

            button1.Location = new Point(textBoxX, centerY);

            centerY += button1.Height + 20;

            button2.Location = new Point(formWidth - 150, formHeight - 100);

            this.Controls.Add(label6);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string intrebare = textBox1.Text;
            List<string> varianteRaspuns = new List<string>
            {
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text
            };

            int indexRaspunsCorect = -1;

            if (radioButton1.Checked)
                indexRaspunsCorect = 0;
            else if (radioButton2.Checked)
                indexRaspunsCorect = 1;
            else if (radioButton3.Checked)
                indexRaspunsCorect = 2;
            else if (radioButton4.Checked)
                indexRaspunsCorect = 3;

            if (indexRaspunsCorect == -1)
            {
                MessageBox.Show("Selectați răspunsul corect.");
                return;
            }

            citireScriereFisier.AdaugareIntrebare(intrebare, varianteRaspuns, indexRaspunsCorect);

            MessageBox.Show("Întrebare adăugată");

            ResetFields();
        }

        private void ResetFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
