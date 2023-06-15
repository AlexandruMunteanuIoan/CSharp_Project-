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

namespace UI_WinForm
{
    public partial class EndForm : Form
    {
        private int score;
        private int nrIntreb;
        public EndForm(int scor, int n)
        {
            InitializeComponent();
            score = scor;
            nrIntreb = n;
            
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = (int)(screenWidth * 0.8);
            int formHeight = (int)(screenHeight * 0.8);
            this.Size = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblEnd.Text = "The quiz ends";
            lblScor.Text = "The accumulated score: " + score.ToString() + " / " + nrIntreb.ToString();
            lblEnd.ForeColor = Color.White;
            lblScor.ForeColor = Color.White;
            lblEnd.Font = new Font(lblEnd.Font.FontFamily, 56);
            lblScor.Font = new Font(lblScor.Font.FontFamily, 20);
            btEnd.Font = new Font(btEnd.Font.FontFamily, 20);

            lblEnd.Size = new Size(150, 80);
            lblScor.Size = new Size(100, 50);
            btEnd.Size = new Size(100, 50);

            lblEnd.Size = new Size(150, 80);
            btEnd.Size = new Size(100, 50);

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            this.Location = new Point(centerX, centerY);

            lblEnd.Left = (formWidth - lblEnd.Width) / 2 - 8;
            lblScor.Left = (formWidth - lblScor.Width) / 2 - 8;
            btEnd.Left = (formWidth - btEnd.Width) / 2 - 8;

            lblEnd.Top = formHeight / 2 - lblEnd.Height - 20;
            lblScor.Top = formHeight / 2 - lblScor.Height + 15;
            btEnd.Top = formHeight / 2 + 25;

            lblEnd.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
