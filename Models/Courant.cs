namespace Models;

public class Courant : Compte
{
    private double _LigneDeCredit;
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
    public static double operator +(double amount, Courant courant)
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
        public override void Retrait(double value)
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
}