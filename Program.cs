using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_4_S2
{
    class Program
    {
        static char question(string message, char car1, char car2)
        {
            char reponse;
            do
            {
                Console.Write(message + "(" + car1 + "/" + car2 + ")");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != car1 && reponse != car2);
            return reponse;
        }
        static void Main(string[] args)
        {
            // Déclaration
            char sexe;
            string message="Quel est votre sexe?";
            char c1='H', c2='F';
            // Boucle sur la saisie correcte du sexe
            do
            {
                sexe = question(message,c1,c2);
            } while (sexe != c1 && sexe != c2);
            // Affichage du message personnalisé
            Console.WriteLine();
            if (sexe == c1)
            {
                Console.WriteLine("Bonjour monsieur");
            }
            else
            {
                Console.WriteLine("Bonjour madame");
            }
            Console.ReadLine();
        }
    }
}
