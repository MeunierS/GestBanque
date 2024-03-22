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
        private string _Nom;
        private Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();
        public string Nom
        {
            get
            {
                return _Nom;
            }

            set
            {
                _Nom = value;
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

            set
            {
                _Comptes[key] = value;
            }
        }
        public void Ajouter(Courant compte)
        {
            if (_Comptes.ContainsKey(compte.CompteId))
            {
                Console.WriteLine("Compte déjà existant.");
                return;
            }
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
    }
}
