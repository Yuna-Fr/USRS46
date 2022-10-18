using System;
using System.Text.RegularExpressions;

namespace ImmobilierPOO
{
    public class Maison
    {
        public string Adresse;
        public float Superficie;
        public int NbPieces;
        public bool Jardin;

        public Maison(string adresse, float superficie, int nbPieces, bool jardin)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbPieces = nbPieces;
            Jardin = jardin;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de pièces = {0}\n", this.NbPieces);
            toString += String.Format("Présence d'un jardin = {0}\n", this.Jardin ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
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

