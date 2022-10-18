using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ImmobilierPOO
{
    public class Maison : Bien
    {
        public int NbPieces;
        public bool Jardin;
        public Piece[] Pieces;
        public static readonly List<string> NomsPieces = new List<string>() { "Cuisine", "Salle de bain", "Chambre", "Salon", "Garage", "Bureau", "Terrasse" };

        public Maison(string adresse, float superficie, int nbPieces, bool jardin) : base(adresse, superficie)
        {
            NbPieces = nbPieces;
            Jardin = jardin;
            Superficie = 0;
            Pieces = new Piece[NbPieces];

            Random rnd = new Random();

            for (int i = 0; i < NbPieces; i++)
            {
                Pieces[i] = new Piece(rnd.Next(10, 30), NomsPieces[rnd.Next(NomsPieces.Count)]);
                Superficie += Pieces[i].Superficie;
            }
        }

        public override string ToString()
        {
            string toString = base.ToString();
            toString += String.Format("Nombre de pièces = {0}\n", this.NbPieces);
            for (int i = 0; i < this.NbPieces; i++)
                toString += String.Format("- {0}\n", this.Pieces[i]);
            toString += String.Format("Présence d'un jardin = {0}\n", this.Jardin ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }

        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Jardin) { facteur += 500; }
            if (this.NbPieces > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }
    }
}

