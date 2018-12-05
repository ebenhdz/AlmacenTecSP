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
            
        }
        /// <summary>
        /// guardar campos llenos con el botn guardar
        /// <summary
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            this.dc.SubmitChanges();
            isAdd = false;
        }
        /// <summary>
        /// agregar nuevo producto
        /// </summary>
         private void Add_Click(object sender, RoutedEventArgs e)
        {
            isAdd = true;
            Customer customer = (Customer)(this.CustomerView.AddNew());
            customer.CustomerID = "New";
            customer.ContactName = "";
            customer.City = "";
            customer.CompanyName = "";
            customer.Address = "";
 
            this.CustomerView.CommitNew();
            dgCustomers.ScrollIntoView(customer);
 
        }
        /// <summary>
        /// borrar un registro de la tabla
        /// </summary>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("?", "Delete", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {
                this.CustomerView.RemoveAt(this.CustomerView.CurrentPosition);
                this.dc.SubmitChanges();
            }
 
            isAdd = false;
        }
        //cancelar
         private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if(isAdd)
            {
                CustomerView.CancelNew();
                CustomerView.Remove(this.CustomerView.CurrentItem);
            }
            else
            {
                CustomerView.CancelEdit();
                dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                CustomerView.Refresh();
            }
        }
    }
}
