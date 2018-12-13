using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace AlmacenTecSP.Models
{
    class ConexionBD
    {
        private string connection = string.Empty;
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private int filasAfectadas;
        public ConexionBD()
        {
            conn = new SqlConnection();
            try
            {
                connection = ConfigurationManager.ConnectionStrings["AlmacenTecSPConnectionString"].ConnectionString;

            }
            catch
            {
                connection = ConfigurationManager.AppSettings.Get(connection);
            }
        }
        /// <summary>
        /// Abre la conexion con la Base de Datos
        /// </summary>
        /// <returns>Devuelve el SqlConnection.</returns>
		public SqlConnection AbrirConn()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.ConnectionString = connection;
                    conn.Open();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return conn;
        }

        public void CerrarConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataSet DataSetProcedimientoAlmacenado(string nombreTabla, string nombreProcedimientoAlmacenado, string[] parametros, object[] valorParametros)
        {
            dataSet = new DataSet();
            try {                
                command = new SqlCommand(nombreProcedimientoAlmacenado, conn);
                command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < parametros.Length; i++)
                {
                    command.Parameters.AddWithValue(parametros[i], valorParametros[i]);
                }

                AbrirConn();
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, nombreTabla);
            } catch {
                dataSet = null;
            } finally {
                CerrarConn();
            }
            return dataSet;
        }

        public int EjecuctarProcedimientoAlmacenado(string nombreProcedimientoAlmacenado, string[] parametros, object[] valorParametros)
        {
            dataSet = new DataSet();
            try {                
                command = new SqlCommand(nombreProcedimientoAlmacenado, conn);
                command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < parametros.Length; i++)
                {
                    command.Parameters.AddWithValue(parametros[i], valorParametros[i]);
                }
                //Ejecucion del comando
                AbrirConn();
                filasAfectadas = command.ExecuteNonQuery();
            }
            catch {
                filasAfectadas = 0;
            }
            finally {
                CerrarConn();
            }
            return filasAfectadas;
        }

        public DataSet EjecutarVista(string nombreVista)
        {

            string vista = string.Format("SELECT * FROM {0};", nombreVista);
            dataSet = new DataSet();
            SqlConnection conn = AbrirConn();
            try
            {
                SqlCommand command = new SqlCommand(vista, conn);
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "vCategorias");
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return dataSet = null;
            }
            finally
            {
                CerrarConn();
            }
        }
    }
}
