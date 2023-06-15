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
    public partial class AdminForm : Form
    {
        private CitireScriereFisier citireScriereFisier;

        public AdminForm()
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

            lblQuestion.Text = "Question:";
            lblQuestion.Font = new Font(lblQuestion.Font.FontFamily, 14);

            rbAanswer1.Font = new Font(rbAanswer1.Font.FontFamily, 12);
            rbAanswer2.Font = new Font(rbAanswer2.Font.FontFamily, 12);
            rbAanswer3.Font = new Font(rbAanswer3.Font.FontFamily, 12);
            rbAanswer4.Font = new Font(rbAanswer4.Font.FontFamily, 12);

            txtboxquestion.Font = new Font(txtboxquestion.Font.FontFamily, 14);
            txtboxquestion.Size = new Size(500, 30);

            txtboxAnswer1.Font = new Font(txtboxAnswer1.Font.FontFamily, 12);
            txtboxAnswer1.Size = new Size(500, 20);

            txtboxAnswer2.Font = new Font(txtboxAnswer2.Font.FontFamily, 12);
            txtboxAnswer2.Size = new Size(500, 20);

            txtboxAnswer3.Font = new Font(txtboxAnswer3.Font.FontFamily, 12);
            txtboxAnswer3.Size = new Size(500, 20);

            txtboxAnswer4.Font = new Font(txtboxAnswer4.Font.FontFamily, 12);
            txtboxAnswer4.Size = new Size(500, 20);

            int centerX = formWidth / 2;
            int centerY = formHeight / 3;

            int labelX = centerX - (lblQuestion.Width + txtboxquestion.Width + 10) / 2;
            int textBoxX = labelX + lblQuestion.Width;

            label6.Location = new Point(centerX - label6.Width / 2, centerY - label6.Height * 3);

            lblQuestion.Location = new Point(labelX-5, centerY);
            txtboxquestion.Location = new Point(textBoxX, centerY);

            centerY += lblQuestion.Height + 20;

            rbAanswer1.Location = new Point(labelX-5, centerY);
            txtboxAnswer1.Location = new Point(textBoxX, centerY);

            centerY += rbAanswer1.Height + 20;

            rbAanswer2.Location = new Point(labelX-5, centerY);
            txtboxAnswer2.Location = new Point(textBoxX, centerY);

            centerY += rbAanswer2.Height + 20;

            rbAanswer3.Location = new Point(labelX-5, centerY);
            txtboxAnswer3.Location = new Point(textBoxX, centerY);

            centerY += rbAanswer3.Height + 20;

            rbAanswer4.Location = new Point(labelX - 5, centerY);
            txtboxAnswer4.Location = new Point(textBoxX, centerY);

            centerY += rbAanswer4.Height + 20;

            btAdd.Location = new Point(textBoxX, centerY);

            centerY += btAdd.Height + 20;

            btEnd.Location = new Point(formWidth - 150, formHeight - 100);

            this.Controls.Add(label6);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string intrebare = txtboxquestion.Text;
            List<string> varianteRaspuns = new List<string>
            {
                txtboxAnswer1.Text,
                txtboxAnswer2.Text,
                txtboxAnswer3.Text,
                txtboxAnswer4.Text
            };

            int indexRaspunsCorect = -1;

            if (rbAanswer1.Checked)
                indexRaspunsCorect = 0;
            else if (rbAanswer2.Checked)
                indexRaspunsCorect = 1;
            else if (rbAanswer3.Checked)
                indexRaspunsCorect = 2;
            else if (rbAanswer4.Checked)
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
            txtboxquestion.Text = string.Empty;
            txtboxAnswer1.Text = string.Empty;
            txtboxAnswer2.Text = string.Empty;
            txtboxAnswer3.Text = string.Empty;
            txtboxAnswer4.Text = string.Empty;
            rbAanswer1.Checked = false;
            rbAanswer2.Checked = false;
            rbAanswer3.Checked = false;
            rbAanswer4.Checked = false;

        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
