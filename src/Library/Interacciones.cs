using System;

namespace Program
{
    public static class Interacciones
    {
        public static void Ataque(Personaje atacante, Personaje atacado)
        {
            atacado.hpactualizado -= atacante.ataque - atacado.defensa

            //se le envía los datos de los personajes implicados para que se imprima en pantalla
            ConsoleLogger(atacante.nombre, atacante.arma, atacado.nombre, atacado.defensa, atacado.hpactualizado);
        }

        public static void Curacion(Personaje sanado, Personaje sanador)
        {
            sanado.hpactualizado += sanador.hechizo
            
            if (sanado.nombre == sanador.nombre)
            {
                //personaje que se sana a sí mismo
                ConsoleLogger(sanado.nombre);
            }
            else
            {
                //personaje sanado por otro
               ConsoleLogger(sanado.nombre, sanador.nombre); 
            }
             
        }

    }
}