using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using RegionNav.Views;
using System.Windows;

namespace RegionNav
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterTypeForNavigation<ChildView>();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

    }
}
