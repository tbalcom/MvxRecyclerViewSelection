using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.ViewModels;

namespace MvxRecyclerViewSelection.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            PlanetClickCommand = new MvxCommand<PlanetViewModel>((planet) => Log.Info("Clicked planet {0}", planet.Name));
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            Planets = new MvxObservableCollection<PlanetViewModel>()
            {
                new PlanetViewModel("Mercury"),
                new PlanetViewModel("Venus"),
                new PlanetViewModel("Earth"),
                new PlanetViewModel("Mars"),
                new PlanetViewModel("Jupiter"),
                new PlanetViewModel("Saturn"),
                new PlanetViewModel("Uranus"),
                new PlanetViewModel("Neptune")
            };
        }

        public MvxObservableCollection<PlanetViewModel> Planets
        {
            get => _planets;
            set => SetProperty(ref _planets, value);
        }

        public MvxCommand<PlanetViewModel> PlanetClickCommand { get; }

        private MvxObservableCollection<PlanetViewModel> _planets = new MvxObservableCollection<PlanetViewModel>();
    }
}
