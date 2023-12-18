using System.Drawing;
using System.Windows.Forms;

namespace glowberry.ui.render;

/// <summary>
/// This class is used to implement new colours for the main menu strip, that for this application will make
/// hovers and clicks lighter.
/// </summary>
public class MainMenuStripColourTable : ProfessionalColorTable
{
    /// <summary>
    /// The lightened up background color.
    /// </summary>
    private Color LightenedColor { get; }
    
    /// <summary>
    /// Gets the background color associated with the menu strip.
    /// </summary>
    /// <param name="backgroundColor">The background color used in the strip</param>
    public MainMenuStripColourTable(Color backgroundColor) =>
        this.LightenedColor = ControlPaint.Light(backgroundColor, 0.5f);
    
    /// <summary>
    /// The color of the menu strip buttons when selected/hovered over.
    /// </summary>
    public override Color MenuItemSelected => this.LightenedColor;

    /// <summary>
    /// The top color for the gradient of the menu strip buttons when selected/hovered over.
    /// </summary>
    public override Color MenuItemSelectedGradientBegin => this.LightenedColor;

    /// <summary>
    /// The bottom color for the gradient of the menu strip buttons when selected/hovered over.
    /// </summary>
    public override Color MenuItemSelectedGradientEnd => this.LightenedColor;
    
    /// <summary>
    /// The color of the menu strip button border.
    /// </summary>
    public override Color MenuItemBorder => ControlPaint.Light(this.LightenedColor, 0.3f);
}