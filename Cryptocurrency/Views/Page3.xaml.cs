using Cryptocurrency.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private PriceViewModel viewModel;
        public Page3(string text1) 
        {
            InitializeComponent();
            viewModel = new PriceViewModel();
            DataContext = viewModel;
            Loaded += Page_Loaded;
            viewModel.ErrorOccurred += ViewModel_ErrorOccurred;
            viewModel.ReceivedText = text1;
        }
       
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            await viewModel.LoadInfo(viewModel.ReceivedText);
        }

        private void Click_Usd(object sender, RoutedEventArgs e)
        {
            Price.Text = $"Price: {viewModel.PriceInfo.Tickers.FirstOrDefault().ConvertedLast.Usd}";
        }
        private void Click_Btc(object sender, RoutedEventArgs e)
        {
            Price.Text = $"Price: {viewModel.PriceInfo.Tickers.FirstOrDefault().ConvertedLast.Btc}";
        }
        private void Click_Eth(object sender, RoutedEventArgs e)
        {
            Price.Text = $"Price: {viewModel.PriceInfo.Tickers.FirstOrDefault().ConvertedLast.Eth}";
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            });

            e.Handled = true;
        }
        private void GoHome(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();

        }
        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Frame3.Navigate(new Page2());
        }
        private void ViewModel_ErrorOccurred(object sender, string errorMessage)
        {
            MessageBox.Show(errorMessage);
            NavigationService.Navigate(new Page2());
        }

    }
}
