namespace Models;

public class Personne
{
    public string Nom { get ; init ; } 
    public string Prenom { get ; init ; }
    public DateTime DateNaiss { get ; init ; }

    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        if (nom is null)
        {
            throw new NullReferenceException("Nom est NULL.");
        }
        if (prenom is null)
        {
            throw new NullReferenceException("Prenom est NULL.");
        }
        Nom = nom;
        Prenom = prenom;
        DateNaiss = dateNaiss;
    }
}
