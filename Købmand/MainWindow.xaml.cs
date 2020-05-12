using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Købmand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public By NuværendeBy;
        public KøbeMand Mand;
        By Odense = new By("Odense");
        By Esbjerg = new By("Esbjerg");
        By Skagen = new By("Skagen");
        By Koebenhavn = new By("Koebenhavn");

        public void OnCityChanged(object sender, SelectionChangedEventArgs args)
        {
            NuværendeBy.SelectedCity = Sælger.SelectedItem as Varer;
        }

        public MainWindow()
        {
            InitializeComponent();
            Mand = new KøbeMand();
            Mand.Penge = 50;
            Pengeholder.DataContext = Mand;
        }

        private void Button_Click_Odense(object sender, RoutedEventArgs e)
        {
            NuværendeBy = Odense;
            Navnholder.DataContext = NuværendeBy;
            NuværendeBy.SelectedCity = Odense.ByVarer[0];
            Sælger.DataContext = NuværendeBy;
        }

        private void Button_Click_Esbjerg(object sender, RoutedEventArgs e)
        {
            NuværendeBy = Esbjerg;
            Navnholder.DataContext = NuværendeBy;
        }

        private void Button_Click_Skagen(object sender, RoutedEventArgs e)
        {
            NuværendeBy = Skagen;
            Navnholder.DataContext = NuværendeBy;
        }

        private void Button_Click_Koebenhavn(object sender, RoutedEventArgs e)
        {
            NuværendeBy = Koebenhavn;
            Navnholder.DataContext = NuværendeBy;
        }
    }
}
