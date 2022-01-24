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

namespace AutoBeheerV2
{
    /// <summary>
    /// Interaction logic for Eigenaren.xaml
    /// </summary>
    public partial class EigenarenWindow : Window
    {
        private EigenaarController eigenaarController;
        public EigenarenWindow()
        {
            InitializeComponent();

            eigenaarController = new EigenaarController();

            dgEigenaar.ItemsSource = eigenaarController.Eigenaars;

        }

        private void btnNieuwEigenaar_Click(object sender, RoutedEventArgs e)
        {
            Eigenaar eigenaar = new Eigenaar();

            eigenaar.Naam = "<invullen>";

            EigenaarWindow eigenaarWindow = new EigenaarWindow(eigenaarController, eigenaar);

            eigenaarWindow.ShowDialog();
        }

        private void btnEigenaarVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (dgEigenaar.SelectedItem != null)
            {
                eigenaarController.VerwijderenEigenaar((Eigenaar)dgEigenaar.SelectedItem);
            }
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (dgEigenaar.SelectedItem != null)
            {
                EigenaarWindow eigenaarWindow = new EigenaarWindow(eigenaarController, (Eigenaar)dgEigenaar.SelectedItem);

                eigenaarWindow.ShowDialog();
            }

        }
    }
}
