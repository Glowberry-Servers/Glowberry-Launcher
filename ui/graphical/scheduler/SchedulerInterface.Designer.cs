using System.ComponentModel;

namespace glowberry.ui.graphical;

partial class SchedulerInterface
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
        this.ListViewTasks = new System.Windows.Forms.ListView();
        this.TaskName = new System.Windows.Forms.ColumnHeader();
        this.PanelSectionBrowser = new System.Windows.Forms.Panel();
        this.ListBoxSectionBrowser = new System.Windows.Forms.ListBox();
        this.PanelSectionBrowserButtons = new System.Windows.Forms.Panel();
        this.PanelTaskInformation = new System.Windows.Forms.Panel();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.PanelSectionBrowser.SuspendLayout();
        this.PanelSectionBrowserButtons.SuspendLayout();
        this.SuspendLayout();
        // 
        // ListViewTasks
        // 
        this.ListViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.TaskName });
        this.ListViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ListViewTasks.HideSelection = false;
        this.ListViewTasks.Location = new System.Drawing.Point(0, 0);
        this.ListViewTasks.Name = "ListViewTasks";
        this.ListViewTasks.Size = new System.Drawing.Size(1101, 687);
        this.ListViewTasks.TabIndex = 3;
        this.ListViewTasks.UseCompatibleStateImageBehavior = false;
        // 
        // TaskName
        // 
        this.TaskName.Text = "TaskName";
        // 
        // PanelSectionBrowser
        // 
        this.PanelSectionBrowser.Controls.Add(this.ListBoxSectionBrowser);
        this.PanelSectionBrowser.Controls.Add(this.PanelSectionBrowserButtons);
        this.PanelSectionBrowser.Dock = System.Windows.Forms.DockStyle.Left;
        this.PanelSectionBrowser.Location = new System.Drawing.Point(0, 0);
        this.PanelSectionBrowser.Name = "PanelSectionBrowser";
        this.PanelSectionBrowser.Size = new System.Drawing.Size(195, 687);
        this.PanelSectionBrowser.TabIndex = 6;
        // 
        // ListBoxSectionBrowser
        // 
        this.ListBoxSectionBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ListBoxSectionBrowser.FormattingEnabled = true;
        this.ListBoxSectionBrowser.ItemHeight = 20;
        this.ListBoxSectionBrowser.Location = new System.Drawing.Point(0, 77);
        this.ListBoxSectionBrowser.Name = "ListBoxSectionBrowser";
        this.ListBoxSectionBrowser.Size = new System.Drawing.Size(195, 610);
        this.ListBoxSectionBrowser.TabIndex = 0;
        // 
        // PanelSectionBrowserButtons
        // 
        this.PanelSectionBrowserButtons.Controls.Add(this.button2);
        this.PanelSectionBrowserButtons.Controls.Add(this.button1);
        this.PanelSectionBrowserButtons.Dock = System.Windows.Forms.DockStyle.Top;
        this.PanelSectionBrowserButtons.Location = new System.Drawing.Point(0, 0);
        this.PanelSectionBrowserButtons.Name = "PanelSectionBrowserButtons";
        this.PanelSectionBrowserButtons.Size = new System.Drawing.Size(195, 77);
        this.PanelSectionBrowserButtons.TabIndex = 4;
        // 
        // PanelTaskInformation
        // 
        this.PanelTaskInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.PanelTaskInformation.Location = new System.Drawing.Point(195, 535);
        this.PanelTaskInformation.Name = "PanelTaskInformation";
        this.PanelTaskInformation.Size = new System.Drawing.Size(906, 152);
        this.PanelTaskInformation.TabIndex = 7;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(12, 12);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(169, 26);
        this.button1.TabIndex = 0;
        this.button1.Text = "Add Section";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(12, 44);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(169, 26);
        this.button2.TabIndex = 1;
        this.button2.Text = "Create Task";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // SchedulerInterface
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1101, 687);
        this.Controls.Add(this.PanelTaskInformation);
        this.Controls.Add(this.PanelSectionBrowser);
        this.Controls.Add(this.ListViewTasks);
        this.Name = "SchedulerInterface";
        this.Text = "SchedulerInterface";
        this.PanelSectionBrowser.ResumeLayout(false);
        this.PanelSectionBrowserButtons.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Panel PanelTaskInformation;

    private System.Windows.Forms.Panel PanelSectionBrowserButtons;
    private System.Windows.Forms.Panel PanelSectionBrowser;

    private System.Windows.Forms.ColumnHeader TaskName;

    private System.Windows.Forms.ListView ListViewTasks;

    private System.Windows.Forms.ListBox ListBoxSectionBrowser;

    #endregion
}