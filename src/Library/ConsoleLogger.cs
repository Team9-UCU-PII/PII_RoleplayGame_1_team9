using System;
using System.Text;

namespace Program {
    public static class ConsoleLogger {
        public static void ImprimirAtaque(Personaje atacante, Personaje atacado) {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{atacante.Nombre} atacó a {atacado.Nombre} con {atacante.Arma}.");
            sb.Append($" {atacado.Nombre} quedó con {atacado.HP} HP.");
            Console.WriteLine(sb.ToString());
        }
    }
}