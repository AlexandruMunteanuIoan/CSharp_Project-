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
    public partial class SelectQuestions : Form
    {
        int screenWidth;
        int screenHeight;
        int formWidth;
        int formHeight;

        private string secretKey = "S7t8u2d1e10n2t";
        public SelectQuestions()
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

            lblSelectQuestions.Text = "Select number of questions (10-30):";
            lblSelectQuestions.Font = new Font(lblSelectQuestions.Font.FontFamily, 35);
            txtBoxNrQuestions.Font = new Font(txtBoxNrQuestions.Font.FontFamily, 20);

            txtBoxNrQuestions.Size = new Size(500, 50);

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            this.Location = new Point(centerX, centerY);

            btStartQuiz.Size = new Size(150, 40);
            btStartQuiz.Font = new Font(btStartQuiz.Font.FontFamily, 16);

            lblSelectQuestions.Left = (formWidth - lblSelectQuestions.Width) / 2 - 8;
            txtBoxNrQuestions.Left = (formWidth - txtBoxNrQuestions.Width) / 2 - 8;
            btStartQuiz.Left = (formWidth - btStartQuiz.Width) / 2 - 8;

            lblSelectQuestions.Top = formHeight / 2 - lblSelectQuestions.Height - 40;
            txtBoxNrQuestions.Top = formHeight / 2 ;
            btStartQuiz.Top = formHeight / 2 + 40;


            lblSelectQuestions.TextAlign = ContentAlignment.MiddleCenter;

        }
        private void txtBoxNrQuestions_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btStartQuiz_Click(object sender, EventArgs e)
        {
            string encryptedPassword = EncryptPassword(txtBoxNrQuestions.Text);

            if (encryptedPassword == " g2y")
            {
                AdminForm form5 = new AdminForm();
                form5.Show();
                this.Hide();
            }

            int n;

            if (int.TryParse(txtBoxNrQuestions.Text, out n))
            {
                if (n >= 10 && n <= 30)
                {
                    TestForm form3 = new TestForm(n);
                    form3.Show();
                    this.Hide();
                }
                
            }
            lblSelectQuestions.Text = "Error!!!! Please enter a valid number (10 - 30).";
            lblSelectQuestions.Left = ((int)(screenWidth * 0.8) - lblSelectQuestions.Width) / 2;
            txtBoxNrQuestions.Text = string.Empty;

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
