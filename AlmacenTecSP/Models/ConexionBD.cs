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
        private SqlCommand comm;
        private DataSet ds;
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
        /// <returns>SqlConnection.</returns>
		public SqlConnection ConectarBD()
	    {
		    if(conn.State != ConnectionState.Open)
		    {
			    try 
			    {
				    conn.ConnectionString = connection;
                    conn.Open();
	            }

			    catch(Exception ex)
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
    }
}
