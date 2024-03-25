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
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Reporte();
            }
        }

        public void Reporte()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conexionEncuesta"].ConnectionString;

                int cantidadEncuestas = CantidadEncuestas(connectionString);
                lblCantidadEncuestas.Text = cantidadEncuestas.ToString();

                int cantidadCarroPropio = CantidadCarroPropio(connectionString);
                lblPersonasCarroPropio.Text = cantidadCarroPropio.ToString();

                int cantidadSinCarroPropio = cantidadEncuestas - cantidadCarroPropio;
                lblPersonasSinCarroPropio.Text = cantidadSinCarroPropio.ToString();

               
            }
            catch (Exception ex)
            {

                lblMensajeError.Text = "Error al cargar data de la base de datos: " + ex.Message;
                lblMensajeError.Visible = true;
            }

        }

        private int CantidadEncuestas(string connectionString) {
            int cantidadEncuestas = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Encuesta";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cantidadEncuestas = (int) cmd.ExecuteScalar();
                }
            }

            return cantidadEncuestas;
        }

        private int CantidadCarroPropio(string connectionString)
        {
            int cantidadCarroPropio = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Encuesta WHERE TieneCarro = 1";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cantidadCarroPropio = (int)cmd.ExecuteScalar();
                }
            }

            return cantidadCarroPropio;
        }
    }
}