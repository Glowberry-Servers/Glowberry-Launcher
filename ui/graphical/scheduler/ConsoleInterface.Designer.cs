using System;
using System.ComponentModel;

namespace glowberry.ui.graphical;

partial class ConsoleInterface
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.panel1 = new System.Windows.Forms.Panel();
        this.label2 = new System.Windows.Forms.Label();
        this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.TextBoxServerInput = new System.Windows.Forms.TextBox();
        this.MenuBarConsoleOptions = new System.Windows.Forms.MenuStrip();
        this.MenuItemRefreshConsole = new System.Windows.Forms.ToolStripMenuItem();
        this.MenuItemAutoScroll = new System.Windows.Forms.ToolStripMenuItem();
        this.panel1.SuspendLayout();
        this.MenuBarConsoleOptions.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.Gray;
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.RichTextBoxConsole);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.TextBoxServerInput);
        this.panel1.Controls.Add(this.MenuBarConsoleOptions);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Padding = new System.Windows.Forms.Padding(10);
        this.panel1.Size = new System.Drawing.Size(1233, 850);
        this.panel1.TabIndex = 0;
        // 
        // label2
        // 
        this.label2.Dock = System.Windows.Forms.DockStyle.Top;
        this.label2.Location = new System.Drawing.Point(10, 51);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(1213, 10);
        this.label2.TabIndex = 6;
        // 
        // RichTextBoxConsole
        // 
        this.RichTextBoxConsole.BackColor = System.Drawing.Color.White;
        this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.RichTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
        this.RichTextBoxConsole.Location = new System.Drawing.Point(10, 51);
        this.RichTextBoxConsole.Name = "RichTextBoxConsole";
        this.RichTextBoxConsole.ReadOnly = true;
        this.RichTextBoxConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
        this.RichTextBoxConsole.Size = new System.Drawing.Size(1213, 753);
        this.RichTextBoxConsole.TabIndex = 4;
        this.RichTextBoxConsole.Text = "";
        // 
        // label1
        // 
        this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.label1.Location = new System.Drawing.Point(10, 804);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(1213, 10);
        this.label1.TabIndex = 0;
        // 
        // TextBoxServerInput
        // 
        this.TextBoxServerInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.TextBoxServerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.TextBoxServerInput.Location = new System.Drawing.Point(10, 814);
        this.TextBoxServerInput.Name = "TextBoxServerInput";
        this.TextBoxServerInput.Size = new System.Drawing.Size(1213, 26);
        this.TextBoxServerInput.TabIndex = 2;
        this.TextBoxServerInput.TextChanged += new System.EventHandler(this.TextBoxServerInput_TextChanged);
        this.TextBoxServerInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxServerInput_KeyPress);
        // 
        // MenuBarConsoleOptions
        // 
        this.MenuBarConsoleOptions.AutoSize = false;
        this.MenuBarConsoleOptions.BackColor = System.Drawing.Color.White;
        this.MenuBarConsoleOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuItemRefreshConsole, this.MenuItemAutoScroll });
        this.MenuBarConsoleOptions.Location = new System.Drawing.Point(10, 10);
        this.MenuBarConsoleOptions.Name = "MenuBarConsoleOptions";
        this.MenuBarConsoleOptions.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
        this.MenuBarConsoleOptions.Size = new System.Drawing.Size(1213, 41);
        this.MenuBarConsoleOptions.TabIndex = 7;
        this.MenuBarConsoleOptions.Text = "menuStrip1";
        // 
        // MenuItemRefreshConsole
        // 
        this.MenuItemRefreshConsole.Name = "MenuItemRefreshConsole";
        this.MenuItemRefreshConsole.Size = new System.Drawing.Size(151, 37);
        this.MenuItemRefreshConsole.Text = "Refresh Console";
        this.MenuItemRefreshConsole.Click += new System.EventHandler(this.MenuItemRefreshConsole_Click);
        // 
        // MenuItemAutoScroll
        // 
        this.MenuItemAutoScroll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        this.MenuItemAutoScroll.Name = "MenuItemAutoScroll";
        this.MenuItemAutoScroll.Size = new System.Drawing.Size(181, 37);
        this.MenuItemAutoScroll.Text = "Auto-Scroll Enabled";
        this.MenuItemAutoScroll.Click += new System.EventHandler(this.MenuItemAutoScroll_Click);
        // 
        // ConsoleInterface
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1233, 850);
        this.Controls.Add(this.panel1);
        this.MainMenuStrip = this.MenuBarConsoleOptions;
        this.Name = "ConsoleInterface";
        this.Text = "ConsoleInterface";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleInterface_FormClosing);
        this.Load += new System.EventHandler(this.ConsoleInterface_Load);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.MenuBarConsoleOptions.ResumeLayout(false);
        this.MenuBarConsoleOptions.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.MenuStrip MenuBarConsoleOptions;

    private System.Windows.Forms.ToolStripMenuItem MenuItemAutoScroll;

    private System.Windows.Forms.MenuStrip miniToolStrip;
    private System.Windows.Forms.ToolStripMenuItem MenuItemRefreshConsole;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox TextBoxServerInput;

    private System.Windows.Forms.RichTextBox RichTextBoxConsole;

    private System.Windows.Forms.Panel panel1;

    #endregion
}