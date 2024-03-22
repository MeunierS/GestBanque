using System;
using System.Collections.Generic;
using System.Linq;
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

        public Courant this[string key]
        {
            get
            {
                Courant courant;
                _Comptes.TryGetValue(key, out courant);
                return courant;
            }

            set
            {
                _Comptes[key] = value;
            }
        }

        public void Ajouter(Courant compte)
        {
            _Comptes.Add(compte.CompteId, compte);
        }
        public void Supprimer(string cle) 
        {
            _Comptes.Remove(cle);
        }
    }
}
