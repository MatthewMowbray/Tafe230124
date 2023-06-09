﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Tafe_Universal_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();
        }

        private void Button_ClickMathsCalculator(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_ClickMorgageCalculator(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MorgageCalculator));
        }

        private void Button_ClickCurrencyConverter(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(CurrencyConverter));
        }

        private void tripCalculatorTrip_Click(object sender, RoutedEventArgs e)
        {
            //Trip Calculator code to be added later
        }

        private async void ButtonCalculatorScientific_Click(object sender, RoutedEventArgs e)
        {
            
            var dialogMessage = new MessageDialog("Scientific Calculator, coming soon");
            await dialogMessage.ShowAsync();
            return;
           

        }
    }
}
