using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banque
    {
        private string _NomBanque;
        private Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();
        public string NomBanque
        {
            get
            {
                return _NomBanque;
            }

            set
            {
                _NomBanque = value;
            }
        }

        public Courant? this[string key]
        {
            get
            {
                if (!_Comptes.ContainsKey(key))
                {
                    return null;
                }
                return _Comptes[key];
            }
        }
        public void Ajouter(Courant compte)
        {
            _Comptes.Add(compte.CompteId, compte);
        }
        public void Supprimer(string cle) 
        {
            if (!_Comptes.ContainsKey(cle))
            {
                Console.WriteLine("Le compte a supprimé n'existe pas.");
                return;
            }
            _Comptes.Remove(cle);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double avoir = 0D;

            foreach (KeyValuePair<string, Courant> item in _Comptes)
            {
                if (item.Value.Titulaire == titulaire)
                {
                    avoir += item.Value;
                }
            }
            return avoir;
        }
    }
}
