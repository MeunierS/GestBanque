using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGestBanque
{
    public class BanqueTest
    {
        [Fact]
        public void TestIfBanqueNull()
        {
            //Arrange
            string? nom = null;
            //Act
            NullReferenceException exception = Assert.Throws<NullReferenceException>(() => new Banque(nom!));
            //Assert
        }
        [Fact]
        public void TestSupprimerCompteInexistant()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", new DateTime(1970, 1, 1));
            Banque test = new Banque("TestBANK");
            //Act
            NullReferenceException exception = Assert.Throws<NullReferenceException>(() => test.Supprimer("001"));
            //Assert
        }
        [Fact]
        public void TestAjoutCompte()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", new DateTime(1970, 1, 1));
            Banque test = new Banque("TestBANK");
            Compte compte = new Epargne("001", doe);
            //Act
            test.Ajouter(compte);
            //Assert
            Assert.Equal("001", compte.CompteId);
            Assert.Equal(0, compte.Solde);
        }
    }
}
