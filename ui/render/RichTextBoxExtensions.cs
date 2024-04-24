using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace glowberry.ui.render;

/// <summary>
/// This class contains extensions for the RichTextBox class, more specifically to adjust
/// the padding of the text inside the RichTextBox.
/// </summary>
public static class RichTextBoxExtensions
{
    [StructLayout(LayoutKind.Sequential)]
    private struct Rect
    {
        public readonly int Left;
        public readonly int Top;
        public readonly int Right;
        public readonly int Bottom;

        private Rect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rect(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
        {
        }
    }
    
    /// <summary>
    /// Sets the padding of the text inside the RichTextBox
    /// </summary>
    /// <param name="textBox">The textbox from which the method is being called from</param>
    /// <param name="left">The left side padding in pixels</param>
    /// <param name="top">The top side padding in pixels</param>
    /// <param name="right">The right side padding in pixels</param>
    /// <param name="bottom">The bottom side padding in pixels</param>
    public static void SetInnerMargins(this TextBoxBase textBox, int left, int top, int right, int bottom)
    {
        var rect = textBox.GetFormattingRect();

        // Creates a new formatting rectangle with the specified padding, to overwrite the old one
        var newRect = new Rectangle(left, top, rect.Width - left - right, rect.Height - top - bottom);
        textBox.SetFormattingRect(newRect);
    }
    
    /// <summary>
    /// Shortcut method to set the padding of the text inside the RichTextBox to the same value on all sides
    /// </summary>
    /// <param name="textBox">The textbox from which the method is being called from</param>
    /// <param name="all">The size of all the margins</param>
    public static void SetInnerMargins(this TextBoxBase textBox, int all) =>
        SetInnerMargins(textBox, all, all, all, all);

    /// <summary>
    /// This windows DLL import is used to send a message to a textbox to set the formatting rectangle.
    /// We can pass in the rectangle as a reference of our Rect struct.
    /// </summary>
    [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
    private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref Rect rect);

    /// <summary>
    /// This windows DLL import is used to send a message to a textbox to get the formatting rectangle.
    /// This will return the rectangle in the Rectangle class, which we can then pass into our struct.
    /// </summary>
    [DllImport(@"user32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
    private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rectangle lParam);

    // Hex values for the messages we are sending to the textbox
    private const int EmGetrect = 0xB2;
    private const int EmSetrect = 0xB3;

    /// <summary>
    /// Sets the formatting rectangle of the textbox
    /// </summary>
    /// <param name="textbox">The text box this method is being called from</param>
    /// <param name="rect">The Rectangle to set as the textbox's formatting</param>
    private static void SetFormattingRect(this TextBoxBase textbox, Rectangle rect)
    {
        var rc = new Rect(rect);
        SendMessageRefRect(textbox.Handle, EmSetrect, 0, ref rc);
    }

    /// <summary>
    /// Gets the formatting rectangle of the textbox
    /// </summary>
    /// <param name="textbox">The text box this method is being called from</param>
    /// <returns>The Rectangle being used as the cage in which the textbox is held, so as to format it</returns>
    private static Rectangle GetFormattingRect(this TextBoxBase textbox)
    {
        var rect = new Rectangle();
        SendMessage(textbox.Handle, EmGetrect, (IntPtr) 0, ref rect);
        return rect;
    }
}