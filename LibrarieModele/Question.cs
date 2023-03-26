using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Question
    {
        public string intrebare;
        public List<string> optiuni;
        public int indexIntrebariiCurente;

        public Question(string intrebare, List<string> optiuni, int indexIntrebariiCurente)
        {
            this.intrebare = intrebare;
            this.optiuni = optiuni;
            this.indexIntrebariiCurente = indexIntrebariiCurente;
        }

        public bool IsAnswerCorrect(int indexRaspuns)
        {
            return indexRaspuns == indexIntrebariiCurente;
        }

        public void Display()
        {
            Console.WriteLine(intrebare);
            for (int i = 0; i < optiuni.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {optiuni[i]}");
            }
        }
    }

}
