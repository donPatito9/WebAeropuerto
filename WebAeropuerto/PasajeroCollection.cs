using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAeropuerto
{
    public class PasajeroCollection : List<Pasajero>
    {
        public bool Visible { get; internal set; }

        public List<string> ObtenerListado()
        {
            List<string> listado = new List<string>();
            foreach (Pasajero item in this)
            {
                listado.Add(item.dataView);
            }
                return listado;
        }
        public int ObtenerIndice(Pasajero pasajero)
            {
               return this.IndexOf(pasajero);
            }
        public Pasajero ObtenerPorIdentificacion(string ident)           {            if (this.Count(p => p.identificacion == ident) != 0)            {                return this.Where(p => p.identificacion == ident).ToList<Pasajero>()[0];            }            else            {                return null;            }        }
    }
}