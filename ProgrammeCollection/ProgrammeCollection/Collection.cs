using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProgrammeCollection
{
    
    internal class Collection
    {
        private const int MAX = 100;
        private Entrée[] tableau = new Entrée[MAX];
        private int positionLibre;
        
        public Collection()
        {
            positionLibre = 0;
        }
        private int RetourneIndex(string clé)
        {
            for (int i = 0; i < positionLibre; i++)
                if (clé == tableau[i].GetCle()) return i;
            return -1;
        }
        public string Retourner(string clé)
        {
            if (RetourneIndex(clé)==-1) return null;
            return tableau[RetourneIndex(clé)].GetValeur();
        }
        public bool Existe(string clé)
        {
            return RetourneIndex(clé) != -1;
        }
        public bool Ajouter(string clé, string valeur)
        {
            if ((positionLibre > MAX) || (Existe(clé))) return false;
            tableau[positionLibre] = new Entrée(clé, valeur);
            positionLibre++;
            return true;
        }
        
        public bool Supprimer(string clé)
        {
            if (!Existe(clé)) return false;
            for (int i = RetourneIndex(clé); i < positionLibre - 2; i++)
                tableau[i] = tableau[i + 1];
            positionLibre -= 1;
            return true;
        }
        public void Vider()
        {
            positionLibre = 0;
        }
        public int NombreDElements()
        {
            return positionLibre;
        }
        public override string ToString()
        {
            string chaine = "";
            for (int i = 0; i < positionLibre; i++)
                chaine += tableau[i].ToString() + "\n";
            return chaine;
        }
    }
}
