using ReactiveUI;

namespace AvaloniaApplication1.ViewModels;

public class CompaniesViewModel : ViewModelBase, IRoutableViewModel
{
    public CompaniesViewModel(IScreen screen)
    {
        HostScreen = screen;
    }

    public string[] Companies { get; } =
        { "Apple", "Microsoft", "Google", "Amazon", "Facebook", "Twitter", "LinkedIn", "Netflix", "Tesla" };

    public string? UrlPathSegment => "Companies";
    public IScreen HostScreen { get; }
}