using LibrarieModele;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NivelStocareDate;

namespace UI_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = (int)(screenWidth * 0.8); 
            int formHeight = (int)(screenHeight * 0.8); 
            this.Size = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            label1.Text = "Welcome";
            label1.Font = new Font(label1.Font.FontFamily, 56);
            button1.Font = new Font(button1.Font.FontFamily, 20);

            label1.Size = new Size(150, 80); 
            button1.Size = new Size(100, 50);

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            this.Location = new Point(centerX, centerY);

            label1.Left = (formWidth - label1.Width) / 2 - 8;
            button1.Left = (formWidth - button1.Width) / 2 - 8;

            label1.Top = formHeight / 2 - label1.Height - 20;
            button1.Top = formHeight / 2 + 20;

            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
