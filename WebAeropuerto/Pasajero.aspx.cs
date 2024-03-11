using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAeropuerto
{
    public partial class Pasajero1 : System.Web.UI.Page
    {
        PasajeroCollection registroPasajeros
        {
            get { return (PasajeroCollection)Session["_registroPasajeros"]; }
            set { Session["_registroPasajeros"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string identificacion = Request.Params["identificacion"];
            if (identificacion != null)
            {
                btnGrabar.Visible = false;
                CargarRegistro(identificacion);
            }
            else
            {
                btnVolverlist.Visible = false;
            }

        }

        private void CargarRegistro(string identificacion)
        {
            Pasajero pasajero = registroPasajeros.ObtenerPorIdentificacion(identificacion);

            if (pasajero != null)
            {

                txtNombre.Text = pasajero.getNombre();
                txtApellido.Text = pasajero.apellido;
                txtIdentificacion.Text = pasajero.identificacion;
                ddlPais.SelectedIndex = pasajero.paisIndex;
                txtCodigo.Text = pasajero.codigo;

            }
            else
            {
                //lblMensaje.Text = "No se encontradon datos ";
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {

            Pasajero pasajero = new Pasajero()
            {
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                identificacion = txtIdentificacion.Text,
                pais = ddlPais.SelectedValue,
                paisIndex = ddlPais.SelectedIndex,
                codigo = txtCodigo.Text
            };
            registroPasajeros.Add(pasajero);
            string url = "listado.aspx";
            Response.Redirect(url);
        }
        protected void volverInicio_Click(object sender, EventArgs e)
        {
            string url = "Inicio.aspx";
            Response.Redirect(url);
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            string url = "listado.aspx";
            Response.Redirect(url);
        }


    }
}