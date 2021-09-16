using System;
using System.Collections;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            popularCatalogoItems();

            foreach (Item item in catalogoItems)
            {
                Console.WriteLine(item.Nombre);
                if (item.Tipo == "LIBRO")
                {
                    Console.WriteLine(item.VerHechizosGuardados());
                }
            }
        }

        private static ArrayList catalogoItems = new ArrayList();

        private static void popularCatalogoItems()
        {
            agregarItemAlCatalogo("Espada de Madera", "ARMA", 8, 0);
            agregarItemAlCatalogo("Espada de Diamante", "ARMA", 16, 0);
            agregarItemAlCatalogo("Armadura de Cuero", "ARMADURA", 0, 4);
            agregarItemAlCatalogo("Armadura de Acero", "ARMADURA", 0, 8);
            agregarItemAlCatalogo("Libro de Curación", "LIBRO", 0, 0);
            Hechizo smallCure = new Hechizo ("Cura Pequeña", "Curación", 10);
            GetItem("Libro de Curación").AñadirHechizo(smallCure);
            agregarItemAlCatalogo("Libro de Hechizos de Fuego", "LIBRO", 0, 0);
            Hechizo smallDmg = new Hechizo ("Bola de Fuego pequeña", "Daño", 12);
            GetItem("Libro de Hechizos de Fuego").AñadirHechizo(smallDmg);
            agregarItemAlCatalogo("Libro Maestro de Magia", "LIBRO", 0, 0);
            Hechizo bigCure = new Hechizo ("Sanación Profunda", "Curación", 20);
            Hechizo bigDmg = new Hechizo ("Misil mágico", "Daño", 22);
            GetItem("Libro Maestro de Magia").AñadirHechizo(bigCure);
            GetItem("Libro Maestro de Magia").AñadirHechizo(bigDmg);
        }

        private static void agregarItemAlCatalogo(string name, string tipo, int daño, int def)
        {
            catalogoItems.Add(new Item(name, tipo, daño, def));
        }

        private static Item GetItem(string nombreItem)
        {
            var query = from Item item in catalogoItems where item.Nombre == nombreItem select item;
            return query.FirstOrDefault();
        }
    }
}
