using System.ComponentModel;
using System.Windows.Forms;

namespace glowberry.ui.graphical;

partial class ConsoleDialog
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
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBox2
        // 
        this.textBox2.BackColor = System.Drawing.Color.DimGray;
        this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox2.ForeColor = System.Drawing.Color.White;
        this.textBox2.Location = new System.Drawing.Point(0, 0);
        this.textBox2.Multiline = true;
        this.textBox2.Name = "textBox2";
        this.textBox2.ReadOnly = true;
        this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBox2.Size = new System.Drawing.Size(1121, 699);
        this.textBox2.TabIndex = 3;
        this.textBox2.Text = "\r\n";
        // 
        // textBox1
        // 
        this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBox1.Location = new System.Drawing.Point(0, 671);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(1121, 28);
        this.textBox1.TabIndex = 4;
        // 
        // ConsoleDialog
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Thistle;
        this.ClientSize = new System.Drawing.Size(1121, 699);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.textBox2);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Name = "ConsoleDialog";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.TextBox textBox2;

    #endregion
}