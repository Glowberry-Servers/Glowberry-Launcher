using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using glowberry.api.server;
using glowberry.common;
using glowberry.ui.render;
using LaminariaCore_General.common;

namespace glowberry.ui.graphical;

/// <summary>
/// This class is used to display the latest console output from the server in a graphical interface, as well
/// as sending commands to the server.
/// </summary>
public partial class ConsoleInterface : Form
{
    
    /// <summary>
    /// The section of the server to manage the console for.
    /// </summary>
    public Section ServerSection { get; set; }
    
    /// <summary>
    /// The server interactions API to use for the console.
    /// </summary>
    public ServerInteractions InteractionsAPI { get; set; }
    
    /// <summary>
    /// Whether the console has been closed or not.
    /// </summary>
    private bool IsClosed { get; set; } = false;
    
    /// <summary>
    /// The task that updates the console with the latest output.
    /// </summary>
    private Task ConsoleUpdateTask { get; set; }
    
    /// <summary>
    /// Whether the console should automatically scroll to the latest output or not.
    /// </summary>
    private new bool AutoScroll { get; set; } = true;

    /// <summary>
    /// Main constructor for the ConsoleInterface class. Sets the server section to use for the console and
    /// edits some of the graphical properties of the console.
    /// </summary>
    /// <param name="serverSection">The section of the server to open the console for</param>
    public ConsoleInterface(Section serverSection)
    {
        InitializeComponent();
        this.TextBoxServerInput.AutoSize = false;
        this.TextBoxServerInput.Height = 32;
        this.TextBoxServerInput.SetInnerMargins(10);
        this.RichTextBoxConsole.TextChanged += (sender, e) => this.ScrollToEnd();
        this.RichTextBoxConsole.SetInnerMargins(10);
        
        this.ServerSection = serverSection;
        this.InteractionsAPI = new ServerInteractions(serverSection.SimpleName);
        TextBoxServerInput_TextChanged(null, null);
    }
    
    /// <summary>
    /// After the console interface has been loaded, starts the task to update the console with the latest output.
    /// </summary>
    private void ConsoleInterface_Load(object sender, EventArgs e)
    {
        RichTextBoxConsole.SelectionStart = RichTextBoxConsole.Text.Length;
        CenterToParent();
        
        // Starts off the task to update the console with the latest output
        this.ConsoleUpdateTask = Task.Run(UpdateConsoleTask);
    }
    
    /// <summary>
    /// Stops the ongoing console update task and runs it again, clearing the console.
    /// </summary>
    private async void MenuItemRefreshConsole_Click(object sender, EventArgs e)
    {
        this.MenuItemRefreshConsole.Enabled = false;
        
        this.ConsoleUpdateTask.Dispose();
        RichTextBoxConsole.Clear();
        this.ConsoleUpdateTask = Task.Run(UpdateConsoleTask);
        
        await Task.Delay(500);
        this.MenuItemRefreshConsole.Enabled = true;
    }
    
    /// <summary>
    /// Toggles the auto-scrolling feature of the console on or off.
    /// </summary>
    private void MenuItemAutoScroll_Click(object sender, EventArgs e)
    {
        this.AutoScroll = !this.AutoScroll;
        MenuItemAutoScroll.Text = this.AutoScroll ? "Auto-Scroll Enabled" : "Auto-Scroll Disabled";
    }

