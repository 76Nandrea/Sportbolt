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
    /// Interaction logic for UjVevoAblak.xaml
    /// </summary>
    public partial class UjVevoAblak : Window
    {
        public UjVevoAblak()
        {
            InitializeComponent();
        }

        private void btnMegsem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            if (txbNev.Text != "" && txbCim.Text != "")
            {
                new InsertVevoViewModel(txbNev.Text, txbCim.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }
        }
    }
}
