﻿using System;
using System.Collections;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            popularCatalogoItems();

    //los personajes los ideaban cada integrante, Alonso solo escribió la implementación
            Personaje maxiChar = new Personaje("Legolas", "ELFO");
            agregarItemAlCatalogo("Arco élfico", "ARMA", 14, 0);
            agregarItemAlCatalogo("Cota de Malla élfica", "ARMADURA", 0, 8);
            maxiChar.AddItem(GetItem("Arco élfico"));
            maxiChar.AddItem(GetItem("Cota de Malla élfica"));

            Personaje danaChar = new Personaje("Danurris", "MAGO");
            agregarItemAlCatalogo("El principito", "LIBRO", 0, 0);
                Hechizo magiaDana = new Hechizo("Desconocerse", "Daño", 69);
                GetItem("El principito").AñadirHechizo(magiaDana);
            danaChar.AddItem(GetItem("Armadura de Acero"));
            danaChar.AddItem(GetItem("El principito"));
            
            Personaje marceChar = new Personaje("Isandril", "MAGO");
            agregarItemAlCatalogo("Arcaneum", "LIBRO", 0, 0);
                Hechizo magiaMarce = new Hechizo("Tormenta de Arena", "Daño", 45);
                GetItem("Arcaneum").AñadirHechizo(magiaMarce);
            agregarItemAlCatalogo("Toga de Fuego", "ARMADURA", 0, 12);
            marceChar.AddItem(GetItem("Toga de Fuego"));
            marceChar.AddItem(GetItem("Arcaneum"));

            Personaje alonsoChar = new Personaje("Torbjorn", "ENANO");
            agregarItemAlCatalogo("Mjollnir", "ARMA", 18, 0);
            agregarItemAlCatalogo("Cota de Konan", "ARMADURA", 0, 15);
            alonsoChar.AddItem(GetItem("Mjollnir"));
            alonsoChar.AddItem(GetItem("Cota de Konan"));

        }

        private static ArrayList catalogoItems = new ArrayList(); 
        //por si alguno le falta inspiracion

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
