using Android.OS;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvxRecyclerViewSelection.Core.ViewModels.Main;
using MvxRecyclerViewSelection.Droid.Adapters;

namespace MvxRecyclerViewSelection.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class MainFragment : BaseFragment<MainViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_main;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var recyclerView = view.FindViewById<MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView>(Resource.Id.planets);
            if (recyclerView != null)
            {
                recyclerView.Adapter = new SingleSelectionRecyclerViewAdapter((IMvxAndroidBindingContext)BindingContext);
            }

            return view;
        }
    }
}
