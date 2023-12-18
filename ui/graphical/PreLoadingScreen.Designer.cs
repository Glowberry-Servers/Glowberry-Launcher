using System.ComponentModel;
using System.Drawing;
using static glowberry.common.Constants;

namespace glowberry.ui.graphical
{
    partial class PreLoadingScreen 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreLoadingScreen));
            this.LabelDownloadingAsset = new System.Windows.Forms.Label();
            this.ProgressBarDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LabelDownloadingAsset
            // 
            this.LabelDownloadingAsset.Location = new System.Drawing.Point(0, 0);
            this.LabelDownloadingAsset.Name = "LabelDownloadingAsset";
            this.LabelDownloadingAsset.Size = new System.Drawing.Size(484, 62);
            this.LabelDownloadingAsset.TabIndex = 0;
            this.LabelDownloadingAsset.Text = "Downloading Assets...";
            this.LabelDownloadingAsset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarDownload
            // 
            this.ProgressBarDownload.Location = new System.Drawing.Point(26, 71);
            this.ProgressBarDownload.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBarDownload.MarqueeAnimationSpeed = 400;
            this.ProgressBarDownload.Name = "ProgressBarDownload";
            this.ProgressBarDownload.Size = new System.Drawing.Size(436, 31);
            this.ProgressBarDownload.TabIndex = 1;
            // 
            // PreLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 110);
            this.Controls.Add(this.ProgressBarDownload);
            this.Controls.Add(this.LabelDownloadingAsset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreLoadingScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreLoadingScreen_FormClosing);
            this.Load += new System.EventHandler(this.PreLoadingScreen_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar ProgressBarDownload;

        private System.Windows.Forms.Label LabelDownloadingAsset;

        #endregion
    }
}