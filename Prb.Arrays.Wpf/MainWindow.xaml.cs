using System.Windows;

namespace Hfdstk6.Arrays.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] ages = { 18, 63, 42, 7 };

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //int[] ages = { 18, 63, 42, 7 };
            MessageBox.Show("De derde leeftijd is: " + ages[2].ToString());
        }

        private void BtnAge0_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(0);
        }

        private void BtnAge1_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(1);
        }

        private void BtnAge2_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(2);
        }

        private void BtnAge3_Click(object sender, RoutedEventArgs e)
        {
            ShowAge(3);
        }
        void ShowAge(int index)
        {
            lblAge.Content = $"Leeftijd met index {index} = {ages[index]}";
        }

        private void BtnSailors_Click(object sender, RoutedEventArgs e)
        {
            string[] sailors = { "Jan", "Piet", "Joris" };
            string[] sailorsCopy = new string[3];
            sailors.CopyTo(sailorsCopy, 0);
            sailors = new string[4];
            sailorsCopy.CopyTo(sailors, 0);
            sailors[3] = "Korneel";
            string sailorText = sailors[0] + ", " + sailors[1] + ", " + sailors[2] + " en " + sailors[3] + "\nDie hebben baarden, zij varen mee.";

            MessageBox.Show(sailorText);
        }

        private void BtnWorkingDays_Click(object sender, RoutedEventArgs e)
        {
            string[,] daysOfTheWeek = new string[7, 3];
            daysOfTheWeek[0, 0] = "maandag";
            daysOfTheWeek[1, 0] = "dinsdag";
            daysOfTheWeek[2, 0] = "woensdag";
            daysOfTheWeek[3, 0] = "donderdag";
            daysOfTheWeek[4, 0] = "vrijdag";
            daysOfTheWeek[5, 0] = "zaterdag";
            daysOfTheWeek[6, 0] = "zondag";

            daysOfTheWeek[0, 1] = "09:00";
            daysOfTheWeek[1, 1] = "08.00";
            daysOfTheWeek[2, 1] = "08:00";
            daysOfTheWeek[3, 1] = "08:00";
            daysOfTheWeek[4, 1] = "08:00";
            daysOfTheWeek[5, 1] = "";
            daysOfTheWeek[6, 1] = "";

            daysOfTheWeek[0, 2] = "18:00";
            daysOfTheWeek[1, 2] = "17.00";
            daysOfTheWeek[2, 2] = "12:00";
            daysOfTheWeek[3, 2] = "17:00";
            daysOfTheWeek[4, 2] = "16:00";
            daysOfTheWeek[5, 2] = "";
            daysOfTheWeek[6, 2] = "";

            string text = "";
            for (int row = 0; row < 7; row++)
            {
                text += $"Op {daysOfTheWeek[row, 0]} werk ik "
                    + $"van {daysOfTheWeek[row, 1] } "
                    + $"tot {daysOfTheWeek[row, 2]} \n";
            }
            MessageBox.Show(text);

        }
    }
}
