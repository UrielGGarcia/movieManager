namespace movieManager.Core.Services.Navigation;
using Wpf.Ui.Controls;

public interface INavigationService
{

    void Navigate(Type pageType);

    void SetNavigationControl(INavigationView navigation);

}