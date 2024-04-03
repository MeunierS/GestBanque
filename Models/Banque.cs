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
        private string _NomBanque { get; init; }
        private Dictionary<string, Compte> _Comptes;

        public Compte? this[string key]
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
        public void Ajouter(Compte compte)
        {
            _Comptes.Add(compte.CompteId, compte);
            compte.PassageEnNegatifEvent += PassageEnNegatifAction;
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"Attention ! Le compte numéro '{compte.CompteId}' vient de passer en négatif !");
        }

        public void Supprimer(string cle) 
        {
            if (!_Comptes.ContainsKey(cle))
            {
                //Console.WriteLine("Le compte a supprimé n'existe pas.");
                //return;
                throw new NullReferenceException("Le compte a supprimé n'existe pas.");
            }
            Compte compte = this[cle]!;
            compte.PassageEnNegatifEvent -= PassageEnNegatifAction;
            _Comptes.Remove(cle);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double avoir = 0D;

            foreach (KeyValuePair<string, Compte> item in _Comptes)
            {
                if (item.Value.Titulaire == titulaire)
                {
                    avoir += item.Value;
                }
            }
            return avoir;
        }
        public Banque(string nomBanque)
        {
            if (nomBanque is null)
            {
                throw new NullReferenceException("Nom de banque est NULL.");
            }
            _NomBanque = nomBanque;
            _Comptes = new Dictionary<string, Compte>();
        }
    }
}
