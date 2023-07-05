using Cryptocurrency.ViewModels;
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


namespace Cryptocurrency.Views
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private Page2ViewModel _viewModel;
        public Page2()
        {
            InitializeComponent();
            _viewModel = new Page2ViewModel();
            DataContext = _viewModel;
        }

        public void ReadTextBoxText()
        {
            string text1 = TextBox1.Text;
        }
        private void Click_Page3(object sender, RoutedEventArgs e)
        {
            _viewModel.Text = TextBox1.Text;
            Frame2.Navigate(new Page3(_viewModel.Text));
        }
        private void GoHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();

        }
    }
}
