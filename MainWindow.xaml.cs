using Sportbolt.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sportbolt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vevoTablaFeltolto();
        }
        private void vevoTablaFeltolto()
        {
            VevoTablaViewModel vtvm = new VevoTablaViewModel();
            dgRacsVevo.ItemsSource = vtvm.Vevok;
        }

        private void btnBezar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUjvevo_Click(object sender, RoutedEventArgs e)
        {
            UjVevoAblak ujablak = new UjVevoAblak();
            ujablak.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            vevoTablaFeltolto();
        }

        private void btnDeleteVevo_Click(object sender, RoutedEventArgs e)
        {
            if (dgRacsVevo.SelectedIndex > -1)
            {
                DeletVevoViewModel dvvm = new DeletVevoViewModel(dgRacsVevo.SelectedItem);
                DeletVevoAblak ujablak = new DeletVevoAblak(dvvm);
                ujablak.Show();
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott vevő!");
            }
        }

        private void btnUpdateVevo_Click(object sender, RoutedEventArgs e)
        {
            if (dgRacsVevo.SelectedIndex > -1)
            {
                UpdateVevoViewModel dvvm = new UpdateVevoViewModel(dgRacsVevo.SelectedItem);
                UpdateVevoAblak ujablak = new UpdateVevoAblak(dvvm);
                ujablak.Show();
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott vevő!");
            }
        }
    }
    }
    

