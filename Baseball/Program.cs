using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Field Team";
            equipo1.jugadores.Add(new Jugador("Nelson Barrera", "1"));
            equipo1.jugadores.Add(new Jugador("Vinicio Castilla", "2"));
            equipo1.jugadores.Add(new Jugador("Benjamín Gil", "3"));
            equipo1.jugadores.Add(new Jugador("Gilberto Villarreal Solís", "4"));
            equipo1.jugadores.Add(new Jugador("Joakim Soria", "5"));
            equipo1.jugadores.Add(new Jugador("José Luis Sandoval", "6"));
            equipo1.jugadores.Add(new Jugador("Heber Gómez", "7"));
            equipo1.jugadores.Add(new Jugador("Erubiel Durazo", "8"));
            equipo1.jugadores.Add(new Jugador("Faustino Carrera", "9"));
            equipos.Add(equipo1);

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Batting Team";
            equipo2.jugadores.Add(new Jugador("Aurelio Rodríguez", "1"));
            equipo2.jugadores.Add(new Jugador("José Cobos Carrillo", "2"));
            equipo2.jugadores.Add(new Jugador("Maximino León", "3"));
            equipo2.jugadores.Add(new Jugador("Francisco Estrada Soto", "4"));
            equipo2.jugadores.Add(new Jugador("Abel Martínez", "5"));
            equipo2.jugadores.Add(new Jugador("Ricardo Sáenz de la Paz", "6"));
            equipo2.jugadores.Add(new Jugador("Fermín Vázquez", "7"));
            equipo2.jugadores.Add(new Jugador("Aurelio Monteagudo", "8"));
            equipo2.jugadores.Add(new Jugador("Yavé Estrada", "9"));
            equipos.Add(equipo2);

            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Equipo: " + elemento.Nombre);
                foreach (Jugador jugador in elemento.jugadores)
                {
                    Console.WriteLine("Nombre del jugador: " + jugador.Nombre);
                    Console.WriteLine("Numero: " + jugador.Numero);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
