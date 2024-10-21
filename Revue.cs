using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        
    // Definition des differentes Propriétés 
    public int Numero { get; set; }
        public int Annee { get; set; }


        // Ajout des Constructeurs
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee) : base(titre, auteur, nombrePages)
        {
            Numero = numero;
            Annee = annee;
        }



        public override void AfficherDetails()
        {
            Console.WriteLine($"Le Titre est: {Titre}, son Auteur est: {Auteur}, son Nombre de pages est: {NombrePages}, et enfin le Numéro: {Numero}, Année: {Annee}");
        }
    }
}
