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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AlmacenTecSP.Views;

namespace AlmacenTecSP
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<itemMenu> items = new List<itemMenu>();
            items.Add(new itemMenu() { Title = "Home", Icon = "HomeAccount"});
            items.Add(new itemMenu() { Title = "Prestamos", Icon = "PackageUp" });
            items.Add(new itemMenu() { Title = "Inventario", Icon = "PackageVariant"});
            items.Add(new itemMenu() { Title = "Proveedores", Icon = "PackageDown"});
            items.Add(new itemMenu() { Title = "Reporte", Icon = "FileDocumentOutline"});
            items.Add(new itemMenu() { Title = "Ajustes", Icon = "MixerSettings"});

            MenuList.ItemsSource = items;
            _mainFrame.Navigate(new Home());
            MenuList.SelectedIndex = 0;
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuList.SelectedIndex;
            switch (index)
            {
                case 0:
                    _mainFrame.Navigate(new Home());
                    break;
                case 1:
                    _mainFrame.Navigate(new Prestamos());
                    break;
                case 2:
                    _mainFrame.Navigate(new Inventario());
                    break;
                case 4:
                    _mainFrame.Navigate(new Reporte());
                    break;
                case 5:
                    _mainFrame.Navigate(new Ajustes());
                    break;
            }
        }
    }

    public class itemMenu
    {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
