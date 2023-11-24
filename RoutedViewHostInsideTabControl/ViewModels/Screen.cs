using ReactiveUI;

namespace AvaloniaApplication1.ViewModels;

public class Screen : IScreen
{
    public RoutingState Router { get; } = new();
}