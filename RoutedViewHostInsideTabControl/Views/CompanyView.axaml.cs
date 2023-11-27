using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using ReactiveUI;
using RoutedViewHostInsideTabControl.ViewModels;

namespace RoutedViewHostInsideTabControl.Views;

public partial class CompanyView : ReactiveUserControl<CompanyViewModel>
{
    public CompanyView()
    {
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, vm => vm.GoBackCommand, v => v.GoBackButton)
                .DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Name, v => v.CompanyNameTextBlock.Text)
                .DisposeWith(disposables);
        });
    }
}