using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]

    public class ExampleTest
    {

        [Test]
        public void itemCreationTest()
        {
            Item espadaAvanzada = new Item("Espada de Diamante", "ARMA", 16, 0);
            string expectedType = "ARMA";
            string expectedName = "Espada de Diamante";
            int expectedDMG = 16;
            int expectedDEF = 0;
            Assert.AreSame(expectedName, espadaAvanzada.Nombre);
            Assert.AreEqual(expectedType, espadaAvanzada.Tipo);
            Assert.AreEqual(expectedDMG, espadaAvanzada.DMG);
            Assert.AreEqual(expectedDEF, espadaAvanzada.DEF);

        }

    }


}