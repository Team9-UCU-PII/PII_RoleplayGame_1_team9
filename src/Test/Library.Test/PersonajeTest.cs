using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]

    public class PersonajeTest
    {
      [Test]

      public void ConstruirPersonajeTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        string expectedName = "Messi";
        string expectedSpecies = "MAGO";

        Assert.AreSame(expectedName, p.Nombre);
        Assert.AreSame(expectedSpecies, p.Especie);
      }

      [Test]
      public void AddItemTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsTrue(IteminInventario);
      }

      [Test]
      public void RemoveItemTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);
        p.RemoveItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsFalse(IteminInventario);
      }

      [Test]

      public void ArmaTest()
      {
        Personaje p = new Personaje("Messi", "MAGO");
        Item i = new Item("Espada de Diamante", "ARMA", 16, 0);

        p.AddItem(i);

        Assert.AreSame(i, p.Arma);
      }
    }
}