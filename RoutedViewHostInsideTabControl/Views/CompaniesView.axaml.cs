using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using ReactiveUI;
using RoutedViewHostInsideTabControl.ViewModels;

namespace RoutedViewHostInsideTabControl.Views;

public partial class CompaniesView : ReactiveUserControl<CompaniesViewModel>
{
    public CompaniesView()
    {
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Companies, v => v.CompaniesListBox.ItemsSource)
                .DisposeWith(disposables);
            this.Bind(ViewModel, vm => vm.SelectedItem, v => v.CompaniesListBox.SelectedItem)
                .DisposeWith(disposables);
        });
    }
}