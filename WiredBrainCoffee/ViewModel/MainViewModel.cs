
using System;
using System.Threading.Tasks;
using WiredBrainCoffee.Command;

namespace WiredBrainCoffee.ViewModel
{
    public class MainViewModel : ViewModelBase
    {   
        private ViewModelBase? _selectedViewModel;

		public MainViewModel(CustomersViewModel customersViewModel, ProductsViewModel productsViewModel)
		{
            CustomersViewModel = customersViewModel;
			ProductsViewModel = productsViewModel;
			SelectedViewModel = CustomersViewModel;
			SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        public CustomersViewModel CustomersViewModel { get; }
        public ProductsViewModel ProductsViewModel { get; }

        public ViewModelBase? SelectedViewModel
		{
			get { return _selectedViewModel; }
			set
			{
				_selectedViewModel = value;
				RaisePropertyChanged();
			}
		}

		public async override Task LoadAsync()
		{
			if (SelectedViewModel is not null)
			{
				await SelectedViewModel.LoadAsync();
			}
		}

		public DelegateCommand SelectViewModelCommand { get; }

        private async void SelectViewModel(object? parameter)
        {
			SelectedViewModel = parameter as ViewModelBase;
			await LoadAsync();
        }
    }
}
