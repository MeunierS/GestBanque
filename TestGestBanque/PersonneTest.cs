using Models;
using Newtonsoft.Json.Linq;
using Xunit.Sdk;

namespace TestGestBanque
{
    public class PersonneTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("Doe", "")]
        [InlineData("", "John")]

        public void TestIfAnyStringNull(string nom, string prenom)
        {
            //Arrange

            //Act
            NullReferenceException exception = Assert.Throws<NullReferenceException>(() => new Personne(nom, prenom, new DateTime(1970, 1, 1)));
            //Assert

        }

        
    }
}