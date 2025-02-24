using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui;
using Microsoft.Extensions.DependencyInjection;
using movieManager.Features.Welcome;
using movieManager.Core.Services.Navigation;
using movieManager.Features.DeleteMovies;
using INavigationService = movieManager.Core.Services.Navigation.INavigationService;

namespace movieManager;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow 
{
    private INavigationService _navigationService = App.Current.Services.GetService<INavigationService>()!; 
    
    public MainWindow()
    {
        InitializeComponent();
    }


}
