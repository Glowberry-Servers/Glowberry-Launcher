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
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.label1 = new System.Windows.Forms.Label();
        this.TextBoxServerInput = new System.Windows.Forms.TextBox();
        this.ToolStripRefreshConsole = new System.Windows.Forms.ToolStripLabel();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.ToolStripAutoScroll = new System.Windows.Forms.ToolStripLabel();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.panel1.SuspendLayout();
        this.toolStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.Gray;
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.RichTextBoxConsole);
        this.panel1.Controls.Add(this.toolStrip1);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.TextBoxServerInput);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Padding = new System.Windows.Forms.Padding(10);
        this.panel1.Size = new System.Drawing.Size(1197, 748);
        this.panel1.TabIndex = 0;
        // 
        // label2
        // 
        this.label2.Dock = System.Windows.Forms.DockStyle.Top;
        this.label2.Location = new System.Drawing.Point(10, 57);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(1177, 10);
        this.label2.TabIndex = 6;
        // 
        // RichTextBoxConsole
        // 
        this.RichTextBoxConsole.BackColor = System.Drawing.Color.White;
        this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.RichTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
        this.RichTextBoxConsole.Location = new System.Drawing.Point(10, 57);
        this.RichTextBoxConsole.Name = "RichTextBoxConsole";
        this.RichTextBoxConsole.ReadOnly = true;
        this.RichTextBoxConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
        this.RichTextBoxConsole.Size = new System.Drawing.Size(1177, 645);
        this.RichTextBoxConsole.TabIndex = 4;
        this.RichTextBoxConsole.Text = "";
        // 
        // toolStrip1
        // 
        this.toolStrip1.AutoSize = false;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ToolStripRefreshConsole, this.toolStripSeparator1, this.ToolStripAutoScroll, this.toolStripSeparator2 });
        this.toolStrip1.Location = new System.Drawing.Point(10, 10);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(1177, 47);
        this.toolStrip1.TabIndex = 5;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // label1
        // 
        this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.label1.Location = new System.Drawing.Point(10, 702);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(1177, 10);
        this.label1.TabIndex = 0;
        // 
        // TextBoxServerInput
        // 
        this.TextBoxServerInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.TextBoxServerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.TextBoxServerInput.Location = new System.Drawing.Point(10, 712);
        this.TextBoxServerInput.Name = "TextBoxServerInput";
        this.TextBoxServerInput.Size = new System.Drawing.Size(1177, 26);
        this.TextBoxServerInput.TabIndex = 2;
        this.TextBoxServerInput.Text = "> ";
        this.TextBoxServerInput.TextChanged += new System.EventHandler(this.TextBoxServerInput_TextChanged);
        this.TextBoxServerInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxServerInput_KeyPress);
        // 
        // ToolStripRefreshConsole
        // 
        this.ToolStripRefreshConsole.Name = "ToolStripRefreshConsole";
        this.ToolStripRefreshConsole.Size = new System.Drawing.Size(139, 44);
        this.ToolStripRefreshConsole.Text = "Refresh Console";
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
        // 
        // ToolStripAutoScroll
        // 
        this.ToolStripAutoScroll.Name = "ToolStripAutoScroll";
        this.ToolStripAutoScroll.Size = new System.Drawing.Size(99, 44);
        this.ToolStripAutoScroll.Text = "Auto Scroll";
        // 
        // toolStripSeparator2
        // 
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
        // 
        // ConsoleInterface
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1197, 748);
        this.Controls.Add(this.panel1);
        this.Name = "ConsoleInterface";
        this.Text = "ConsoleInterface";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleInterface_FormClosing);
        this.Load += new System.EventHandler(this.ConsoleInterface_Load);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

    private System.Windows.Forms.ToolStripLabel ToolStripAutoScroll;

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    private System.Windows.Forms.ToolStripLabel ToolStripRefreshConsole;

    private System.Windows.Forms.ToolStrip toolStrip1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ToolStrip miniToolStrip;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox TextBoxServerInput;

    private System.Windows.Forms.RichTextBox RichTextBoxConsole;

    private System.Windows.Forms.Panel panel1;

    #endregion
}