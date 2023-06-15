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
    public partial class WelcomForm : Form
    {
        private Label lblWelcome;
        public WelcomForm()
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

            lblWelcome = new Label();
            lblWelcome.Text = "Welcome";
            lblWelcome.Font = new Font(lblWelcome.Font.FontFamily, 56);
            btStart.Font = new Font(btStart.Font.FontFamily, 20);
            lblWelcome.ForeColor = Color.White;

            lblWelcome.Size = new Size(500, 80); 
            btStart.Size = new Size(100, 50);

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            this.Location = new Point(centerX, centerY);

            lblWelcome.Left = (formWidth - lblWelcome.Width) / 2 - 8;
            btStart.Left = (formWidth - btStart.Width) / 2 - 8;

            lblWelcome.Top = formHeight / 2 - lblWelcome.Height - 20;
            btStart.Top = formHeight / 2 + 20;

            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblWelcome);
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }


        private void btStart_Click(object sender, EventArgs e)
        {
            SelectQuestions form2 = new SelectQuestions();
            form2.Show();
            this.Hide();
        }

    }
}
