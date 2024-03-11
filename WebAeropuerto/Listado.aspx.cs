using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAeropuerto
{
    public partial class Listado : System.Web.UI.Page
        {
            //Pasajero unPasajero;
            PasajeroCollection registroPasajeros
            {
                get { return (PasajeroCollection)Session["_registroPasajeros"]; }
                set { Session["_registroPasajeros"] = value; }
            }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasajeros();
            }
        }

            private void CargarPasajeros()
            {
                lstPasajeros.Items.Clear();
                foreach (string item in registroPasajeros.ObtenerListado())
                {
                    lstPasajeros.Items.Add(item);
                }
            }

            protected void Eliminar_Click(object sender, EventArgs e)
            {
                if (lstPasajeros.SelectedIndex != -1)
                {
                    registroPasajeros.RemoveAt(lstPasajeros.SelectedIndex);
                    CargarPasajeros();

                    lblMensaje.Text = "Pasajero eliminado correctamente";
                }
                else
                {
                    lblMensaje.Text = "Debe seleccionar un registro";
                }
            }
            protected void verRegistro_Click(object sender, EventArgs e)
            {
                if (lstPasajeros.SelectedIndex != -1)
                {
                    Response.Redirect(string.Format("Pasajero.aspx?identificacion={0}", registroPasajeros[lstPasajeros.SelectedIndex].identificacion));
                }
                else
                {
                    lblMensaje.Text = "seleccione un registro";
                }
            }
        }
    }
