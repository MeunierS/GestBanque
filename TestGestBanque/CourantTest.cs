using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGestBanque
{
    public class CourantTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-1500)]
        [InlineData(-15.5936)]
        [InlineData(-0.5)]
        public void TestDepot0OuMoins(double value)
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            //Act
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => test.Depot(value));
            //Assert
            //Assert.Equal("Tentative de dépot négatif.", exception.Message);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(12.654)]
        public void TestDepotPositif(double value)
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            //Act
            test.Depot(value);
            //Assert
            Assert.Equal(value, test.Solde);
        }
        [Fact]
        public void TestRetraitNegatif()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            //Act
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => test.Retrait(-220));
            //Assert
        }
        [Fact]
        public void TestRetrait0()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            //Act
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => test.Retrait(0));
            //Assert
        }
        [Fact]
        public void TestRetraitDejaEnNegatif()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            test.Retrait(100);
            //Act
            test.Retrait(100);
            //Assert
            Assert.Equal(-200, test.Solde);
        }
        [Fact]
        public void TestRetraitPositif()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            test.Depot(500);
            //Act
            test.Retrait(200);
            //Assert
            Assert.Equal(300, test.Solde);
        }
        [Fact]
        public void TestRetraitOVer()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            test.Depot(500);
            //Act
            SoldeInsuffisantException exception = Assert.Throws<SoldeInsuffisantException>(() => test.Retrait(2000));
            //Assert
        }
        [Fact]
        public void TestRetraitMiseNegatif()
        {
            //Arrange
            Personne doe = new Personne("Doe", "John", DateTime.Now);
            Courant test = new Courant(500, "0001", doe);
            test.Depot(500);
            test.Retrait(800);
            //Assert
            Assert.Equal(-300, test.Solde);
        }
    }
}
