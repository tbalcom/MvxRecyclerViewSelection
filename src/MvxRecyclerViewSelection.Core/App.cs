using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxRecyclerViewSelection.Core.ViewModels.Main;

namespace MvxRecyclerViewSelection.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
