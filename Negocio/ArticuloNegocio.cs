using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo art;

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Id,a.Codigo,a.Nombre,a.Descripcion,a.IdCategoria,c.Descripcion,a.IdMarca,b.Descripcion,a.ImagenUrl,a.Precio from ARTICULOS a inner join MARCAS b on b.Id = a.IdMarca inner join CATEGORIAS c on c.Id = a.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    art = new Articulo();
                    art.Id = lector.GetInt32(0);
                    art.Codigo = lector.GetString(1);
                    art.Nombre = lector.GetString(2);
                    art.Descripcion = lector.GetString(3);

                    art.Categorias = new Categoria();
                    art.Categorias.Id = lector.GetInt32(4);
                    art.Categorias.Nombre = lector.GetString(5);

                    art.Marcas = new Marca();
                    art.Marcas.Id = lector.GetInt32(6);
                    art.Marcas.Nombre = lector.GetString(7);
                    art.Imagen = lector.GetString(8);
                    art.Precio = lector.GetDecimal(9);

                    lista.Add(art);

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

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdCategoria=@idCategoria,IdMarca=@idMarca,ImagenURL=@imagen,Precio=@precio where Id=@id");
                datos.agregarParametro("@id", articulo.Id);
                datos.agregarParametro("@codigo", articulo.Codigo);
                datos.agregarParametro("@nombre", articulo.Nombre);
                datos.agregarParametro("@descripcion", articulo.Descripcion);
                datos.agregarParametro("@idCategoria", articulo.Categorias.Id);
                datos.agregarParametro("@idMarca", articulo.Marcas.Id);
                datos.agregarParametro("@imagen", articulo.Imagen);
                datos.agregarParametro("@precio", articulo.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from ARTICULOS where Id=" + id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Agregar(Articulo nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = @"data source =.\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into ARTICULOS values (@codigo,@nombre,@descripcion,@idCategoria,@idMarca,@imagen,@precio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", nuevo.Codigo);
                comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                comando.Parameters.AddWithValue("@idCategoria", nuevo.Categorias.Id);
                comando.Parameters.AddWithValue("@idMarca", nuevo.Marcas.Id);
                comando.Parameters.AddWithValue("@imagen", nuevo.Imagen);
                comando.Parameters.AddWithValue("@precio", nuevo.Precio);
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();

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

        public List<Articulo> listarNuevo()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo art;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select a.Id,a.Codigo,a.Nombre,a.Descripcion,a.IdCategoria,c.Descripcion,a.IdMarca,b.Descripcion,a.ImagenUrl,a.Precio from ARTICULOS a inner join MARCAS b on b.Id = a.IdMarca inner join CATEGORIAS c on c.Id = a.IdCategoria order by a.codigo ");
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    art = new Articulo();
                    art.Id = datos.lector.GetInt32(0);
                    art.Codigo = datos.lector.GetString(1);
                    art.Nombre = datos.lector.GetString(2);
                    art.Descripcion = datos.lector.GetString(3);

                    art.Categorias = new Categoria();
                    art.Categorias.Id = datos.lector.GetInt32(4);
                    art.Categorias.Nombre = datos.lector.GetString(5);

                    art.Marcas = new Marca();
                    art.Marcas.Id = datos.lector.GetInt32(6);
                    art.Marcas.Nombre = datos.lector.GetString(7);
                    art.Imagen = datos.lector.GetString(8);
                    art.Precio = datos.lector.GetDecimal(9);

                    lista.Add(art);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
