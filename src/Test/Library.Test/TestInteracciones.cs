using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]
    public class ExampleTest1
    {
        [Test]
        public void TestInteracciones()
        //se testea las asignaciones corerctas funcionen y las erroneas rechazadas
        {
            Personaje danaChar = new Personaje("Danurris", "MAGO");
            Item libro1 = new Item("El principito", "LIBRO", 0, 0);
            Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 70);
            libro1.AñadirHechizo(magiaDana);
            danaChar.AddItem(libro1);
            
            Personaje marceChar = new Personaje("Isandril", "MAGO");
            Item libro2 = new Item("Arcaneum", "LIBRO", 0, 0);
            Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
            Hechizo curaMarce = new Hechizo("Poción", "Curación", 60);
            libro2.AñadirHechizo(magiaMarce);
            libro2.AñadirHechizo(curaMarce);
            marceChar.AddItem(libro2);

            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            Item arma = new Item("Mjollnir", "ARMA", 18, 0);
            Item armadura = new Item("Cota de Konan", "ARMADURA", 0, 13);
            alonsoChar.AddItem(arma);
            alonsoChar.AddItem(armadura);

            /*
            //se testea la interacción de ataque
            Interacciones.Ataque(danaChar, alonsoChar);

            string expectedNombre = "Torbjorn";
            string expectednombre = "Danurris";
            int expectedHp = 100;
            Assert.AreEqual(expectedHp, alonsoChar.HP);
            Assert.AreEqual(expectedNombre, alonsoChar.Nombre);
            Assert.AreEqual(expectednombre, danaChar.Nombre);
            */

            /*
            //se testea la interacción de ataque con lanzamiento de hechizo
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);

            string expectedName = "Torbjorn";
            string expectedname = "Danurris";
            string expectedHechizo = "Desconocerse";
            int expectedVida = 30;
            Assert.AreEqual(expectedName, alonsoChar.Nombre);
            Assert.AreEqual(expectedname, danaChar.Nombre);
            Assert.AreEqual(expectedHechizo, magiaDana.Nombre);
            Assert.AreEqual(expectedVida, alonsoChar.HP);
            */

            //se testea la interacción de ataque con lanzamiento de hechizo y curación
            Interacciones.LanzamientoHechizo(danaChar, magiaDana, alonsoChar);
            Interacciones.LanzamientoHechizo(marceChar, curaMarce, alonsoChar);

            string expectedNomb = "Torbjorn";
            string expectednomb = "Isandril";
            string expectedhechizo = "Poción";
            int expectedCura = 90;
            Assert.AreEqual(expectedNomb, alonsoChar.Nombre);
            Assert.AreEqual(expectednomb, marceChar.Nombre);
            Assert.AreEqual(expectedhechizo, curaMarce.Nombre);
            Assert.AreEqual(expectedCura, alonsoChar.HP);
        }
    }
}