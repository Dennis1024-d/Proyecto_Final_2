using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_DJPD_1167726
{
    internal class Semillas
    {
       public string nombre;
       public int tiempo;
       public double costo;
       public double ganacia;

       public Semillas(string nombre, int tiempo, double costo, double ganacia)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.costo = costo;
            this.ganacia = ganacia;
        }
    }
}
