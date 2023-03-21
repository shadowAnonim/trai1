using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Pages;
using static AvaloniaApplication1.Utils;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AppMainWindow = this;
        CurrentPage = this.FindControl<ContentControl>("Frame");
        CurrentPage.Content = new AutorisationPage();
    }

    private void ExitBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        CurrentPage = new AutorisationPage();
    }
}