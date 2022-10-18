using System;
using System.Text.RegularExpressions;

namespace ImmobilierPOO
{
    public class Piece
    {
        public int Superficie;
        public string Nom;

        public Piece(int superficie, string nom)
        {
            Superficie = superficie;
            Nom = nom;
        }

        public override string ToString()
        {
            string toString = String.Format("La pièce {0} fait {1}m²", this.Nom, this.Superficie);
            return toString;
        }
    }
}

