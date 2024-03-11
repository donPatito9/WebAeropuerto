using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAeropuerto
{
    
        public class Pasajero
        {
            public string nombre;
            public string apellido;
            public string identificacion;
            public string pais;
            public string codigo;
            public int paisIndex;

            public string getNombre()
            {
                return nombre;
            }

            public string getApellido()
            {
                return apellido;
            }
            public string getIdentificacion()
            {
                return identificacion;
            }
            public string getPais()
            {
                return pais;
            }
            public string getCodigo()
            {
                return codigo;
            }

            
            public string dataView
            {
                get { return string.Format("{0} {1} {2}", nombre, apellido, identificacion); }
            }


        }
    }

