using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace FinalUWPMihirPatel
{
  
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Radiobtn1.IsChecked == true)
            {
                double Fahrenheit = Math.Round((double.Parse(tb.Text) * (9.0 / 5.0)) + 32,2);
                TextOutput.Text = Fahrenheit + string.Format("\u00B0 F");
            }

            else if (Radiobtn2.IsChecked == true)
            {
                double Celsius = Math.Round((double.Parse(tb.Text) - 32) * (5.0 / 9.0),2);
                TextOutput.Text = Celsius + string.Format("\u00B0 C");
            }
        }
    }
}
