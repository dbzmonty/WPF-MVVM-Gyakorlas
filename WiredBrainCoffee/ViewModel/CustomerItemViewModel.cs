using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.ViewModel
{
    public class CustomerItemViewModel : ValidationViewModelBase
    {
        private readonly Customer _model;

        public CustomerItemViewModel(Customer model)
        {
            _model = model;
        }

        public int Id { get; }

        public string? FirstName
        {
            get { return _model.FirstName; }
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();

                if (string.IsNullOrEmpty(_model.FirstName))
                {
                    AddError("Firstname is required");
                }
                else
                {
                    ClearErrors();
                }
            }
        }

        public string? LastName
        {
            get { return _model.LastName; }
            set
            {
                _model.LastName = value;
                RaisePropertyChanged();
            }
        }

        public bool IsDeveloper
        {
            get { return _model.IsDeveloper; }
            set
            {
                _model.IsDeveloper = value;
                RaisePropertyChanged();
            }
        }
    }
}
