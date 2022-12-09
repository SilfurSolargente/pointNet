using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeCollection
{
    internal class Entrée
    {
        private string clé;
        private string valeur;
        public Entrée(string clé, string valeur)
        {
            this.clé = clé;
            this.valeur = valeur;
        }
        public string GetCle()
        {
            return clé;
        }
        public string GetValeur()
        {
            return valeur;
        }
        public override string ToString()
        {
            string chaine = clé + " : " + valeur;
            return chaine;
        }
    }
}
