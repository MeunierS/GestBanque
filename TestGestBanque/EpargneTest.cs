using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace TestGestBanque
{
    public class EpargneTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-1500)]
        [InlineData(-15.5936)]
        [InlineData(-0.5)]
        public  void TestDepot0OuMoins(double value)
        {
            //Arrange
            Personne doe= new Personne("Doe", "John", DateTime.Now);
            Epargne test = new Epargne("0001", doe);
            //Act
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => test.Depot(value));
            //Assert
            //Assert.Equal("Tentative de dépot négatif.", exception.Message);
        }
    }
}
