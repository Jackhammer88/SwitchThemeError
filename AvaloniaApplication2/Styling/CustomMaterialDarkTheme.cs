using Avalonia.Media;
using Material.Styles.Themes.Base;

namespace AvaloniaApplication2.Styling;

internal sealed class CustomMaterialDarkTheme : IBaseTheme
{
    private static readonly Color DarkBackgroundColor = Color.Parse("#1e1e1e");
    private static readonly Color LightTextColor = Color.Parse("#ddac13");
    private static readonly Color AccentColor = Color.Parse("#9f9f9f");
    private static readonly Color MediumAccentColor = Color.Parse("#d2d2d2");
    private static readonly Color DarkTextColor = Color.Parse("#f0f0f0");

    public Color MaterialValidationErrorColor { get; } = Color.Parse("#F44336");
    public Color MaterialBackgroundColor => DarkBackgroundColor;
    public Color MaterialPaperColor => DarkBackgroundColor;
    public Color MaterialCardBackgroundColor => DarkBackgroundColor;
    public Color MaterialToolBarBackgroundColor => MediumAccentColor;
    public Color MaterialBodyColor => LightTextColor;
    public Color MaterialBodyLightColor => AccentColor;
    public Color MaterialColumnHeaderColor => LightTextColor;
    public Color MaterialCheckBoxOffColor => DarkTextColor;
    public Color MaterialCheckBoxDisabledColor => DarkTextColor;
    public Color MaterialTextBoxBorderColor => DarkTextColor;
    public Color MaterialDividerColor => DarkTextColor;
    public Color MaterialSelectionColor => AccentColor;
    public Color MaterialToolForegroundColor => LightTextColor;
    public Color MaterialToolBackgroundColor => DarkBackgroundColor;
    public Color MaterialFlatButtonClickColor => AccentColor;
    public Color MaterialFlatButtonRippleColor => MediumAccentColor;
    public Color MaterialToolTipBackgroundColor => DarkTextColor;
    public Color MaterialChipBackgroundColor => MediumAccentColor;
    public Color MaterialSnackbarBackgroundColor => DarkTextColor;
    public Color MaterialSnackbarMouseOverColor => DarkTextColor;
    public Color MaterialSnackbarRippleColor => MediumAccentColor;
    public Color MaterialTextFieldBoxBackgroundColor => DarkBackgroundColor;
    public Color MaterialTextFieldBoxHoverBackgroundColor => MediumAccentColor;
    public Color MaterialTextFieldBoxDisabledBackgroundColor => DarkTextColor;
    public Color MaterialTextAreaBorderColor => LightTextColor;
    public Color MaterialTextAreaInactiveBorderColor => DarkTextColor;
    public Color MaterialDataGridRowHoverBackgroundColor => MediumAccentColor;
}