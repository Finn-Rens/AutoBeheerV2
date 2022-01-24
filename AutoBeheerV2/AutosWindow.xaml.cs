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
    /// Interaction logic for AutosWindow.xaml
    /// </summary>
    public partial class AutosWindow : Window
    {
        private AutoControlleer _autoController;

        private Auto _auto;

        private EigenaarController _eigenaarController;

        //private Eigenaar _eigenaar;
        //private AutoControlleer autoControlleer;
        //private Auto selectedItem;

        public AutosWindow(AutoControlleer autoControlleer, EigenaarController eigenaarController, Auto auto)
        {
            InitializeComponent();

            _autoController = autoControlleer;

            _eigenaarController = eigenaarController;

            _auto = auto;

            this.DataContext = _auto;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
             try 
            {
                if (_auto.Id == 0)
                {
                    _autoController.NieuwAuto(_auto);
                }
                else 
                {
                    _autoController.WijzigenAuto(_auto);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Er is een fout opgetreden {_auto.Kenteken} ");
            }

            this.Close();
        }

        public Auto Auto { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbEigenaar.ItemsSource = _eigenaarController.Eigenaars;
        }
    }
}
