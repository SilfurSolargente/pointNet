using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierCSharpdeux
{
    internal class Complexe
    {
        private double x;
        private double y;

        public Complexe(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Complexe()
        {
            x = 0;
            y = 0;
        }
        public double GetPartieReelle()
        {
            return x;
        }
        public double GetPartieImaginaire()
        {
            return y;
        }
        public Complexe Addition(Complexe nombre)
        {
            Complexe somme;
            double sommeReel, sommeImaginaire;
            sommeReel = x + nombre.GetPartieReelle();
            sommeImaginaire = y + nombre.GetPartieImaginaire();
            somme = new Complexe(sommeReel, sommeImaginaire);
            return somme;
        }
        public Complexe Soustraction(Complexe nombre)
        {
            Complexe diff;
            double diffReel = x - nombre.GetPartieReelle();
            double diffImaginaire = y - nombre.GetPartieImaginaire();
            diff = new Complexe(diffReel, diffImaginaire);
            return diff;
        }
        public Complexe Multiplication(Complexe nombre)
        {
            Complexe produit;
            double produitReel = x * nombre.GetPartieReelle() - y * nombre.GetPartieImaginaire();
            double produitImaginaire = x * nombre.GetPartieImaginaire() + nombre.GetPartieReelle() * y;
            produit = new Complexe(produitReel, produitImaginaire);
            return produit;
        }
        public Complexe Inverse()
        {
            if ((x == 0) || (y == 0)) {
                return new Complexe();
            }
            return new Complexe(x / (Math.Pow(x, 2) + Math.Pow(y, 2)), -y / (Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
        public override string ToString()
        {
            return x.ToString() + "," + y.ToString();
        }
    }
}
