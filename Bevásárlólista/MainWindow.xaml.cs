using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bevásárlólista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Termekek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            lb_termekek.ItemsSource = Termekek;
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {

            if (tb.Text == "")
            {
                MessageBox.Show("Kérlek adj meg egy termék nevet!", "Hibás művelet!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Termekek.Add(tb.Text);
                lb_termekek.ItemsSource = Termekek;
                tetel.Content = $"Összesen {Termekek.Count} termék van a listában.";
                lb_termekek.Items.Refresh();
                tb.Clear();
            }
        }

        private void torol_Click(object sender, RoutedEventArgs e)
        {
            string kivalasztott = "" + lb_termekek.SelectedItem;
            if (kivalasztott != "")
            {
                if (MessageBox.Show($"Biztosan törölni kívánja törölni a {kivalasztott} elemet?", "Figyelmeztetés!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Termekek.Remove(kivalasztott);
                    tetel.Content = $"Összesen {Termekek.Count} termék van a listában.";
                    lb_termekek.ItemsSource = Termekek;
                    lb_termekek.Items.Refresh();
                }

            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Figyelmeztetés!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            kivalasztott = "";
        }

        private void alltorol_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Biztosan törölni kívánja az összes terméket?", "Figyelmeztetés!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Termekek.Clear();
                tetel.Content = $"Összesen {Termekek.Count} termék van a listában.";
                lb_termekek.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Az összes termék tölése megszakítva!", "Figyelmeztetés!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void lb_Termekek(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}