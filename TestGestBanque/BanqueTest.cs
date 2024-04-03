using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Banque(nom!));
            //Assert
        }
        [Fact]
        public void TestAjoutBanque()
        {
            //Arrange
            Banque test = new Banque("TestBANK");
            //Act

            //Assert
            Assert.Equal("TestBANK", test._NomBanque);
        }
        [Fact]
        public void TestSupprimerCompteInexistant()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", new DateTime(1970, 1, 1));
            Banque test = new Banque("TestBANK");
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => test.Supprimer("001"));
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
        [Fact]
        public void TestAjoutCompteNull()
        {
            //Arrange
            Banque test = new Banque("TestBANK");
            Compte? compte = null;
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => test.Ajouter(compte!));
            //Assert
        }
        [Fact]
        public void TestAjoutCompteDejaExistant()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", new DateTime(1970, 1, 1));
            Banque test = new Banque("TestBANK");
            Compte compte = new Epargne("001", doe);
            test.Ajouter(compte);
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => test.Ajouter(compte));
            //Assert
        }
        [Fact]
        public void TestSupprimerCompteNull()
        {
            //Arrange
            string? cle = null;
            Banque test = new Banque("TestBANK");
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => test.Supprimer(cle!));
            //Assert
        }
        [Fact]
        public void TestSupprimerCompteExistant()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", new DateTime(1970, 1, 1));
            Banque test = new Banque("TestBANK");
            Compte compte = new Epargne("001", doe);
            test.Ajouter(compte);
            //Act
            test.Supprimer("001");
            Compte? compte2 = test["001"];
            //Assert
            Assert.Null(compte2);
        }
    }
}
