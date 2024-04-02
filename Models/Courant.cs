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
        private set
        {
            if (value < 0)
            {
                //Console.WriteLine("La ligne de Crédit doit être strictement positive !");
                //return;
                throw new InvalidOperationException("Valeur non supérieur ou égale à zéro");
            }
            _LigneDeCredit = value;
        }
    }
    public override void Retrait(double value)
        {
            bool negatif = false;
            if(Solde < 0)
            {
                negatif = true;
            }
            Retrait(value, LigneDeCredit);
            if (Solde < 0 && !negatif)
            {
                AppelEventNegatif();
            }

    }
    protected override double CalculInteret()
    {
        if (Solde < 0)
        {
            return Solde * 9.75 / 100;
        }
        return Solde * 3 / 100;
    }
    public Courant(string compteId, Personne Titulaire) : base(compteId, Titulaire)
    {
    }

    public Courant(string compteId, Personne titulaire, double solde) : base(compteId, titulaire, solde)
    {
    }
    public Courant(double ligneDeCredit,string compteId, Personne titulaire) : base(compteId, titulaire)
    {
        _LigneDeCredit=ligneDeCredit;
    }
}