using System;

namespace Program
{
    public static class Interacciones
    {
        public static void Ataque(Personaje atacante, Personaje atacado)
        {
            atacado.HP -= atacante.Ataque - atacado.Defensa;

            //se le envía los datos de los personajes implicados en ataque para que se imprima en pantalla
            ConsoleLogger.ImprimirAtaque(atacante, atacado);
        }

        public static void Curacion(Personaje sanador, Personaje sanado)
        {
            sanado.HP += sanador.Hechizo;
            
            //se le envía los datos de los personajes implicados en curación para que se imprima en pantalla
            ConsoleLogger.ImprimirAtaque(sanado, sanador);
        }
    }
}