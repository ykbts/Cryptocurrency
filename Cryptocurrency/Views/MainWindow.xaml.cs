using Cryptocurrency;
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
using Cryptocurrency.ViewModels;


namespace Cryptocurrency.Views
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += GetTop;
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }

        private async void GetTop(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadTop();
        }
        private void Click_Page2(object sender, RoutedEventArgs e)
        {
            Page2 pg = new Page2();
            pg.DataContext = new Page2ViewModel();
            this.Content = pg;
        }
    }
}