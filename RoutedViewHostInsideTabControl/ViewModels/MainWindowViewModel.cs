using ReactiveUI;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Companies = new Screen();
        Companies.Router.NavigateAndReset.Execute(new CompaniesViewModel(Companies));
        Employees = new Screen();
        Employees.Router.NavigateAndReset.Execute(new EmployeesViewModel(Employees));
    }

    public IScreen Companies { get; }
    public IScreen Employees { get; }
}