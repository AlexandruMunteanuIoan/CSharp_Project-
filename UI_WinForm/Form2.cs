using LibrarieModele;
using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForm
{
    public partial class Form2 : Form
    {
        int screenWidth;
        int screenHeight;
        int formWidth;
        int formHeight;
        public Form2()
        {
            InitializeComponent();

            this.screenWidth = Screen.PrimaryScreen.Bounds.Width;
            this.screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.formWidth = (int)(screenWidth * 0.8);
            this.formHeight = (int)(screenHeight * 0.8);

            this.Size = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            label1.Text = "Select number of questions (5-35):";
            label1.Font = new Font(label1.Font.FontFamily, 35);
            textBox1.Font = new Font(textBox1.Font.FontFamily, 20);

            textBox1.Size = new Size(500, 50);

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            this.Location = new Point(centerX, centerY);

            button1.Size = new Size(150, 40);
            button1.Font = new Font(button1.Font.FontFamily, 16);

            label1.Left = (formWidth - label1.Width) / 2 - 8;
            textBox1.Left = (formWidth - textBox1.Width) / 2 - 8;
            button1.Left = (formWidth - button1.Width) / 2 - 8;

            label1.Top = formHeight / 2 - label1.Height - 40;
            textBox1.Top = formHeight / 2 ;
            button1.Top = formHeight / 2 + 40;


            label1.TextAlign = ContentAlignment.MiddleCenter;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            if (int.TryParse(textBox1.Text, out n))
            {
                if (n < 5 || n > 35)
                {
                    label1.Text = "Error!!!! Please enter a valid number (5 - 35).";
                    label1.Left = ((int)(screenWidth * 0.8) - label1.Width) / 2;
                }
                else
                {
                    Form3 form3 = new Form3(n);
                    form3.Show();
                    this.Hide();
                }
            }

        }
    }
}
