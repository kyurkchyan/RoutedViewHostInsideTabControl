using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using AvaloniaApplication1.ViewModels;
using ReactiveUI;

namespace AvaloniaApplication1.Views;

public partial class CompaniesView : ReactiveUserControl<CompaniesViewModel>
{
    public CompaniesView()
    {
        InitializeComponent();
        ViewModel = new CompaniesViewModel(new Screen());
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Companies, v => v.CompaniesListBox.ItemsSource)
                .DisposeWith(disposables);
        });
    }
}