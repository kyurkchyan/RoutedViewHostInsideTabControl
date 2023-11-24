using System;
using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvaloniaApplication1;

public class NavigationPageFactory : INavigationPageFactory
{
    public NavigationPageFactory()
    {
    }

    public Control? GetPage(Type srcType)
    {
        return null;
    }

    public Control? GetPageFromObject(object target)
    {
        return ReactiveUI.ViewLocator.Current.ResolveView(target) as Control;
    }
}