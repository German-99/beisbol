using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Número { get; set; }
        public Jugador()
        {
            Nombre = "Nuevo jugador";
            Número = "0";
        }
        public Jugador(string nombre, string número)
            {
            Nombre = nombre;
            Número = número;
            }
    }
}
