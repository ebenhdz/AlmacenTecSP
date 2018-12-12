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
        ConexionBD conexion;
        public CategoriaModel()
        {
            conexion = new ConexionBD();
        }
        public DataSet CargarCategorias(string queryString, string connectionString)
        {
            dataSet = new DataSet();
            SqlConnection conn = conexion.ConectarBD();
            try
            {
                SqlCommand command = new SqlCommand(queryString, conn);
                adapter = new SqlDataAdapter(command);

                adapter.Fill(dataSet, "categoria");
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return dataSet = null;
            }
            finally
            {
                conexion.CerrarConn();
            }
        }

        public int NuevaCategoria(string nombre)
        {
            int filas = 0;
            string query = "INSERT INTO Categoria VALUES(@Nombre)";
            SqlConnection conn = conexion.ConectarBD();

            using (SqlCommand cmd = new SqlCommand(query))
            {
                    cmd.Parameters.AddWithValue("@Nombre", "Benito");
                    cmd.Connection = conn;
                try
                {
                    filas = cmd.ExecuteNonQuery();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }            
            }
            return filas;
        }

        public int EliminarCategoria(string categoria)
        {
            int filas = 0;
            adapter.Update(dataSet, "categoria");
            return filas;
        }
    }
}
