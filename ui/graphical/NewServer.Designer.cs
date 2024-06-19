namespace glowberry.ui.graphical
{
    partial class NewServer
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
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewServerLayout = new System.Windows.Forms.Panel();
            this.RichTextBoxConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonFolderBrowser = new System.Windows.Forms.Button();
            this.ComboBoxJavaVersion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.ButtonBuild = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboServerVersion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ComboBoxServerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelServerNameError = new System.Windows.Forms.Label();
            this.TextBoxServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NewServerLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(446, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 21);
            this.label5.TabIndex = 62;
            this.label5.Tag = "tooltip";
            this.ToolTips.SetToolTip(this.label5, "This is the name of your server, represented internally by a folder.");
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(446, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 21);
            this.label6.TabIndex = 63;
            this.label6.Tag = "tooltip";
            this.ToolTips.SetToolTip(this.label6, "This is the server\'s version, according to the selected server type.\r\nEach type h" + "as different version ranges to be selected.");
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(446, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 21);
            this.label7.TabIndex = 64;
            this.label7.Tag = "tooltip";
            this.ToolTips.SetToolTip(this.label7, "This is the server type, essentially the kind of server you want to run.\r\nIt can " + "be one with mods, plugins, vanilla, you call it!");
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(446, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 21);
            this.label8.TabIndex = 65;
            this.label8.Tag = "tooltip";
            this.ToolTips.SetToolTip(this.label8, "This is the server type, essentially the kind of server you want to run.\r\nIt can " + "be one with mods, plugins, vanilla, you call it!");
            // 
            // NewServerLayout
            // 
            this.NewServerLayout.BackColor = System.Drawing.SystemColors.Control;
            this.NewServerLayout.Controls.Add(this.RichTextBoxConsoleOutput);
            this.NewServerLayout.Controls.Add(this.label13);
            this.NewServerLayout.Controls.Add(this.label11);
            this.NewServerLayout.Controls.Add(this.label12);
            this.NewServerLayout.Controls.Add(this.panel1);
            this.NewServerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewServerLayout.Location = new System.Drawing.Point(0, 0);
            this.NewServerLayout.Name = "NewServerLayout";
            this.NewServerLayout.Size = new System.Drawing.Size(1216, 708);
            this.NewServerLayout.TabIndex = 3;
            // 
            // RichTextBoxConsoleOutput
            // 
            this.RichTextBoxConsoleOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RichTextBoxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxConsoleOutput.HideSelection = false;
            this.RichTextBoxConsoleOutput.Location = new System.Drawing.Point(500, 31);
            this.RichTextBoxConsoleOutput.Name = "RichTextBoxConsoleOutput";
            this.RichTextBoxConsoleOutput.ReadOnly = true;
            this.RichTextBoxConsoleOutput.Size = new System.Drawing.Size(688, 646);
            this.RichTextBoxConsoleOutput.TabIndex = 27;
            this.RichTextBoxConsoleOutput.Text = "";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(500, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(688, 31);
            this.label13.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(500, 677);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(688, 31);
            this.label11.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Location = new System.Drawing.Point(1188, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 708);
            this.label12.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 708);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PictureBoxLoading);
            this.panel2.Controls.Add(this.ButtonBuild);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.ComboServerVersion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.ComboBoxServerType);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LabelServerNameError);
            this.panel2.Controls.Add(this.TextBoxServerName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(60, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 552);
            this.panel2.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonFolderBrowser);
            this.panel4.Controls.Add(this.ComboBoxJavaVersion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 40);
            this.panel4.TabIndex = 61;
            // 
            // ButtonFolderBrowser
            // 
            this.ButtonFolderBrowser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFolderBrowser.Location = new System.Drawing.Point(0, 0);
            this.ButtonFolderBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonFolderBrowser.Name = "ButtonFolderBrowser";
            this.ButtonFolderBrowser.Size = new System.Drawing.Size(40, 40);
            this.ButtonFolderBrowser.TabIndex = 64;
            this.ButtonFolderBrowser.UseVisualStyleBackColor = true;
            this.ButtonFolderBrowser.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // ComboBoxJavaVersion
            // 
            this.ComboBoxJavaVersion.DropDownHeight = 200;
            this.ComboBoxJavaVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxJavaVersion.FormattingEnabled = true;
            this.ComboBoxJavaVersion.IntegralHeight = false;
            this.ComboBoxJavaVersion.Location = new System.Drawing.Point(45, 6);
            this.ComboBoxJavaVersion.Name = "ComboBoxJavaVersion";
            this.ComboBoxJavaVersion.Size = new System.Drawing.Size(329, 28);
            this.ComboBoxJavaVersion.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "Java Runtime Version";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLoading.Location = new System.Drawing.Point(151, 474);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(77, 78);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLoading.TabIndex = 57;
            this.PictureBoxLoading.TabStop = false;
            this.PictureBoxLoading.Visible = false;
            // 
            // ButtonBuild
            // 
            this.ButtonBuild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBuild.Enabled = false;
            this.ButtonBuild.Location = new System.Drawing.Point(0, 474);
            this.ButtonBuild.Name = "ButtonBuild";
            this.ButtonBuild.Size = new System.Drawing.Size(380, 78);
            this.ButtonBuild.TabIndex = 56;
            this.ButtonBuild.Text = "Build Server";
            this.ButtonBuild.UseVisualStyleBackColor = true;
            this.ButtonBuild.Click += new System.EventHandler(this.ButtonBuild_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(0, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(380, 31);
            this.label18.TabIndex = 50;
            // 
            // ComboServerVersion
            // 
            this.ComboServerVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboServerVersion.DropDownHeight = 200;
            this.ComboServerVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboServerVersion.Enabled = false;
            this.ComboServerVersion.FormattingEnabled = true;
            this.ComboServerVersion.IntegralHeight = false;
            this.ComboServerVersion.Location = new System.Drawing.Point(0, 212);
            this.ComboServerVersion.Name = "ComboServerVersion";
            this.ComboServerVersion.Size = new System.Drawing.Size(380, 28);
            this.ComboServerVersion.TabIndex = 48;
            this.ComboServerVersion.SelectedIndexChanged += new System.EventHandler(this.ComboServerVersion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Server Version";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(0, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(380, 31);
            this.label17.TabIndex = 44;
            // 
            // ComboBoxServerType
            // 
            this.ComboBoxServerType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxServerType.DropDownHeight = 200;
            this.ComboBoxServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxServerType.FormattingEnabled = true;
            this.ComboBoxServerType.IntegralHeight = false;
            this.ComboBoxServerType.Location = new System.Drawing.Point(0, 121);
            this.ComboBoxServerType.Name = "ComboBoxServerType";
            this.ComboBoxServerType.Size = new System.Drawing.Size(380, 28);
            this.ComboBoxServerType.TabIndex = 39;
            this.ComboBoxServerType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxServerType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Server Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelServerNameError
            // 
            this.LabelServerNameError.BackColor = System.Drawing.Color.Transparent;
            this.LabelServerNameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelServerNameError.Location = new System.Drawing.Point(0, 58);
            this.LabelServerNameError.Name = "LabelServerNameError";
            this.LabelServerNameError.Size = new System.Drawing.Size(380, 31);
            this.LabelServerNameError.TabIndex = 37;
            this.LabelServerNameError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxServerName
            // 
            this.TextBoxServerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxServerName.Location = new System.Drawing.Point(0, 32);
            this.TextBoxServerName.Name = "TextBoxServerName";
            this.TextBoxServerName.Size = new System.Drawing.Size(380, 26);
            this.TextBoxServerName.TabIndex = 36;
            this.TextBoxServerName.TextChanged += new System.EventHandler(this.TextBoxServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Server Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(60, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(380, 106);
            this.label15.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label14.Location = new System.Drawing.Point(60, 658);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(380, 50);
            this.label14.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 708);
            this.label10.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(440, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 708);
            this.label9.TabIndex = 20;
            // 
            // NewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 708);
            this.Controls.Add(this.NewServerLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewServer";
            this.NewServerLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button ButtonFolderBrowser;
        public System.Windows.Forms.ComboBox ComboBoxJavaVersion;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label label18;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.TextBox TextBoxServerName;
        private System.Windows.Forms.Label LabelServerNameError;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ToolTip ToolTips;

        public System.Windows.Forms.RichTextBox RichTextBoxConsoleOutput;

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;

        private System.Windows.Forms.PictureBox PictureBoxLoading;

        #endregion

        private System.Windows.Forms.Panel NewServerLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxServerType;
        private System.Windows.Forms.ComboBox ComboServerVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonBuild;
    }
}