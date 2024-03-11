using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAeropuerto
{
    public partial class Inicio : System.Web.UI.Page
    {
            PasajeroCollection registroPasajeros
        {
                get { return (PasajeroCollection)Session["_registroPasajeros"]; }
                set { Session["_registroPasajeros"] = value; }
            }

            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    if (registroPasajeros == null)
                    {
                        registroPasajeros = new PasajeroCollection();
                    }
                }

            }

            protected void btnInicio_Click(object sender, EventArgs e)
            {
                string url = "Pasajero.aspx";

                Response.Redirect(url);
            }
        }

    }


    /*  VueloCollection RegistroVuelos
  {
    get { return (VueloCollection)Session["_registroVuelos"]; }

    protected void Page_Load(object sender, EventArgs e)
   {
    /* Inicializa las colecciones en la primera llamada*/


