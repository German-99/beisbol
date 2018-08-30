using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Yaquis";
            equipo1.jugadores.Add(new Jugador("Luis Ruiz", "03"));
            equipo1.jugadores.Add(new Jugador("Jose Lopez", "05"));
            equipo1.jugadores.Add(new Jugador("Omar Gutierrez", "11"));
            equipo1.jugadores.Add(new Jugador("Juan Perez", "07"));
            equipo1.jugadores.Add(new Jugador("Kevin Valenzuela", "45"));
            equipo1.jugadores.Add(new Jugador("David Gambino", "71"));
            equipo1.jugadores.Add(new Jugador("Mario Paz", "34"));
            equipo1.jugadores.Add(new Jugador("Jesus Roman", "09"));
            equipo1.jugadores.Add(new Jugador("Rodrigo Acosta", "19"));
            equipo1.estadio = new Estadio("Thomas Oroz", "Miguel Aleman", 6782);

           
            

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Tomateros";
            equipo2.jugadores.Add(new Jugador("Antonio Esperanza", "14"));
            equipo2.jugadores.Add(new Jugador("Luis Meza", "01"));
            equipo2.jugadores.Add(new Jugador("Adrian Perez", "67"));
            equipo2.jugadores.Add(new Jugador("German Anguiano", "57"));
            equipo2.jugadores.Add(new Jugador("Alberto Rodriguez", "66"));
            equipo2.jugadores.Add(new Jugador("Arturo Camacho", "71"));
            equipo2.jugadores.Add(new Jugador("Andres Martinez", "26"));
            equipo2.jugadores.Add(new Jugador("Manuel Savedra", "81"));
            equipo2.jugadores.Add(new Jugador("Jaime Rodriguez", "22"));

            equipos.Add(equipo1);
            equipos.Add(equipo2);

            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Nombre del equipo: " + elemento.Nombre);
                foreach(Jugador jugador in elemento.jugadores)
                {
                    Console.WriteLine("Jugador: " + jugador.Nombre + "-"+ jugador.Número);
                }
                if (elemento.estadio != null)
                {
                    Console.WriteLine("Estadio: " + elemento.estadio.Nombre);
                }
                else
                {
                    Console.WriteLine("No tiene estadio");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
