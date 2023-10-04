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

namespace Navigation_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationService nav;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow second = new SecondWindow();
            second.Closed += (s, a) => { this.Show(); };
            second.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //_mainFrame.NavigationService.Navigate(new Uri("http://www.google.com/"));
            //_mainFrame.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            _mainFrame.NavigationService.Navigate(new Page1());
            //_mainFrame.NavigationService.Navigate(new Button());
            //_mainFrame.NavigationService.Navigate("Hello world");
        }
    }
}
