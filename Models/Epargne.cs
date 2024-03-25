namespace Models;

public class Epargne : Compte
{
    private DateTime dernierRetrait { get; set; }
    
    public override void Retrait(double value)
    {
        base.Retrait(value);
        dernierRetrait = new DateTime();
    }
}
