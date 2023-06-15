using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using LibrarieModele;

namespace NivelStocareDate
{
    public class CitireScriereFisier
    {
        private string fileName ;
        private string numeFisier = "Scor.txt";
        private int number;

        public CitireScriereFisier(string fileName)
        {
            this.fileName = fileName;
            Stream streamFisierText = File.Open(fileName, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public List<Question> CitireFisier()
        {
            List<Question> questions = new List<Question>();

            try
            {
                List<string> linii = File.ReadAllLines(fileName).ToList();

                int nrDeIntrebari = linii.Count / 6;

                for (int i = 0; i < nrDeIntrebari; i++)
                {
                    string intrebarea = linii[i * 6];
                    List<string> varianteDeRaspuns = linii.Skip(i * 6 + 1).Take(4).ToList();
                    int indexRaspunsCorect = int.Parse(linii[i * 6 + 5]);

                    questions.Add(new Question(intrebarea, varianteDeRaspuns, indexRaspunsCorect));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la citirea fisierului: {ex.Message}");
            }

            return questions;
        }

        public void AdaugareIntrebare(string intrebare, List<string> varianteDeRaspuns, int indexRaspunsCorect)
        {
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(fileName, true))
                {
                    streamWriterFisierText.WriteLine(intrebare);
                    foreach (string varianta in varianteDeRaspuns)
                    {
                        streamWriterFisierText.WriteLine(varianta);
                    }
                    streamWriterFisierText.WriteLine(indexRaspunsCorect);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la adăugarea întrebării în fișier: {ex.Message}");
            }
        }

        public List<Question> SelectareIntrebari(int n)
        {
            List<Question> questions = CitireFisier();
            List<Question> intrebariSelectate = new List<Question>();
            Random random = new Random();
            number = n;

            while (intrebariSelectate.Count < n && questions.Count > 0)
            {
                int index = random.Next(questions.Count);
                intrebariSelectate.Add(questions[index]);
                questions.RemoveAt(index);
            }

            return intrebariSelectate;
        }
    }
}
