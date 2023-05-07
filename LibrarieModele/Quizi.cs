using System;
using System.Collections.Generic;

namespace LibrarieModele
{
    public class Quizi
    {
        private List<Question> questions;
        private int indexIntrebariiCurente;
        public int scor;

        public Quizi(List<Question> questions)
        {
            this.questions = questions;
        }

        public Quizi() { }

        public void Start()
        {
            indexIntrebariiCurente = 0;
            scor = 0;
        }

        public Question NextQuestion()
        {

            if (indexIntrebariiCurente < questions.Count)
            {
                Question nextQuestion = questions[indexIntrebariiCurente];
                indexIntrebariiCurente++;
                return nextQuestion;
            }
            else
            {
                return null;
            }
        }



    }
}