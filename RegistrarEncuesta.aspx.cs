using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaEncuesta
{
    public partial class RegistrarEncuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int numeroEncuesta = obtenerNumeroEncuesta()+1;
            lblNumeroEncuesta.Text = "Encuesta: #" + numeroEncuesta.ToString();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreEncuesta = txtNombreEncuesta.Text;
            string apellidoEncuesta = txtApellidoEncuesta.Text;
            DateTime fechaNacimiento;
            string correo = txtCorreo.Text;
            bool tieneCarro;

            if (string.IsNullOrEmpty(nombreEncuesta))
            {
                lblMensaje.Text = "El campo nombre está vacío, por favor rellene el campo nombre";
                lblMensaje.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(apellidoEncuesta))
            {
                lblMensaje.Text = "El campo apellido está vacío, por favor rellene el campo apellido";
                lblMensaje.Visible = true;
                return;
            }

            if (!DateTime.TryParse(txtFechaNacimiento.Text, out fechaNacimiento))
            {
                lblMensaje.Text = "La fecha de nacimiento es inválida";
                lblMensaje.Visible = true;
                return;
            }

            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (edad < 18 || edad>50)
            {
                lblMensaje.Text = "La edad inválida, la edad debe estar entre 18 y 50 años";
                lblMensaje.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(correo))
            {
                lblMensaje.Text = "El campo correo electrónico está vacío, por favor rellene el campo correctamente";
                lblMensaje.Visible = true;
                return;
            }

            if (radioCarro.SelectedIndex == -1)
            {
                lblMensaje.Text = "Por favor seleccione si tiene carro propio o no";
                lblMensaje.Visible = true;
                return;
            }

            tieneCarro = radioCarro.SelectedValue == "true";

            try
            {
                Encuesta nuevaEncuesta = new Encuesta(nombreEncuesta,apellidoEncuesta,fechaNacimiento, correo,tieneCarro);

                if (!nuevaEncuesta.ValidarDatosForm())
                {
                    lblMensaje.Text = "Los datos de la encuesta son inválidos";
                    lblMensaje.Visible = true;
                    return;
                }


                nuevaEncuesta.InsertarEncuesta(ConfigurationManager.ConnectionStrings["conexionEncuesta"].ConnectionString);
                lblMensaje.Text = "La encuesta fue guardada con éxito";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Visible = true;

                //txtNumeroEncuesta.Text = nuevaEncuesta.GetNumeroEncuesta().ToString();

            }
            catch (Exception)
            {

                lblMensaje.Text = "Ha ocurrido un error al guardar la encuesta";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
            }


        }

        public int obtenerNumeroEncuesta()
        {
            int numeroEncuesta = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionEncuesta"].ConnectionString))
            {
                string query = "SELECT MAX(NumeroEncuesta) FROM Encuesta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    numeroEncuesta = Convert.ToInt32(resultado);
                }
            }

            return numeroEncuesta;
        }
    }
}