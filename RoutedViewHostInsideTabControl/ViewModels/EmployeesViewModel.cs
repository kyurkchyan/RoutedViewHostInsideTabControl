using ReactiveUI;

namespace RoutedViewHostInsideTabControl.ViewModels;

public class EmployeesViewModel : ViewModelBase, IRoutableViewModel
{
    public EmployeesViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
    public string[] Employees { get; } =
        { "John", "Paul", "George", "Ringo", "Mick", "Keith", "Charlie", "Ronnie", "Bill", "Brian" };

    public string? UrlPathSegment => "Employees";
    public IScreen? HostScreen { get; }
}