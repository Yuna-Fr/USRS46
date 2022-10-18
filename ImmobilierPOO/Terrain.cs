using System;

namespace ImmobilierPOO
{
    public class Terrain
    {
        public string adresse;
        public float superficie;
        public int nbCotesClotures;
        public bool riviere;

        public Terrain(string adresse, float superficie, int nbCotesClotures, bool riviere)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesClotures = nbCotesClotures;
            Riviere = riviere;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de côtés de la clotures = {0}\n", this.nbCotesClotures);
            toString += String.Format("Présence d'une rivière = {0}\n", this.riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.riviere) { facteur += 500; }
            if (this.nbCotesClotures < 4) { facteur -= CoutFinirCloture()}
            else { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }

        public int CoutFinirCloture()
        {
            int prix;
            for (this.nbCotesClotures < 4; this.nbCotesClotures++)
            {
                prix += 100
            }
             return prix;
        }
    }
}

