using Microsoft.Practices.ServiceLocation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace RegionNav.ViewModels
{
    public class ParentViewViewModel : BindableBase
    {
        public ParentViewViewModel()
        {
            // Not using DI due to legacy beast
            _regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            LoadCommand = new DelegateCommand(DoNavigate);
        }

        IRegionManager _regionManager;

        private void DoNavigate()
        {
            _regionManager.RequestNavigate("ChildRegion", "ChildView");
        }

        public DelegateCommand LoadCommand { get; set; }
    }
}
