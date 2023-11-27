using Avalonia.Controls;
using RoutedViewHostInsideTabControl.ViewModels;

namespace RoutedViewHostInsideTabControl.Views;

public partial class TransitioningContentControlDialog : Window
{
    public TransitioningContentControlDialog()
    {
        InitializeComponent();

        CompaniesView.Content = new CompaniesView
        {
            ViewModel = new CompaniesViewModel(new Screen())
        };

        EmployeesView.Content = new EmployeesView
        {
            ViewModel = new EmployeesViewModel(new Screen())
        };
    }
}