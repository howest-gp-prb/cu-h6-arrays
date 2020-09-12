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

namespace Hfdstk6.Arrays.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] leeftijden = { 18, 63, 42, 7 };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //int[] leeftijden = { 18, 63, 42, 7 };
            MessageBox.Show("De derde leeftijd is: " + leeftijden[2].ToString());

        }

        private void btnLeeftijd0_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(0);
        }

        private void btnLeeftijd1_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(1);
        }

        private void btnLeeftijd2_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(2);
        }

        private void btnLeeftijd3_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(3);
        }
        void ShowAge(int indeks)
        {
            lblLeeftijd.Content = $"Leeftijd met indeks {indeks} = {leeftijden[indeks]}";
        }

        private void btnKaaprenVaarders_Click(object sender, RoutedEventArgs e)
        {
            string[] vaarders = { "Jan", "Piet", "Joris" };
            string[] vaardersCopy = new string[3];
            vaarders.CopyTo(vaardersCopy, 0);
            vaarders = new string[4];
            vaardersCopy.CopyTo(vaarders, 0);
            vaarders[3] = "Korneel";
            string kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] + "\nDie hebben baarden, zij varen mee.";

            MessageBox.Show(kaaprenVaarders);
        }
    }
}
