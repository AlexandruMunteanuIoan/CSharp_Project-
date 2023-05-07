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
            
            CitireScriereFisier citireScriereFisier = new CitireScriereFisier();

            Console.WriteLine("Bun venit la quiz!");
            Console.Write("Alege nr de intrebari (5-20):");
            int n = int.Parse(Console.ReadLine());


            List<Question> intrebari = citireScriereFisier.SelectareIntrebari(n);

            Quizi quizi = new Quizi(intrebari);

            quizi.Start();

            Question intrebareCurenta;

            while ((intrebareCurenta = quizi.NextQuestion()) != null)
            {
                Console.Clear();
                Console.WriteLine(intrebareCurenta.intrebare);
                Console.WriteLine();

                for (int i = 0; i < intrebareCurenta.optiuni.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {intrebareCurenta.optiuni[i]}");
                }

                Console.WriteLine();

                Console.Write("Raspunsul tau: ");

                int raspuns;
                while (!int.TryParse(Console.ReadLine(), out raspuns) || raspuns < 1 || raspuns > intrebareCurenta.optiuni.Count)
                {
                    Console.Write("Raspuns invalid. Incearca din nou: ");
                }

                if (intrebareCurenta.IsAnswerCorrect(raspuns - 1))
                {
                    Console.WriteLine("Raspuns corect!");
                    quizi.scor++;
                }
                else
                {
                    Console.WriteLine("Raspuns gresit...");
                }

                Console.WriteLine();
                Console.WriteLine("Apasa o tasta pentru a continua...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Chestionar terminat!");
            Console.WriteLine($"Scorul tau final este {quizi.scor}/{intrebari.Count}.");

            citireScriereFisier.ScriereScorInFisier(quizi.scor);

            Console.WriteLine("Apasa o tasta pentru a iesi...");
            Console.ReadKey();
        }
    }
}
