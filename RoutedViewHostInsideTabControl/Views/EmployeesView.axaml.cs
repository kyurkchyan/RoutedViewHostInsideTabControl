using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using ReactiveUI;
using RoutedViewHostInsideTabControl.ViewModels;

namespace RoutedViewHostInsideTabControl.Views;

public partial class EmployeesView : ReactiveUserControl<EmployeesViewModel>
{
    public EmployeesView()
    {
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Employees, v => v.EmployeesListBox.ItemsSource)
                .DisposeWith(disposables);
        });
    }
}