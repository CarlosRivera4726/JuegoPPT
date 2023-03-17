using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jankenpon
{
    public class Player : Persona
    {
        private string username;
        private int puntaje;
        private int numeroPartidos;
        public Player() 
        {

        }

        public Player(string nombre, string apellido, string username)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.username = username;
        }

        public string Username { get => username; set => username = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int NumeroPartidos { get => numeroPartidos; set => numeroPartidos = value; }

        public override string ToString()
        {
            var newLine = Environment.NewLine;
            return $"Player: " + newLine + $"Nombre: {Nombre}" + $"; Apellido: {Apellido}" + newLine + $"Username: {username}" + newLine + $"Puntaje: {Puntaje}";
        }
    }
}
