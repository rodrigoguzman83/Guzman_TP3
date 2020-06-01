using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
			List<Categoria> lista = new List<Categoria>();
			Categoria cat;

			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select id,Descripcion from categorias";
				comando.Connection = conexion;

				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					cat = new Categoria();
					cat.Id =lector.GetInt32(0);
					cat.Nombre = lector.GetString(1);

					lista.Add(cat);
				}

				return lista;
			}
			catch (Exception ex)
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
