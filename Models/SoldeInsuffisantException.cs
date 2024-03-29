using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SoldeInsuffisantException : Exception
    {
        public string erreur { get; set; }
        public SoldeInsuffisantException (string erreur) : this(erreur, "Solde Insuffisant")
        {

        }
        public SoldeInsuffisantException(string erreur, string message) : base (message)
        {
            this.erreur = erreur;
        }
    }
}
