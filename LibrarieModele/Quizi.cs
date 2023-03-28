using System;
using System.Collections.Generic;

namespace LibrarieModele
{
    public class Quizi
    {
        private List<Question> questions;
        private int indexIntrebariiCurente;
        private int scor;

        public Quizi(List<Question> questions)
        {
            this.questions = questions;
        }
        
        public Quizi() { } 

        public int Start()
        {
            Console.Clear();
            Console.WriteLine("Bine ati venit la acest test!");
            Console.WriteLine("Apasati orice tasta pentru START.");
            Console.ReadKey();
            indexIntrebariiCurente = 0;
            scor = 0;
            NextQuestion();
            return scor;
        }

        public void NextQuestion()
        {
            if (indexIntrebariiCurente < questions.Count)
            {
                Console.Clear();
                Console.WriteLine($"Intrebare {indexIntrebariiCurente + 1}:");
                var intrebareaCurenta = questions[indexIntrebariiCurente];
                intrebareaCurenta.Display();
                Console.Write("Introduceți raspunsul (1-4): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int indexRaspuns) && indexRaspuns >= 1 && indexRaspuns <= 4)
                {
                    SubmitAnswer(indexRaspuns - 1);
                }
                else
                {
                    Console.WriteLine("Raspuns invalid! Va rugam sa introduceti un numar de la 1 la 4.");
                    NextQuestion();
                }
            }
            else
            {
                DisplayResults();
            }
        }

        public void SubmitAnswer(int indexRaspuns)
        {
            var intrebareCurenta = questions[indexIntrebariiCurente];
            if (intrebareCurenta.IsAnswerCorrect(indexRaspuns))
            {
                Console.WriteLine("Corect!");
                scor++;
            }
            else
            {
                Console.WriteLine("Gresit!");
            }
            Console.WriteLine($"Scoul: {scor}/{questions.Count}");
            Console.WriteLine("Apasati orice tasta pentru a continua.");
            Console.ReadKey();
            indexIntrebariiCurente++;
            NextQuestion();
        }

        public void DisplayResults()
        {
            Console.Clear();
            Console.WriteLine("Chestionar terminat!");
            Console.WriteLine($"Scorul tau final este {scor}/{questions.Count}.");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }
    }
}
