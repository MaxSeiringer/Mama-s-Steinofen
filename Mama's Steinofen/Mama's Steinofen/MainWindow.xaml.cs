﻿using Mama_s_Steinofen;
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

namespace Mama_Steinofen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Switch_Login(object sender, RoutedEventArgs e)
        {
            Login objLogin = new Login();
            this.Visibility = Visibility.Hidden;
            objLogin.Show();
        }

        private void Switch_Einkaufswagen(object sender, RoutedEventArgs e)
        {
            Einkaufswagen objEinkaufswagen = new Einkaufswagen();
            this.Visibility = Visibility.Hidden;
            objEinkaufswagen.Show();
        }

        private void navigationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)navigationComboBox.SelectedItem; switch (selectedItem.Content)
            {
                case "Einkaufswagen":                    
                    //Weiterleitung
                    break;
                case "Bestellen":
                    //Weiterleitung
                    break;
                case "Kontakt":
                    //Weiterleitung
                    break;
                case "Menü":
                    //Weiterleitung
                    break;

            }
        }
    }
}
