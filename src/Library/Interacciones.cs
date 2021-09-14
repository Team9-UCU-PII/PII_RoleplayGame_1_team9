using System;

namespace Program
{
    public static class Interacciones
    {
        public static void Ataque(Personaje atacante, Personaje atacado)
        {
            atacado.hpactualizado -= atacante.ataque - atacado.defensa

            ConsoleLogger($"El personaje {atacado.nombre} ha sido atacado por {atacante.nombre}");
        }

        public static void Curacion(Personaje sanado, Personaje sanador)
        {
            sanado.hpactualizado += sanador.hechizo
            
            if (sanado.nombre == sanador.nombre)
            {
                ConsoleLogger($"El personaje {sanado.nombre} se ha curado a sí mismo.");
            }
            else
            {
               ConsoleLogger($"El personaje {sanado.nombre} ha sido curado por {sanador.nombre}"); 
            }
             
        }

    }
}