using Sportbolt.ViewModel;
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

namespace Sportbolt.View
{
    /// <summary>
    /// Interaction logic for UpdateVevoAblak.xaml
    /// </summary>
    public partial class UpdateVevoAblak : Window
    {
        UpdateVevoViewModel uvvm;

        public UpdateVevoAblak(object modositando)
        {
            InitializeComponent();
            uvvm = (UpdateVevoViewModel)modositando;
            DataContext = uvvm;
        }

        private void btnMegsem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            uvvm.modosit(txbNev.Text,txbCim.Text);
            Close();
        }
    }
}
