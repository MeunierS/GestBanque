﻿using System;
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
        private Dictionary<string, Compte> _Comptes = new Dictionary<string, Compte>();
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
            Console.WriteLine("Type de compte à ajouter ? 0 pour courant, 1 pour épargne");
            int choix = int.Parse(Console.ReadLine()!);
            if (choix == 0)
            {
                compte = (Courant)compte;
            }
            else if (choix == 1)
            {
                compte = (Epargne)compte;
            }
            else
            {
                Console.WriteLine("Choix incorrect");
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
    }
}
