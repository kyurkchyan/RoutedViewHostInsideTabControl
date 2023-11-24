using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using AvaloniaApplication1.ViewModels;
using ReactiveUI;

namespace AvaloniaApplication1.Views;

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