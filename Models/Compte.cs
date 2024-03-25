using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Compte
{
    private string _CompteId;
    private Personne _Titulaire;
    private double _Solde;

    public double Solde
    {
        get
        {
            return _Solde;
        }
        private set
        {
            _Solde = value;
        }
    }
    public string CompteId
    {
        get
        {
            return _CompteId;
        }
        set
        {
            _CompteId = value;
        }
    }
    public Personne Titulaire
    {
        get
        {
            return _Titulaire;
        }
        set
        {
            _Titulaire = value;
        }
    }
    
    public virtual void Retrait(double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Montant de retrait nulle/négatif, tentative d'arnaque détectée.");
            return;
        }
        if ((Solde - value) < 0)
        {
            Console.WriteLine("Solde insuffisant pour le retrait.");
            return;
        }
        Solde -= value;
        Console.WriteLine($"{value} a bien été retiré de votre compte.");
        Console.WriteLine($"Nouveau solde : {Solde}.");
    }
    public virtual void Depot(double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Êtes vous sûr qu'il est judicieux de Déposer une valeur nulle/négative d'argent sur votre compte ?");
            return;
        }
        Solde += value;
        Console.WriteLine($"Nouveau solde : {Solde}.");
        return;
    }
}
