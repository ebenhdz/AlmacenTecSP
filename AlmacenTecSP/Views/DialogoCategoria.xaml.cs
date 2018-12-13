using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AlmacenTecSP.Views
{
    /// <summary>
    /// Lógica de interacción para DialogoCategoria.xaml
    /// </summary>
    public partial class DialogoCategoria : Window
    {
        public DialogoCategoria()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreCategoria.Text == string.Empty)
                MessageBox.Show("Ingrese un nombre");
            else
                this.DialogResult = true;
        }
        public string Respuesta
        {
            get { return txtNombreCategoria.Text; }
        }
    }
}
