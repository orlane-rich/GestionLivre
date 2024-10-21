using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        

            public string Titre { get; set; }
            public string Auteur { get; set; }
            public int NombrePages { get; set; }


            public Livre(string titre, string auteur, int nombrePages)
            {
                Titre = titre;
                Auteur = auteur;
                NombrePages = nombrePages;
            }


            public virtual void AfficherDetails()
            {
                Console.WriteLine($" Le Titre est: {Titre}, le nom de l'Auteur: {Auteur} et son Nombre de pages est: {NombrePages}");
            }
        }
}
