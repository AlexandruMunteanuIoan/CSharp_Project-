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
            CitireScriereFisier csf = new CitireScriereFisier();
            List<Question> questions = csf.SelectareIntrebari(10);
            Quizi quiz = new Quizi(questions);
            csf.ScriereScorInFisier(quiz.Start());
        }
    }
}
