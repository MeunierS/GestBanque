namespace Models;

public class Epargne : Compte
{
    public DateTime dernierRetrait { get; private set; }
    
    public override void Retrait(double value)
    {
        double OldSolde = Solde;
        base.Retrait(value);

        if (Solde != OldSolde)
        {
            dernierRetrait = DateTime.Now;
        }
    }
    protected override double CalculInteret()
    {
        return Solde * 4.5 / 100;
    }
    public Epargne(string CompteId, Personne Titulaire) : base(CompteId, Titulaire)
    {
        
    }
    public Epargne(string CompteId, Personne Titulaire, DateTime dernierRetrait) : base(CompteId, Titulaire)
    {
        this.dernierRetrait = dernierRetrait;
    }
}
