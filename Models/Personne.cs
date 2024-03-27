namespace Models;

public class Personne
{
    public string Nom { get ; init ; } 
    public string Prenom { get ; init ; }
    public DateTime DateNaiss { get ; init ; }

    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        this.Nom = nom;
        this.Prenom = prenom;
        this.DateNaiss = dateNaiss;
    }
}
