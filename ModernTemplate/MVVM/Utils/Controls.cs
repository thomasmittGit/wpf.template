using ModernTemplate.Core;
using ModernTemplate.MVVM.ViewModel;
using System;

namespace ModernTemplate.MVVM.Utils
{
    class Controls : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public MainViewModel MainViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public DiscoveryViewModel DiscoveryViewModel { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public Controls()
        {
            MainViewModel = new MainViewModel("Reembolso Cadastro");

            HomeViewModel = new HomeViewModel();
            DiscoveryViewModel = new DiscoveryViewModel();

            CurrentView = MainViewModel;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeViewModel;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryViewModel;
            });
        }
    }
}
