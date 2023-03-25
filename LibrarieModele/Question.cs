using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Question
    {
        public string text;
        public List<string> options;
        public int correctAnswerIndex;

        public Question(string text, List<string> options, int correctAnswerIndex)
        {
            
        }

        public bool IsAnswerCorrect(int answerIndex)
        {
            
        }

        public void Display()
        {
           
        }
    }

}
