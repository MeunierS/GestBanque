namespace Models;

public class Courant
{
    private string _CompteId;
    private double _LigneDeCredit = 0;
    private Personne _Titulaire;
    private double _Solde;

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

    public double LigneDeCredit
    {
        get
        {
            return _LigneDeCredit;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("La ligne de Crédit doit être strictement positive !");
                return;
            }
            _LigneDeCredit = value;
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

    public void Retrait(double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Montant de retrait nulle/négatif, tentative d'arnaque détectée.");
            return;
        }
        if ((Solde - value) < -LigneDeCredit) 
        {
            Console.WriteLine("Solde insuffisant pour le retrait.");
            return;
        }
        Solde -= value;
        Console.WriteLine($"{value} a bien été retiré de votre compte.");
        Console.WriteLine($"Nouveau solde : {Solde}.");
    }
    public void Depot(double value)
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
    public static double operator +(Courant c1, Courant c2)
    {
        double temp1, temp2;
        if (c1.Solde < 0)
        {
            temp1 = 0;
            
        }
        else
        {
            temp1= c1.Solde;
        }
        if (c2.Solde < 0)
        {
            temp2 = 0;

        }
        else
        {
            temp2 = c2.Solde;
        }
        return temp1 + temp2;
    }
}