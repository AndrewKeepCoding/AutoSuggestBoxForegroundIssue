using Microsoft.UI.Xaml.Controls;

namespace AutoSuggestBoxForegroundIssue;
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    public MainPageViewModel ViewModel { get; } = new();
}
