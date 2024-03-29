using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public abstract class Compte : IBanker, ICustomer
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
        private set
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
        private set
        {
            _Titulaire = value;
        }
    }
    
    public virtual void Retrait(double value)
    {
        Retrait(value, 0D);
    }
    public virtual void Depot(double value)
    {


        if (value <= 0)
        {
            //Console.WriteLine("Êtes vous sûr qu'il est judicieux de Déposer une valeur nulle/négative d'argent sur votre compte ?");
            throw new ArgumentOutOfRangeException("Tentative de dépot négatif.");
            //return;
        }
        Solde += value;
        Console.WriteLine($"Nouveau solde : {Solde}.");
        return;
    }
    public static double operator +(double amount, Compte courant)
    {
        //double temp;
        //if (courant.Solde < 0)
        //{
        //    temp = 0;           
        //}
        //else
        //{
        //    temp= courant.Solde;
        //}
        //return amount + temp;

        return (amount < 0 ? 0 : amount) + (courant.Solde < 0 ? 0 : courant.Solde);

    }
    protected void Retrait(double value, double LigneDeCredit)
    {
        if (value <= 0)
        {
            //Console.WriteLine("Montant de retrait nulle/négatif, tentative d'arnaque détectée.");
            //return;
            throw new ArgumentOutOfRangeException("Tentative de retrait négatif.");
        }
        if ((Solde - value) < -LigneDeCredit)
        {
            //Console.WriteLine("Solde insuffisant pour le retrait.");
            //return;
            throw new SoldeInsuffisantException("Solde insuffisant.");
        }
        Solde -= value;
        Console.WriteLine($"{value} a bien été retiré de votre compte.");
        Console.WriteLine($"Nouveau solde : {Solde}.");
    }
    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }

    public Compte(string compteId, Personne titulaire)
    {
        _Titulaire = titulaire;
        _CompteId = compteId;
        _Solde = 0D;
    }
    public Compte(string compteId, Personne titulaire, double solde) : this(compteId, titulaire)
    {

        Solde = solde;
    }
}

