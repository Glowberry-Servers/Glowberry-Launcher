namespace glowberry.ui.graphical
{
    partial class ServerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.dnjlfe = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.NewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RadminVPNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerListLayout = new System.Windows.Forms.Panel();
            this.jkghvcgjv = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridServerList = new System.Windows.Forms.DataGridView();
            this.ServerType = new System.Windows.Forms.DataGridViewImageColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StopButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConsoleButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MenuBar.SuspendLayout();
            this.ServerListLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridServerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dnjlfe
            // 
            this.dnjlfe.Location = new System.Drawing.Point(19, 35);
            this.dnjlfe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dnjlfe.Name = "dnjlfe";
            this.dnjlfe.Size = new System.Drawing.Size(21, 22);
            this.dnjlfe.TabIndex = 17;
            this.dnjlfe.Tag = "tooltip";
            this.ToolTips.SetToolTip(this.dnjlfe, resources.GetString("dnjlfe.ToolTip"));
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Crimson;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.NewServerToolStripMenuItem, this.ServersToolStripMenuItem, this.RadminVPNToolStripMenuItem, this.WikiToolStripMenuItem });
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.MenuBar.Size = new System.Drawing.Size(1200, 33);
            this.MenuBar.TabIndex = 2;
            this.MenuBar.Text = "menuStrip1";
            // 
            // NewServerToolStripMenuItem
            // 
            this.NewServerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewServerToolStripMenuItem.Name = "NewServerToolStripMenuItem";
            this.NewServerToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.NewServerToolStripMenuItem.Text = "New";
            // 
            // ServersToolStripMenuItem
            // 
            this.ServersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServersToolStripMenuItem.Name = "ServersToolStripMenuItem";
            this.ServersToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.ServersToolStripMenuItem.Text = "Servers";
            // 
            // RadminVPNToolStripMenuItem
            // 
            this.RadminVPNToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RadminVPNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RadminVPNToolStripMenuItem.Name = "RadminVPNToolStripMenuItem";
            this.RadminVPNToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadminVPNToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.RadminVPNToolStripMenuItem.Text = "Radmin VPN";
            // 
            // WikiToolStripMenuItem
            // 
            this.WikiToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WikiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WikiToolStripMenuItem.Name = "WikiToolStripMenuItem";
            this.WikiToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.WikiToolStripMenuItem.Text = "Wiki";
            // 
            // ServerListLayout
            // 
            this.ServerListLayout.Controls.Add(this.GridServerList);
            this.ServerListLayout.Controls.Add(this.label3);
            this.ServerListLayout.Controls.Add(this.label2);
            this.ServerListLayout.Controls.Add(this.label1);
            this.ServerListLayout.Controls.Add(this.jkghvcgjv);
            this.ServerListLayout.Controls.Add(this.ButtonRefresh);
            this.ServerListLayout.Controls.Add(this.dnjlfe);
            this.ServerListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerListLayout.Location = new System.Drawing.Point(0, 33);
            this.ServerListLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerListLayout.Name = "ServerListLayout";
            this.ServerListLayout.Size = new System.Drawing.Size(1200, 659);
            this.ServerListLayout.TabIndex = 3;
            // 
            // jkghvcgjv
            // 
            this.jkghvcgjv.Dock = System.Windows.Forms.DockStyle.Top;
            this.jkghvcgjv.Location = new System.Drawing.Point(0, 0);
            this.jkghvcgjv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jkghvcgjv.Name = "jkghvcgjv";
            this.jkghvcgjv.Size = new System.Drawing.Size(1200, 62);
            this.jkghvcgjv.TabIndex = 19;
            this.jkghvcgjv.Text = resources.GetString("jkghvcgjv.Text");
            this.jkghvcgjv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRefresh.Location = new System.Drawing.Point(1144, 26);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(38, 38);
            this.ButtonRefresh.TabIndex = 18;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 597);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(1170, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 597);
            this.label2.TabIndex = 21;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(30, 623);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1140, 36);
            this.label3.TabIndex = 22;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridServerList
            // 
            this.GridServerList.AllowUserToAddRows = false;
            this.GridServerList.AllowUserToDeleteRows = false;
            this.GridServerList.AllowUserToResizeColumns = false;
            this.GridServerList.AllowUserToResizeRows = false;
            this.GridServerList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridServerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.ServerType, this.Version, this.ServerName, this.ServerIp, this.Edit, this.Play, this.StopButton, this.ConsoleButton });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridServerList.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridServerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridServerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridServerList.Location = new System.Drawing.Point(30, 62);
            this.GridServerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridServerList.MultiSelect = false;
            this.GridServerList.Name = "GridServerList";
            this.GridServerList.ReadOnly = true;
            this.GridServerList.RowHeadersVisible = false;
            this.GridServerList.RowTemplate.Height = 100;
            this.GridServerList.ShowCellToolTips = false;
            this.GridServerList.ShowEditingIcon = false;
            this.GridServerList.Size = new System.Drawing.Size(1140, 561);
            this.GridServerList.TabIndex = 23;
            // 
            // ServerType
            // 
            this.ServerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ServerType.HeaderText = "Server Type";
            this.ServerType.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ServerType.Name = "ServerType";
            this.ServerType.ReadOnly = true;
            this.ServerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerType.Width = 99;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Version.Width = 69;
            // 
            // ServerName
            // 
            this.ServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerName.HeaderText = "Server Name";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServerIp
            // 
            this.ServerIp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerIp.HeaderText = "Server IP";
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.ReadOnly = true;
            this.ServerIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.HeaderText = "                     ";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Options";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 99;
            // 
            // Play
            // 
            this.Play.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            this.Play.DefaultCellStyle = dataGridViewCellStyle3;
            this.Play.HeaderText = "                     ";
            this.Play.Name = "Play";
            this.Play.ReadOnly = true;
            this.Play.Text = "Start";
            this.Play.Width = 99;
            // 
            // StopButton
            // 
            this.StopButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            this.StopButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.StopButton.HeaderText = "                     ";
            this.StopButton.Name = "StopButton";
            this.StopButton.ReadOnly = true;
            this.StopButton.Text = "Stop";
            this.StopButton.Width = 99;
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            this.ConsoleButton.DefaultCellStyle = dataGridViewCellStyle5;
            this.ConsoleButton.HeaderText = "                     ";
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.ReadOnly = true;
            this.ConsoleButton.Text = "Console";
            this.ConsoleButton.UseColumnTextForButtonValue = true;
            this.ConsoleButton.Width = 99;
            // 
            // ServerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ServerListLayout);
            this.Controls.Add(this.MenuBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServerList";
            this.Text = "Form1";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ServerListLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridServerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem NewServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RadminVPNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WikiToolStripMenuItem;

        private System.Windows.Forms.DataGridViewButtonColumn ConsoleButton;

        private System.Windows.Forms.DataGridViewButtonColumn StopButton;

        private System.Windows.Forms.Label jkghvcgjv;

        private System.Windows.Forms.Button ButtonRefresh;

        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIp;

        private System.Windows.Forms.ToolTip ToolTips;

        private System.Windows.Forms.Label dnjlfe;

        private System.Windows.Forms.DataGridViewImageColumn ServerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Play;

        public System.Windows.Forms.DataGridView GridServerList;

        #endregion

        private System.Windows.Forms.Panel ServerListLayout;
    }
}