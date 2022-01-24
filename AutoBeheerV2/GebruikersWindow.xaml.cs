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
    /// Interaction logic for GebruikersWindow.xaml
    /// </summary>
    public partial class GebruikersWindow : Window
    {
        private GebruikerController gebruikerController;

        public GebruikersWindow()
        {
            InitializeComponent();

            gebruikerController = new GebruikerController();

            dgGebruikers.ItemsSource = gebruikerController.Gebruiker;
        }

        private void btnGebruikerToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gebruiker = new Gebruiker();

            GebruikerWindow gebruikerWindow = new GebruikerWindow(gebruikerController, gebruiker);

            gebruikerWindow.ShowDialog();
        }

        private void btnGebruikerWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (dgGebruikers.SelectedItem != null) 
            {
                GebruikerWindow gebruikerWindow = new GebruikerWindow(gebruikerController, (Gebruiker)dgGebruikers.SelectedItem);

                gebruikerWindow.ShowDialog();
            }
        }

        private void btnGebruikerVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (dgGebruikers.SelectedItem != null) 
            {
                gebruikerController.VerwijderGebruiker((Gebruiker)dgGebruikers.SelectedItem);
            }
        }
    }
}
