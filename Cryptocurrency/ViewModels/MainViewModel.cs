using Cryptocurrency.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cryptocurrency.Services;

namespace Cryptocurrency.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private CoinTop _coinTop;

        private  ApiCoinService _apiService;

        public event PropertyChangedEventHandler PropertyChanged;
        public CoinTop CoinTop
        {
            get { return _coinTop; }
            set
            {
                _coinTop = value;
                OnPropertyChanged(nameof(CoinTop));
            }
        }
        public MainViewModel()
        {
            _apiService = new ApiCoinService();
        }

        public async Task LoadTop()
        {
            try
            {
                CoinTop = await _apiService.GetTop();
            }
            catch (Exception ex)
            {
                throw new Exception("API error");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
