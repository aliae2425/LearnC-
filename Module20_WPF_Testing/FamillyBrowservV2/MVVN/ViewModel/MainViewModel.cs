using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FamillyBrowservV2.MVVN.ViewModel
{
    internal class MainViewModel
    {
        private bool _isLightTheme = true;
        private bool _FilterColapsed = true;

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            _isLightTheme = !_isLightTheme;
            string newThemePath = _isLightTheme ? "/Themes/LightTheme.xaml" : "/Themes/DarkTheme.xaml";
            var newTheme = (ResourceDictionary)Application.LoadComponent(resourceLocator: new Uri(newThemePath, UriKind.Relative));
            Application.Current.Resources.MergedDictionaries.RemoveAt(2);
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            _FilterColapsed = !_FilterColapsed;

        }
    }
}
