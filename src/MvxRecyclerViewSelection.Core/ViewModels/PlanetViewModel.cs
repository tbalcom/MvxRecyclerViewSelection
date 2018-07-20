namespace MvxRecyclerViewSelection.Core.ViewModels
{
    public class PlanetViewModel : BaseViewModel
    {
        public PlanetViewModel(string name)
        {
            Name = name;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}
