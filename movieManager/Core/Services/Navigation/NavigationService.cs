using Wpf.Ui;
using Wpf.Ui.Controls;

namespace movieManager.Core.Services.Navigation;

public class NavigationService : INavigationService
{
    private INavigationView? NavigationControl { get; set; }
    
    public void Navigate(Type pageType)
    {
        NavigationControl?.Navigate(pageType);
    }

    public void SetNavigationControl(INavigationView navigation)
    {
        NavigationControl = navigation;
    }
}