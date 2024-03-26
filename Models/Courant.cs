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
        public override void Retrait(double value)
        {
            Retrait(value, LigneDeCredit);
        }
    protected override double CalculInteret()
    {
        if (Solde < 0)
        {
            return Solde * 9.75 / 100;
        }
        return Solde * 3 / 100;
    }
}