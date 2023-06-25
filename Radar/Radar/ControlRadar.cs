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
        int i = 0;

        // public int CantidadVehiculo { get; private set; }
        public int CantidadVehiculo { get { return i; } } //me avivo y hago un getter largo

        

        public void AgregarControl(string patente, double velocidad, bool esOficial)
        {

            Vehiculo vehiculo = new Vehiculo(patente, velocidad, esOficial);

            if(esOficial == false &&  vehiculo.VerificarVelocidadInfractor() == true)
            {
                infracciones[i] = vehiculo;
                i++;
               
            }

            
        }

        public Vehiculo VerVehiculosInfractores(int idx)
        {
            return infracciones[idx];
        }

        public void MetodoBurbuja()
        {
            Vehiculo t;
            for (int a = 0; a < CantidadVehiculo; a++) //recorre todo el vector
            {
                for (int b = i+1; b < CantidadVehiculo; b++) //recorre todo el vector
                {
                    if (infracciones[a].Patente.CompareTo(infracciones[b].Patente)>0)
                    {
                        t = infracciones[a];
                        infracciones[a] = infracciones[b];
                        infracciones[b] = t;
                    }
                }
            }
        }

        public int BusquedaBinaria(string clave)
        {
                int n = 0;
                int inf = 0;
                int sup = n, centro, pos = -1;
                while (inf <= sup && pos < 0)
                {
                    centro = (inf + sup) / 2;
                    if (infracciones[centro].Patente.CompareTo(clave)>0)
                    {
                        pos = centro;
                    }
                    else
                    {
                        if (clave.CompareTo(infracciones[centro].Patente)>0)
                            
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
