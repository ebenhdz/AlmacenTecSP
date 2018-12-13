using AlmacenTecSP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AlmacenTecSP.Views
{
    /// <summary>
    /// Lógica de interacción para Ajustes.xaml
    /// </summary>
    public partial class Ajustes : Page
    {
        private CategoriaModel categorias;
        private ConexionBD baseDeDatos;
        public Ajustes()
        {
            InitializeComponent();
            categorias = new CategoriaModel();
            llenarTabla();
        }

        private void BtnNuevaCategoria_Click(object sender, RoutedEventArgs e)
        {
            DialogoCategoria dialogo = new DialogoCategoria();            
            if (dialogo.ShowDialog() == true)
            {
                categorias.NuevaCategoria(dialogo.Respuesta);
                llenarTabla();
            }
        }

        private void llenarTabla()
        {
            DataSet CategoriaDataSet = categorias.CargarCategorias();
            TablaCategoria.ItemsSource = CategoriaDataSet.Tables[0].DefaultView;
        }
    }
}
