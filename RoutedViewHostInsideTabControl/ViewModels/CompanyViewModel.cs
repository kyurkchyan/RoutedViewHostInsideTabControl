using System.Reactive;
using ReactiveUI;

namespace RoutedViewHostInsideTabControl.ViewModels;

public class CompanyViewModel : ReactiveObject, IRoutableViewModel
{
    public string Name { get; }

    public CompanyViewModel(string name, IScreen hostScreen)
    {
        Name = name;
        HostScreen = hostScreen;
        GoBackCommand = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.NavigateBack.Execute());
    }

    public ReactiveCommand<Unit, IRoutableViewModel> GoBackCommand { get; }

    public string? UrlPathSegment => "Company";
    public IScreen HostScreen { get; }
}