using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using RoutedViewHostInsideTabControl.ViewModels;
using RoutedViewHostInsideTabControl.Views;
using Splat;

namespace RoutedViewHostInsideTabControl;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        Locator.CurrentMutable.Register<IScreen, Screen>();
        Locator.CurrentMutable.Register(() => new CompaniesViewModel(Locator.Current.GetService<IScreen>()!));
        Locator.CurrentMutable.Register(() => new EmployeesViewModel(Locator.Current.GetService<IScreen>()!));
        Locator.CurrentMutable.Register<IViewFor<CompaniesViewModel>, CompaniesView>();
        Locator.CurrentMutable.Register<IViewFor<EmployeesViewModel>, EmployeesView>();
        Locator.CurrentMutable.Register<IViewFor<CompanyViewModel>, CompanyView>();
        if(ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new HomeViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}