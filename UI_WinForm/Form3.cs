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
    public partial class Form3 : Form
    {

        private CitireScriereFisier citireScriereFisier;
        private List<Question> intrebari;
        private Quizi quizi;
        private Question intrebareCurenta;
        private int n;
        private int i = 1;
        Label lblscor;

        public Form3(int n)
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

                label1.Text = intrebareCurenta.intrebare;
                label1.Font = new Font(label1.Font.FontFamily, 22, FontStyle.Bold);
                label1.AutoSize = false;
                label1.TextAlign = ContentAlignment.MiddleCenter;

                int labelWidth = Math.Min(formWidth - 40, rectangleWidth);
                int labelHeight = Math.Min(formHeight - 40, rectangleHeight);

                label1.Size = new Size(labelWidth, labelHeight);

                label1.Location = new Point((formWidth - label1.Width) / 2, - 100);



                button1.Text = intrebareCurenta.optiuni[0];
                button1.Size = new Size(225, 75);
                button1.Location = new Point(rectangleX - 10, rectangleY + 60);
                button1.Font = new Font(button1.Font.FontFamily, 20);

                button2.Text = intrebareCurenta.optiuni[1];
                button2.Size = new Size(225, 75);
                button2.Location = new Point(rectangleX + rectangleWidth - 230, rectangleY + 60);
                button2.Font = new Font(button2.Font.FontFamily, 20);

                button3.Text = intrebareCurenta.optiuni[2];
                button3.Size = new Size(225, 75);
                button3.Location = new Point(rectangleX - 10, rectangleY + rectangleHeight - 180);
                button3.Font = new Font(button3.Font.FontFamily, 20);

                button4.Text = intrebareCurenta.optiuni[3];
                button4.Size = new Size(225, 75);
                button4.Location = new Point(rectangleX + rectangleWidth - 230, rectangleY + rectangleHeight - 180);
                button4.Font = new Font(button4.Font.FontFamily, 20);

                button5.Text = "Next";
                button5.Size = new Size(150, 50);
                button5.Location = new Point(formWidth - 200, formHeight - 125);
                button5.Font = new Font(button5.Font.FontFamily, 20);
                button5.Enabled = false;

                this.Controls.Add(lblscor);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AfisareIntrebareCurenta()
        {
            if (intrebareCurenta == null)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                label1.Text = intrebareCurenta.intrebare;
                button1.Text = intrebareCurenta.optiuni[0];
                button2.Text = intrebareCurenta.optiuni[1];
                button3.Text = intrebareCurenta.optiuni[2];
                button4.Text = intrebareCurenta.optiuni[3];
                lblscor.Text = i + "/" + n;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(0);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (isCorrect)
            {
                button1.BackColor = Color.Green; 
                quizi.scor++;
            }
            else
            {
                button1.BackColor = Color.Red; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(1);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (isCorrect)
            {
                button2.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(2);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (isCorrect)
            {
                button3.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isCorrect = intrebareCurenta.IsAnswerCorrect(3);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (isCorrect)
            {
                button4.BackColor = Color.Green;
                quizi.scor++;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                Form4 form4 = new Form4(quizi.scor, n);
                form4.Show();
                this.Hide();
            }
        }

        private void ResetButtonColors()
        {
            button1.BackColor = Color.FromArgb(255, 144, 0);
            button2.BackColor = Color.FromArgb(255, 144, 0);
            button3.BackColor = Color.FromArgb(255, 144, 0);
            button4.BackColor = Color.FromArgb(255, 144, 0);
        }

        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

