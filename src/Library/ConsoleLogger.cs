using System;
using System.Text;

namespace Program {
    public static class ConsoleLogger {
        public static void ImprimirAtaque(Personaje atacante, Personaje atacado) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{atacante.Nombre} atacó a {atacado.Nombre} con {atacante.Arma}.");
            if (atacado.HP > 0) {
                sb.Append($" {atacado.Nombre} quedó con {atacado.HP} HP.");
            }
            else {
                sb.Append($" {atacado.Nombre} ha muerto.");
            }
            Console.WriteLine(sb.ToString());
        }

        public static void ImprimirCuracion(Personaje curador, Personaje curado) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{curador.Nombre} curó a {curado.Nombre}.");
            sb.Append($" {curado.Nombre} quedó con {curado.HP} HP.");
            Console.WriteLine(sb.ToString());
        }

        public static void ImprimirLanzamientoHechizo(Personaje lanzador, Hechizo hechizo, Personaje objetivo) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{lanzador.Nombre} lanzó el hechizo {hechizo.Nombre} a {objetivo.Nombre}, ");
            switch (hechizo.TipoEfecto) {
                case "Daño":
                    sb.Append($"causándole {hechizo.Poder} puntos de daño.");
                    break;
                case "Curación":
                    sb.Append($"curándole {hechizo.Poder} puntos de vida.");
                    break;
            }
            sb.Append($" {objetivo.Nombre} quedó con {objetivo.HP} HP.");
            if (objetivo.HP == 0) {
                sb.Append($" {objetivo.Nombre} ha muerto.");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}