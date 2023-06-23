using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    internal class ControlRadar
    {
        private Vehiculo[] infracciones = new Vehiculo[100];

        int i=0;
        
        public int CantidadVehiculo { get; private set; }

        public void AgregarControl(string patente, double velocidad,bool esOficial)
        {

            Vehiculo vehiculo = new Vehiculo(patente,velocidad,esOficial);

            infracciones[i] = vehiculo;
            i++;

        }

        public Vehiculo VerVehiculosInfractores(int idx)
        {
            return infracciones[idx];
        }

        public void MetodoBurbuja()
        {
            Vehiculo t;
            for (int a = 1; a < infracciones.Length-1; a++) //recorre todo el vector
            {
                for (int b = i+1; b < infracciones.Length; b++) //recorre todo el vector
                {
                    if (infracciones[a].Velocidad > infracciones[b].Velocidad)
                    {
                        t = infracciones[a];
                        infracciones[a] = infracciones[b];
                        infracciones[b] = t;
                    }
                }
            }
        }

        public int BusquedaBinaria(int[] infracciones, int n,int clave)

        {
            int inf = 0;
            int sup = n, centro, pos = -1;
            while (inf <= sup && pos < 0)
            {
                centro = (inf + sup) / 2;
                if (infracciones[centro] == clave)
                {
                    pos = centro;
                }
                else
                {
                    if (clave > infracciones[centro])
                    {
                        inf = centro + 1;
                    }
                    else
                    {
                        sup = centro - 1;
                    }
                }
            }
            return pos;
        }

    }
}
