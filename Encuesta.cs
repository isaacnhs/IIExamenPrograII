using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaEncuesta
{
    public class Encuesta
    {
        private int NumeroEncuesta {  get; set; }

        private string Nombre {  get; set; }
        
        private string Apellido { get; set; }

        private DateTime FechaNacimiento { get; set; }
        
        private string Correo {  get; set; }

        private bool TieneCarro { get; set; }

        //constructor de inicializacion
        public Encuesta(string nombre, string apellido, DateTime fechaNacimiento, string correo, bool tieneCarro)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            TieneCarro = tieneCarro;
        }

        //setters y getters
        public int GetNumeroEncuesta() { 
            return NumeroEncuesta;
        }

        public void SetNumeroEncuesta(int numeroEncuesta)
        {
            NumeroEncuesta = numeroEncuesta;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string apellido)
        {
            Apellido = apellido;
        }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public string GetCorreo()
        {
            return Correo;
        }

        public void SetCorreo(string correo)
        {
            Correo = correo;
        }

        public bool GetTieneCarro()
        {
            return TieneCarro;
        }

        public void SetTieneCarro(bool tieneCarro)
        {
            TieneCarro = tieneCarro;
        }

//--------------------------------------------

        public bool ValidarDatosForm()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(Apellido))
            {
                return false;
            }

            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (edad < 18 || edad > 50)
            {
                return false;
            }

            if (!Correo.Contains("@"))
            {
                return false;
            }

            return true;
        }

        public void InsertarEncuesta(string connectionString)
        {
            if (!ValidarDatosForm())
            {
                throw new InvalidOperationException("Los datos de la encuesta son incorrectos..");
            }

            string query = "INSERT INTO Encuesta (Nombre, Apellido, FechaNacimiento, Correo, TieneCarro) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Correo, @TieneCarro) ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@TieneCarro", TieneCarro);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}