using ReactiveUI;

namespace RoutedViewHostInsideTabControl.ViewModels;

public class Screen : IScreen
{
    public RoutingState Router { get; } = new();
}