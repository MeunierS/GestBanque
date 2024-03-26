using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IBanker : ICustomer
    {
        void AppliquerInteret();

        Personne Titulaire {  get; } 
        string CompteId { get; }
    }
}
