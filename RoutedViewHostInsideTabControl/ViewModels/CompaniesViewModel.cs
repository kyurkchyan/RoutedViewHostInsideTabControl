using System.Reactive.Disposables;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace RoutedViewHostInsideTabControl.ViewModels;

public class CompaniesViewModel : ViewModelBase, IRoutableViewModel, IActivatableViewModel
{
    public CompaniesViewModel(IScreen screen)
    {
        HostScreen = screen;
        GoToCompanyDetailsCommand = ReactiveCommand.CreateFromObservable<string, IRoutableViewModel>(company => HostScreen.Router.Navigate.Execute(new CompanyViewModel(company, screen)));
        this.WhenActivated(disposables =>
        {
            this.WhenAnyValue(vm => vm.SelectedItem)
                .Skip(1)
                .WhereNotNull()
                .InvokeCommand(GoToCompanyDetailsCommand)
                .DisposeWith(disposables);
        });
    }

    public ReactiveCommand<string, IRoutableViewModel> GoToCompanyDetailsCommand { get; }

    [Reactive]
    public string? SelectedItem { get; set; }

    public string[] Companies { get; } =
        { "Apple", "Microsoft", "Google", "Amazon", "Facebook", "Twitter", "LinkedIn", "Netflix", "Tesla" };

    public string? UrlPathSegment => "Companies";
    public IScreen? HostScreen { get; }
    public ViewModelActivator Activator { get; } = new();
}