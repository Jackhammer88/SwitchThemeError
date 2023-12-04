using System;
using Avalonia.Media;
using Material.Styles.Themes;
using Material.Styles.Themes.Base;

namespace AvaloniaApplication2.Styling;

internal static class AppThemeManager
{
    private const string AppTheme = "AppTheme";
    private static Theme? _lightTheme;
    private static Theme? _darkTheme;
    private static MaterialThemeBase? _themeBootstrap;

    public static IReadOnlyTheme CurrentTheme => _themeBootstrap!.CurrentTheme;
    public static ThemeType CurrentThemeType { get; private set; }

    public static void Init(App app)
    {
        CreateLightTheme();
        CreateDarkTheme();

        _themeBootstrap = app.LocateMaterialTheme<MaterialThemeBase>();

        SwitchThemeInternal(ThemeType.Light);
    }

    private static void CreateLightTheme()
    {
        var primaryColor = Color.Parse("#020C33");
        var secondaryColor = Color.Parse("#7481B5");

        IBaseTheme baseTheme = new CustomMaterialLightTheme(
            "#DFE1E9",
            "#7481B5",
            "#394882",
            "#131F4F",
            "#020C33");

        _lightTheme = Theme.Create(baseTheme, primaryColor, secondaryColor);
    }

    private static void CreateDarkTheme()
    {
        var primaryColor = Color.Parse("#f0f0f0");
        var secondaryColor = Color.Parse("#ddac13");

        IBaseTheme baseTheme = new CustomMaterialDarkTheme();

        _darkTheme = Theme.Create(baseTheme, primaryColor, secondaryColor);
    }

    public static void SwitchTheme()
    {
        SwitchThemeInternal(CurrentThemeType == ThemeType.Light
            ? ThemeType.Dark
            : ThemeType.Light);
    }

    private static void SwitchThemeInternal(ThemeType themeType)
    {
        _themeBootstrap!.CurrentTheme = (themeType == ThemeType.Light
            ? _lightTheme
            : _darkTheme) ?? throw new InvalidOperationException("It shouldn't be null!");

        CurrentThemeType = themeType;
    }
}