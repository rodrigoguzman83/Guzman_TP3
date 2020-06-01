using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dominio
{
    public class AccesoDatos
    {
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }
        public SqlDataReader lector { get; set; }

        public AccesoDatos()
        {
            conexion = new SqlConnection(@"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void setearQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;

        }

        public void setearSP(string sp)
        {

        }

        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
        }
    }
}
