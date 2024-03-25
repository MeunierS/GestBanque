namespace Models;

public class Epargne : Compte
{
    private DateTime dernierRetrait { get; set; }
    
    public override void Retrait(double value)
    {
        double OldSolde = Solde;
        base.Retrait(value);

        if (Solde != OldSolde)
        {
            dernierRetrait = DateTime.Now;
        }
    }
    
}
