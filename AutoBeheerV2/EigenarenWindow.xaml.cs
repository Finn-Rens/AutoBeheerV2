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
    }
}
