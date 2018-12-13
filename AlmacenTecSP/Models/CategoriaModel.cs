using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace AlmacenTecSP.Models
{
    public class CategoriaModel
    {
        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private string[] parametros;
        private string[] valores;
        private int filasAfectadas;
        ConexionBD conexionBD;
        public CategoriaModel()
        {
            conexionBD = new ConexionBD();
        }
        public DataSet CargarCategorias()
        {
            return conexionBD.EjecutarVista("vCategorias");
            
        }

        public int NuevaCategoria(string nombre)
        {
            parametros = new string[] {"nombre"};
            valores = new string[]{nombre};
            return conexionBD.EjecuctarProcedimientoAlmacenado("spInsertarCategoria", parametros, valores);
        }

        public int EliminarCategoria(string categoria)
        {
            int filas = 0;
            adapter.Update(dataSet, "categorias");
            return filas;
        }

        public int ActualizarCategoria(string nombre, int id)
        {
            int filas = 0;
            string query = "UPDATE Categoria SET nombre=@Nombre, WHERE idCateg=@CategoriaId";
            SqlConnection conn = conexionBD.AbrirConn();
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@CategoriaId", id);
                cmd.Connection = conn;
                filas = cmd.ExecuteNonQuery();
                conexionBD.CerrarConn();
            }            
            return filas;
        }
    }
}
