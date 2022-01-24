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
    /// Interaction logic for GebruikerWindow.xaml
    /// </summary>
    public partial class GebruikerWindow : Window
    {
        private GebruikerController _gebruikerController;

        private Gebruiker _gebruiker;

        public GebruikerWindow(GebruikerController gebruikerController, Gebruiker gebruiker)
        {
            InitializeComponent();

            _gebruikerController = gebruikerController;

            _gebruiker = gebruiker;

            this.DataContext = _gebruiker;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_gebruiker.Id == 0)
                {
                    _gebruikerController.NieuwGebruiker(_gebruiker);
                }
                else
                {
                    _gebruikerController.WijzigGebruiker(_gebruiker);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.ToString());
                MessageBox.Show($"Er is een fout opgetreden {_gebruiker.Naam}");
            }

            this.Close();
        }

    }
}
