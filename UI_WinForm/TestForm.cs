using LibrarieModele;

using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace UI_WinForm
{
    public partial class TestForm : Form
    {

        private CitireScriereFisier citireScriereFisier;
        private List<Question> intrebari;
        private Quizi quizi;
        private Question intrebareCurenta;
        private int n;
        private int i = 1;
        Label lblscor;

        public TestForm(int n)
        {


            InitializeComponent();

            this.n = n;

            string numeFisier = "questions.txt";
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            citireScriereFisier = new CitireScriereFisier(caleCompletaFisier);
            intrebari = citireScriereFisier.SelectareIntrebari(n);

            if (intrebari.Count == 0)
            {
                MessageBox.Show("Nu s-au găsit întrebări în fișier.");
                this.Close();
                return;
            }

            quizi = new Quizi(intrebari);
            quizi.Start();
            intrebareCurenta = quizi.NextQuestion();
            lblscor = new Label();
            AfisareIntrebareCurenta();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = (int)(screenWidth * 0.8);
            int formHeight = (int)(screenHeight * 0.8);
            this.Size = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            int rectangleWidth = (int)(formWidth * 0.6);
            int rectangleHeight = (int)(formHeight * 0.6);
            int rectangleX = (formWidth - rectangleWidth) / 2;
            int rectangleY = (formHeight - rectangleHeight) / 2;

            if (intrebareCurenta == null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                
                lblscor.ForeColor = Color.White;
                lblscor.Font = new Font(lblscor.Font.FontFamily, 22, FontStyle.Bold);
                lblscor.AutoSize = true;
                lblscor.Location = new Point(100, formHeight - 125);

                lblQuestion.Text = intrebareCurenta.intrebare;
                lblQuestion.Font = new Font(lblQuestion.Font.FontFamily, 22, FontStyle.Bold);
                lblQuestion.AutoSize = false;
                lblQuestion.TextAlign = ContentAlignment.MiddleCenter;

                int labelWidth = Math.Min(formWidth - 40, rectangleWidth);
                int labelHeight = Math.Min(formHeight - 40, rectangleHeight);

                lblQuestion.Size = new Size(labelWidth, labelHeight);

                lblQuestion.Location = new Point((formWidth - lblQuestion.Width) / 2, - 100);



                btAnswer1.Text = intrebareCurenta.optiuni[0];
                btAnswer1.Size = new Size(225, 75);
                btAnswer1.Location = new Point(rectangleX - 10, rectangleY + 60);
                btAnswer1.Font = new Font(btAnswer1.Font.FontFamily, 20);

                btAnswer2.Text = intrebareCurenta.optiuni[1];
                btAnswer2.Size = new Size(225, 75);
                btAnswer2.Location = new Point(rectangleX + rectangleWidth - 230, rectangleY + 60);
                btAnswer2.Font = new Font(btAnswer2.Font.FontFamily, 20);

                btAnswer3.Text = intrebareCurenta.optiuni[2];
                btAnswer3.Size = new Size(225, 75);
                btAnswer3.Location = new Point(rectangleX - 10, rectangleY + rectangleHeight - 180);
                btAnswer3.Font = new Font(btAnswer3.Font.FontFamily, 20);

                btAnswer4.Text = intrebareCurenta.optiuni[3];
                btAnswer4.Size = new Size(225, 75);
                btAnswer4.Location = new Point(rectangleX + rectangleWidth - 230, rectangleY + rectangleHeight - 180);
                btAnswer4.Font = new Font(btAnswer4.Font.FontFamily, 20);

                btNext.Text = "Next";
                btNext.Size = new Size(150, 50);
                btNext.Location = new Point(formWidth - 200, formHeight - 125);
                btNext.Font = new Font(btNext.Font.FontFamily, 20);
                btNext.Enabled = false;

                this.Controls.Add(lblscor);

            }

        }

        private void AfisareIntrebareCurenta()
        {
            if (intrebareCurenta == null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                lblQuestion.Text = intrebareCurenta.intrebare;
                btAnswer1.Text = intrebareCurenta.optiuni[0];
                btAnswer2.Text = intrebareCurenta.optiuni[1];
                btAnswer3.Text = intrebareCurenta.optiuni[2];
                btAnswer4.Text = intrebareCurenta.optiuni[3];
                lblscor.Text = i + "/" + n;
            }
        }


        private void btAnswer1_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(0);
            btAnswer1.Enabled = false;
            btAnswer2.Enabled = false;
            btAnswer3.Enabled = false;
            btAnswer4.Enabled = false;
            btNext.Enabled = true;
            if (isCorrect)
            {
                btAnswer1.BackColor = Color.Green; 
                quizi.scor++;
            }
            else
            {
                btAnswer1.BackColor = Color.Red; 
            }
        }

        private void btAnswer2_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(1);
            btAnswer1.Enabled = false;
            btAnswer2.Enabled = false;
            btAnswer3.Enabled = false;
            btAnswer4.Enabled = false;
            btNext.Enabled = true;
            if (isCorrect)
            {
                btAnswer2.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                btAnswer2.BackColor = Color.Red;
            }
        }

        private void btAnswer3_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(2);
            btAnswer1.Enabled = false;
            btAnswer2.Enabled = false;
            btAnswer3.Enabled = false;
            btAnswer4.Enabled = false;
            btNext.Enabled = true;
            if (isCorrect)
            {
                btAnswer3.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                btAnswer3.BackColor = Color.Red;
            }
        }

        private void btAnswer4_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(3);
            btAnswer1.Enabled = false;
            btAnswer2.Enabled = false;
            btAnswer3.Enabled = false;
            btAnswer4.Enabled = false;
            btNext.Enabled = true;
            if (isCorrect)
            {
                btAnswer4.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                btAnswer4.BackColor = Color.Red;
            }
        }

        private void btNext5_Click(object sender, EventArgs e)
        {
            Question nextQuestion = quizi.NextQuestion();
            if (nextQuestion != null)
            {
                i++;
                intrebareCurenta = nextQuestion;
                AfisareIntrebareCurenta();
                ResetButtonColors();
                EnableButtons();
            }
            else
            {
                EndForm form4 = new EndForm(quizi.scor, n);
                form4.Show();
                this.Hide();
            }
        }

        private void ResetButtonColors()
        {
            btAnswer1.BackColor = Color.FromArgb(255, 144, 0);
            btAnswer2.BackColor = Color.FromArgb(255, 144, 0);
            btAnswer3.BackColor = Color.FromArgb(255, 144, 0);
            btAnswer4.BackColor = Color.FromArgb(255, 144, 0);
        }

        private void EnableButtons()
        {
            btAnswer1.Enabled = true;
            btAnswer2.Enabled = true;
            btAnswer3.Enabled = true;
            btAnswer4.Enabled = true;
            btNext.Enabled = false;
        }
    }
}

