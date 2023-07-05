using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CryptoApp.Models;
using Cryptocurrency.Models;
using Cryptocurrency.Services;

namespace Cryptocurrency.ViewModels
{
    public class PriceViewModel : INotifyPropertyChanged
    {
        private PriceInfo _priceInfo;

        private ApiCoinService _apiService;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged2;

        public event EventHandler<string> ErrorOccurred;

        private string _receivedText;

        public string ReceivedText
        {
            get { return _receivedText; }
            set
            {
                if (_receivedText != value)
                {
                    _receivedText = value;
                    OnPropertyChanged2();
                }
            }
        }

        public PriceInfo PriceInfo
        {
            get { return _priceInfo; }
            set
            {
                _priceInfo = value;
                OnPropertyChanged(nameof(PriceInfo));
            }
        }
        public PriceViewModel()
        {
            _apiService = new ApiCoinService();
        }

        public async Task LoadInfo(string id)
        {
            try
            {
                PriceInfo = await _apiService.GetPriceInfo(id);
            }
            catch (Exception ex)
            {
                OnErrorOccurred("Ooops! Try again :(");
            }
        }

        private void OnErrorOccurred(string errorMessage)
        {
            ErrorOccurred?.Invoke(this, errorMessage);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged2([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

