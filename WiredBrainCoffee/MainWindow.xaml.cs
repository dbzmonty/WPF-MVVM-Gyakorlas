using System;
using System.Windows;
using WiredBrainCoffee.Data;
using WiredBrainCoffee.ViewModel;

namespace WiredBrainCoffee
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viweModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viweModel = viewModel;
            DataContext = _viweModel;
            Loaded += MainWindowLoaded;
        }

        private async void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            await _viweModel.LoadAsync();
        }
    }
}
