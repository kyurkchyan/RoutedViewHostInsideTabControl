using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RoutedViewHostInsideTabControl.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void OnNavigationHostSampleClicked(object? sender, RoutedEventArgs e)
    {
        var navigationHostDialog = new NavigationHostDialog();
        await  navigationHostDialog.ShowDialog(this);
    }

    private async void OnTransitioningContentControlSampleClicked(object? sender, RoutedEventArgs e)
    {
        var transitioningContentControlDialog = new TransitioningContentControlDialog();
        await transitioningContentControlDialog.ShowDialog(this);
    }

    private async void OnRoutedViewHostSampleClicked(object? sender, RoutedEventArgs e)
    {
        var routedViewHostDialog = new RoutedViewHostDialog();
        await routedViewHostDialog.ShowDialog(this);
    }
}