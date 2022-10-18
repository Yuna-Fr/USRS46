using System;
using System.Collections.Generic;

namespace ImmobilierPOO
{
    public class Proprietaire
    {
        public string Nom;
        public string Prenom;
        public Bien[] Biens = new Bien[0];


        public Proprietaire(string nom, string prenom, Bien[] biens)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Biens = biens;
        }

        private string ListeBiens()
        {
            string listeBiens = "";
            foreach (Bien B in this.Biens)
            {
                listeBiens += String.Format("- {0} {1} au {2}\n", B.GetType().Name == "Maison" ? "Une" : "Un", B.GetType().Name, B.Adresse);
            }
            return listeBiens;
        }

        public override string ToString()
        {
            string toString = String.Format("{1} {0} {2}", this.Nom, this.Prenom, this.Biens?.Length != 0 ? "possède\n" : "ne possède aucun bien");
            toString += ListeBiens();
            return toString;
        }
    }
}

