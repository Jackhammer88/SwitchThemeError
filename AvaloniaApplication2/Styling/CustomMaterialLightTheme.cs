using Avalonia.Media;
using Material.Styles.Themes.Base;

namespace AvaloniaApplication2.Styling;

internal sealed class CustomMaterialLightTheme : IBaseTheme
{
    public CustomMaterialLightTheme(
        string backgroundColor,
        string accentColor,
        string mediumAccentColor,
        string darkTextColor,
        string darkestAccentColor,
        string validationErrorColor = "#F44336")
    {
        MaterialBackgroundColor = Color.Parse(backgroundColor);
        MaterialToolBarBackgroundColor = Color.Parse(accentColor);
        MaterialBodyLightColor = Color.Parse(mediumAccentColor);
        MaterialBodyColor = Color.Parse(darkTextColor);
        MaterialColumnHeaderColor = Color.Parse(darkestAccentColor);
        MaterialValidationErrorColor = Color.Parse(validationErrorColor);
    }

    public Color MaterialValidationErrorColor { get; }

    public Color MaterialBackgroundColor { get; }

    public Color MaterialPaperColor => MaterialBackgroundColor;
    public Color MaterialCardBackgroundColor => MaterialBackgroundColor;
    public Color MaterialToolBarBackgroundColor { get; }

    public Color MaterialBodyColor { get; }

    public Color MaterialBodyLightColor { get; }

    public Color MaterialColumnHeaderColor { get; }

    public Color MaterialCheckBoxOffColor => MaterialToolBarBackgroundColor;
    public Color MaterialCheckBoxDisabledColor => MaterialBodyLightColor;
    public Color MaterialTextBoxBorderColor => MaterialColumnHeaderColor;
    public Color MaterialDividerColor => MaterialBodyLightColor;
    public Color MaterialSelectionColor => MaterialToolBarBackgroundColor;
    public Color MaterialToolForegroundColor => MaterialColumnHeaderColor;
    public Color MaterialToolBackgroundColor => MaterialBackgroundColor;
    public Color MaterialFlatButtonClickColor => MaterialToolBarBackgroundColor;
    public Color MaterialFlatButtonRippleColor => MaterialBodyLightColor;
    public Color MaterialToolTipBackgroundColor => MaterialColumnHeaderColor;
    public Color MaterialChipBackgroundColor => MaterialToolBarBackgroundColor;
    public Color MaterialSnackbarBackgroundColor => MaterialBodyColor;
    public Color MaterialSnackbarMouseOverColor => MaterialColumnHeaderColor;
    public Color MaterialSnackbarRippleColor => MaterialToolBarBackgroundColor;
    public Color MaterialTextFieldBoxBackgroundColor => MaterialBackgroundColor;
    public Color MaterialTextFieldBoxHoverBackgroundColor => MaterialToolBarBackgroundColor;
    public Color MaterialTextFieldBoxDisabledBackgroundColor => MaterialBodyLightColor; //
    public Color MaterialTextAreaBorderColor => MaterialColumnHeaderColor;
    public Color MaterialTextAreaInactiveBorderColor => MaterialBodyColor;
    public Color MaterialDataGridRowHoverBackgroundColor => MaterialToolBarBackgroundColor;
}