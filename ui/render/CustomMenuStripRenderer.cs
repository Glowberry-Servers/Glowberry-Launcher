using System.Drawing;
using System.Windows.Forms;

namespace glowberry.ui.render;

/// <summary>
/// This class is used to render the Menu strip in the mainframe in a custom manner.
/// </summary>
public class CustomMenuStripRenderer : ToolStripProfessionalRenderer
{
    /// <summary>
    /// Implements the custom color table for the menu strip, that just gets the background color and upon
    /// hover and clicking, changes it to a lighter color.
    /// </summary>
    public CustomMenuStripRenderer(Color backgroundColor): base(new MainMenuStripColourTable(backgroundColor)) {}
    
}