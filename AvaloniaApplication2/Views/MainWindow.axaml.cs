using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Styling;

namespace AvaloniaApplication2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        AppThemeManager.SwitchTheme();
    }
}