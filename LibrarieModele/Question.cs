using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Question
    {
        public string intrebare { get; set; }
        public List<string> optiuni { get; set; }
        public int indexIntrebariiCurente { get; set; }

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

    }

}