    /// <summary>
    /// Continuously updates the console with the latest output from the server.
    /// </summary>
    private async void UpdateConsoleTask()
    {
        // Keeps track of the byte size of the last log file
        long logBytesize = 0;
        
        // Gets the latest log file from the logs directory
        string logsPath = this.ServerSection.GetFirstSectionNamed("logs").SectionFullPath;
        string latestLogPath = Directory.GetFiles(logsPath).OrderByDescending(File.GetLastWriteTime).FirstOrDefault();
        
        while (true)
        {
            await Task.Delay(250);  // Updates the console every 250ms
            
            // Checks if the console has been disposed
            if (this.IsClosed) break;

            // Checks if the latest.log file is still reachable
            if (!File.Exists(latestLogPath))
            {
                SendConsoleError("The latest.log file is unexpectedly unreachable. Please reload the console and try again.");
                break;
            }

            try
            {
                // Checks if the server is still running, and if not, writes a message to the console in red saying so.
                if (!this.InteractionsAPI.IsRunning() || latestLogPath == null)
                {
                    SendConsoleError("This server is not running. Please start it and refresh the console.");
                    this.Invoke( new MethodInvoker( () => TextBoxServerInput.Enabled = false));
                    break;
                }
                
                // Seeks the position indicated by the log bytesize and reads the text from that point onwards
                this.Invoke(new MethodInvoker(() =>
                {
                    long currentFileSize = new FileInfo(latestLogPath).Length;
                    if (currentFileSize <= logBytesize) return;  // If the file hasn't changed, don't update the console
                    
                    // Gets the latest log output and writes it to the console
                    using FileStream fs = new (latestLogPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    fs.Seek(logBytesize, SeekOrigin.Begin);
                    
                    byte[] buffer = new byte[fs.Length - logBytesize]; // Creates a buffer as big as the difference in file size to store the new data
                    int effectiveReadingCount = fs.Read(buffer, 0, buffer.Length); 
                    
                    // Since fewer bytes may be read than expected, we have to calculate the unread bytes so as not to account for them
                    long unreadBytes = buffer.Length - effectiveReadingCount;
                    logBytesize = fs.Length - unreadBytes;  // Updates the log bytesize to the new file size
                    
                    // Now we just need to resize the buffer to the effective reading count and convert it to a string  
                    Array.Resize(ref buffer, effectiveReadingCount);
                    string logOutput = Encoding.UTF8.GetString(buffer);
                    
                    RichTextBoxConsole.AppendText(logOutput);
                }));
            }

            catch (ObjectDisposedException) { Logging.Logger.Info("Console disposed, stopping update task."); }
            catch (Exception e) { Logging.Logger.Error(e); }
        }
        
    }

    /// <summary>
    /// Writes a message to the console in red with an error description.
    /// </summary>
    /// <param name="message">The message to write to the console</param>
    private void SendConsoleError(string message)
    {
        this.Invoke(new MethodInvoker(() =>
        {
            this.RichTextBoxConsole.SelectionStart = this.RichTextBoxConsole.Text.Length;
            this.RichTextBoxConsole.SelectionColor = System.Drawing.Color.Firebrick;

            this.RichTextBoxConsole.AppendText($"[Glowberry] {message}\n");
            this.ScrollToEnd();
        }));
    }

    /// <summary>
    /// Scrolls to the end of the console output.
    /// <param name="force">Whether to forcefully scroll to the bottom and ignore the auto-scroll or not</param>
    /// </summary>
    private void ScrollToEnd(bool force = false)
    {
        if (!AutoScroll && !force) return;
        RichTextBoxConsole.SelectionStart = RichTextBoxConsole.Text.Length;
        RichTextBoxConsole.ScrollToCaret();
    }

    /// <summary>
    /// Detects when the console interface is closed and sets the IsClosed property to true.
    /// </summary>
    private void ConsoleInterface_FormClosing(object sender, FormClosingEventArgs e) => this.IsClosed = true;

    /// <summary>
    /// Keeps a leading ">" character in the input box to indicate that the user can type a command.
    /// </summary>
    private void TextBoxServerInput_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxServerInput.Text.StartsWith("> ")) return;

        // Handles a very specific edge case where the user deletes the " " character
        if (TextBoxServerInput.Text.Equals(">"))
        {
            TextBoxServerInput.Text = @"> ";
            TextBoxServerInput.SelectionStart = TextBoxServerInput.Text.Length;
            return;
        }
            
        TextBoxServerInput.Text = @"> " + TextBoxServerInput.Text;
        TextBoxServerInput.SelectionStart = TextBoxServerInput.Text.Length;
    }

    /// <summary>
    /// When the ENTER key is pressed, sends the command to the server and clears the input box.
    /// </summary>
    private void TextBoxServerInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char) Keys.Enter) return;
        e.Handled = true;
        
        string command = TextBoxServerInput.Text.Substring(2);
        if (command.Length == 0) return;
        
        this.InteractionsAPI.WriteToServerStdin(command);
        
        TextBoxServerInput.Clear();
        TextBoxServerInput_TextChanged(null, null);
    }
}