namespace Models;

public class Courant
{
    public string CompteId;
    private double LigneDeCredit = 0;
    public Personne Titulaire;
    private double _Solde;
    public double Solde { get => Solde; private set => Solde = value; }

    public void Retrait(double value)
    {
        if (value < 0)
        {
            Console.WriteLine("Montant de retrait négatif, tentative d'arnaque détectée.");
            return;
        }
        if (value > Solde + LigneDeCredit) 
        {
            Console.WriteLine("Solde insuffisant pour le retrait.");
            return;
        }

        Solde -= value;
        Console.WriteLine($"{value} € a bien été retiré de votre compte.");
        Console.WriteLine($"Nouveau solde : {Solde} €");
        return;


    }
    public void Depot(double value)
    {
        if (value < 0)
        {
            Console.WriteLine("Êtes vous sûr qu'il est judicieux de Déposer une valeur négative d'argent sur votre compte ?");
            return;
        }
        Solde += value;
        Console.WriteLine($"Nouveau solde : {Solde} €");
        return;
    }
}