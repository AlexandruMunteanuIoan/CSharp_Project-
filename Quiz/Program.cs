using System;
using System.Collections.Generic;
using LibrarieModele;
using NivelStocareDate;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "questions.txt";
            CitireScriereFisier csf = new CitireScriereFisier(fileName);
            List<Question> questions = csf.SelectareIntrebari(10);
            Quizi quiz = new Quizi(questions);
            quiz.Start();
        }
    }
}
