﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

        private EigenaarController eigenaarController;

        public MainWindow()
        {
            InitializeComponent();

            autoControlleer = new AutoControlleer();

            eigenaarController = new EigenaarController();

            dgAutos.ItemsSource = autoControlleer.Autos;

            //IPrincipal p = new GenericPrincipal(new GenericIdentity("Finn"), new[] { "User", "Admin" });

            //p.IsInRole("Admin");
        }

        private void btnEigenaren_Click(object sender, RoutedEventArgs e)
        {
            EigenarenWindow eigenarenWindow = new EigenarenWindow();

            eigenarenWindow.ShowDialog();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (dgAutos.SelectedItem != null) 
            {
                AutosWindow autosWindow = new AutosWindow(autoControlleer, eigenaarController, (Auto)dgAutos.SelectedItem);

                autosWindow.ShowDialog();
            }
        }

        private void btnNieuwAuto_Click(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();

            auto.Bouwjaar = DateTime.Now;
            auto.Prijs = 0;
           
            AutosWindow autosWindow = new AutosWindow(autoControlleer, eigenaarController, auto);

            autosWindow.ShowDialog();
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (dgAutos.SelectedItem != null) 
            {
                autoControlleer.VerwijderAuto((Auto)dgAutos.SelectedItem);
            }
        }

        private void btnGebruiker_Click(object sender, RoutedEventArgs e)
        {
            GebruikersWindow gebruikersWindow = new GebruikersWindow();

            gebruikersWindow.ShowDialog();
        }
    }
}
