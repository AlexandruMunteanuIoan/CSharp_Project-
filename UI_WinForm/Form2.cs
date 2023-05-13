﻿using LibrarieModele;
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

        private string secretKey = "S7t8u2d1e10n2t";
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

            label1.Text = "Select number of questions (10-30):";
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
            string encryptedPassword = EncryptPassword(textBox1.Text);

            if (encryptedPassword == " g2y")
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }

            int n;

            if (int.TryParse(textBox1.Text, out n))
            {
                if (n >= 10 && n <= 30)
                {
                    Form3 form3 = new Form3(n);
                    form3.Show();
                    this.Hide();
                }
                
            }
            label1.Text = "Error!!!! Please enter a valid number (10 - 30).";
            label1.Left = ((int)(screenWidth * 0.8) - label1.Width) / 2;
            textBox1.Text = string.Empty;

        }

        private string EncryptPassword(string password)
        {
            char[] passwordChars = password.ToCharArray();
            char[] keyChars = secretKey.ToCharArray();

            for (int i = 0; i < passwordChars.Length; i++)
            {
                passwordChars[i] = (char)(passwordChars[i] ^ keyChars[i % keyChars.Length]);
            }

            string encryptedPassword = new string(passwordChars);

            return encryptedPassword;
        }
    }
}
