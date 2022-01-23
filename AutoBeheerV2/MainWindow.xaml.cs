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

namespace AutoBeheerV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AutoControlleer autoControlleer;

        public MainWindow()
        {
            InitializeComponent();

            autoControlleer = new AutoControlleer();

            dgAutos.ItemsSource = autoControlleer.Autos;
            
        }

        private void btnEigenaren_Click(object sender, RoutedEventArgs e)
        {
            EigenarenWindow eigenarenWindow = new EigenarenWindow();

            eigenarenWindow.ShowDialog();
        }
    }
}
