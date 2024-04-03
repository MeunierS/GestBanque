using Models;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

namespace TestGestBanque
{
    public class PersonneTest
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("Doe", null)]
        [InlineData(null, "John")]
        public void TestIfAnyStringNull(string nom, string prenom)
        {
            //Arrange
            //Act
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Personne(nom, prenom, new DateTime(1970, 1, 1)));
            //Assert
        }
        [Fact]
        public void TestNewPerson()
        {
            //Arrange
            Personne test = new Personne("nom", "prenom", new DateTime(1970, 1, 1));
            DateTime date = new DateTime(1970, 1, 1);
            //Act

            //Assert
            Assert.Equal("nom", test.Nom);
            Assert.Equal("prenom", test.Prenom);
            Assert.Equal(date, test.DateNaiss);
        }
    }
}