using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Radar
{
    internal class Vehiculo
    {
        public string Patente { get; private set; }

        public double Velocidad { get; private set; }

        public bool EsOficial { get; private set; }


        public Vehiculo(string patente, double velocidad, bool esOficial)
        {
            Patente = patente;
            Velocidad = velocidad;
            EsOficial = esOficial;

        }

        public bool VerificarVelocidadInfractor()
        {
            bool Infractor = false;
            if (Velocidad < 50 &&  Velocidad > 90)
            {
                Infractor = true;
            }

            return Infractor;
        }
    }
}
