using ReactiveUI;

namespace RoutedViewHostInsideTabControl.ViewModels;

public class HomeViewModel : ViewModelBase
{
    public HomeViewModel()
    {
        Companies = new Screen();
        Companies.Router.NavigateAndReset.Execute(new CompaniesViewModel(Companies));
        Employees = new Screen();
        Employees.Router.NavigateAndReset.Execute(new EmployeesViewModel(Employees));
    }

    public IScreen Companies { get; }
    public IScreen Employees { get; }
}