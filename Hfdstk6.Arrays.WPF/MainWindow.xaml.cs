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

        private void btnWerkdagen_Click(object sender, RoutedEventArgs e)
        {
            string[,] dagenVanDeWeek = new string[7, 3];
            dagenVanDeWeek[0, 0] = "maandag";
            dagenVanDeWeek[1, 0] = "dinsdag";
            dagenVanDeWeek[2, 0] = "woensdag";
            dagenVanDeWeek[3, 0] = "donderdag";
            dagenVanDeWeek[4, 0] = "vrijdag";
            dagenVanDeWeek[5, 0] = "zaterdag";
            dagenVanDeWeek[6, 0] = "zondag";

            dagenVanDeWeek[0, 1] = "09:00";
            dagenVanDeWeek[1, 1] = "08.00";
            dagenVanDeWeek[2, 1] = "08:00";
            dagenVanDeWeek[3, 1] = "08:00";
            dagenVanDeWeek[4, 1] = "08:00";
            dagenVanDeWeek[5, 1] = "";
            dagenVanDeWeek[6, 1] = "";

            dagenVanDeWeek[0, 2] = "18:00";
            dagenVanDeWeek[1, 2] = "17.00";
            dagenVanDeWeek[2, 2] = "12:00";
            dagenVanDeWeek[3, 2] = "17:00";
            dagenVanDeWeek[4, 2] = "16:00";
            dagenVanDeWeek[5, 2] = "";
            dagenVanDeWeek[6, 2] = "";

            string tekst = "";
            for (int rij = 0; rij < 7; rij++)
            {
                tekst += $"Op {dagenVanDeWeek[rij, 0]} werk ik "
                    + $"van {dagenVanDeWeek[rij, 1] } "
                    + $"tot {dagenVanDeWeek[rij, 2]} \n";
            }
            MessageBox.Show(tekst);


        }
    }
}
