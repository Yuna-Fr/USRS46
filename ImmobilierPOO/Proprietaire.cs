using System;
using System.Text.RegularExpressions;

namespace ImmobilierPOO
{
    public class Bien
    {
        public string Adresse;
        public float Superficie;

        public Bien(string adresse, float superficie)
        {
            Adresse = adresse;
            Superficie = superficie;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            return this.Superficie * facteur;
        }
    }
}

