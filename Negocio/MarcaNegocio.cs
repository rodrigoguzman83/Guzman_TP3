using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
			List<Marca> lista = new List<Marca>();
			Marca marca;

			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select id,Descripcion from marcas";
				comando.Connection = conexion;

				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					marca = new Marca();
					marca.Id = lector.GetInt32(0);
					marca.Nombre = lector.GetString(1);

					lista.Add(marca);
				}

				return lista;
			}
			catch (Exception ex )
			{

				throw ex;
			}
			finally
			{
				conexion.Close();
			}
        }
    }
}
