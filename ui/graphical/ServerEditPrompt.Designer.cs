﻿using System.ComponentModel;

namespace glowberry.ui.graphical
{
    partial class ServerEditPrompt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerEditPrompt));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ButtonFolderBrowsing = new System.Windows.Forms.Button();
            this.ButtonFolderBrowsing2 = new System.Windows.Forms.Button();
            this.CheckBoxCracked = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxGamemode = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.ButtonOpenServerFolder = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDeleteServer = new System.Windows.Forms.Button();
            this.ButtonFolderBrowsing3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxSpawnProtection = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mkeq = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NumericSpawnProtection = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpawnProtection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxServerName
            // 
            this.TextBoxServerName.Location = new System.Drawing.Point(13, 44);
            this.TextBoxServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxServerName.Name = "TextBoxServerName";
            this.TextBoxServerName.Size = new System.Drawing.Size(138, 26);
            this.TextBoxServerName.TabIndex = 2;
            this.TextBoxServerName.Tag = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allocated RAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "ram";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Base Port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.Tag = "baseport";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(320, 316);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(253, 26);
            this.textBox5.TabIndex = 10;
            this.textBox5.Tag = "serverbackupspath";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(321, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Playerdata Backups Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(321, 390);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 26);
            this.textBox6.TabIndex = 12;
            this.textBox6.Tag = "playerdatabackupspath";
            // 
            // ButtonFolderBrowsing
            // 
            this.ButtonFolderBrowsing.Location = new System.Drawing.Point(580, 308);
            this.ButtonFolderBrowsing.Name = "ButtonFolderBrowsing";
            this.ButtonFolderBrowsing.Size = new System.Drawing.Size(42, 43);
            this.ButtonFolderBrowsing.TabIndex = 15;
            this.ButtonFolderBrowsing.Tag = "serverbackupspath";
            this.ButtonFolderBrowsing.UseVisualStyleBackColor = true;
            this.ButtonFolderBrowsing.Click += new System.EventHandler(this.ButtonFolderBrowsing_Click);
            // 
            // ButtonFolderBrowsing2
            // 
            this.ButtonFolderBrowsing2.Location = new System.Drawing.Point(581, 382);
            this.ButtonFolderBrowsing2.Name = "ButtonFolderBrowsing2";
            this.ButtonFolderBrowsing2.Size = new System.Drawing.Size(42, 43);
            this.ButtonFolderBrowsing2.TabIndex = 16;
            this.ButtonFolderBrowsing2.Tag = "playerdatabackupspath";
            this.ButtonFolderBrowsing2.UseVisualStyleBackColor = true;
            this.ButtonFolderBrowsing2.Click += new System.EventHandler(this.ButtonFolderBrowsing_Click);
            // 
            // CheckBoxCracked
            // 
            this.CheckBoxCracked.Location = new System.Drawing.Point(170, 27);
            this.CheckBoxCracked.Name = "CheckBoxCracked";
            this.CheckBoxCracked.Size = new System.Drawing.Size(105, 45);
            this.CheckBoxCracked.TabIndex = 17;
            this.CheckBoxCracked.Tag = "online-mode";
            this.CheckBoxCracked.Text = "Cracked";
            this.CheckBoxCracked.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(170, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 45);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Tag = "pvp";
            this.checkBox2.Text = "PVP";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gamemode";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(147, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Difficulty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxGamemode
            // 
            this.ComboBoxGamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGamemode.FormattingEnabled = true;
            this.ComboBoxGamemode.Items.AddRange(new object[] { "Creative", "Survival" });
            this.ComboBoxGamemode.Location = new System.Drawing.Point(12, 269);
            this.ComboBoxGamemode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxGamemode.Name = "ComboBoxGamemode";
            this.ComboBoxGamemode.Size = new System.Drawing.Size(127, 28);
            this.ComboBoxGamemode.TabIndex = 24;
            this.ComboBoxGamemode.Tag = "gamemode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Hard", "Normal", "Easy" });
            this.comboBox1.Location = new System.Drawing.Point(147, 269);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Tag = "difficulty";
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(118, 94);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(161, 44);
            this.checkBox6.TabIndex = 30;
            this.checkBox6.Text = "Spawn Protection";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 144);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 26);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(13, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Seed";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 415);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 26);
            this.textBox4.TabIndex = 29;
            this.textBox4.Tag = "level-seed";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 38);
            this.label4.TabIndex = 34;
            this.label4.Text = "World Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(13, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 38);
            this.label10.TabIndex = 32;
            this.label10.Text = "Level Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(13, 341);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 26);
            this.textBox7.TabIndex = 31;
            this.textBox7.Tag = "level-type";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(12, 495);
            this.numericUpDown3.Maximum = new decimal(new int[] { 29999984, 0, 0, 0 });
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(263, 26);
            this.numericUpDown3.TabIndex = 34;
            this.numericUpDown3.Tag = "max-world-size";
            // 
            // ButtonOpenServerFolder
            // 
            this.ButtonOpenServerFolder.Location = new System.Drawing.Point(668, 373);
            this.ButtonOpenServerFolder.Name = "ButtonOpenServerFolder";
            this.ButtonOpenServerFolder.Size = new System.Drawing.Size(291, 52);
            this.ButtonOpenServerFolder.TabIndex = 35;
            this.ButtonOpenServerFolder.Text = "Open Server Folder";
            this.ButtonOpenServerFolder.UseVisualStyleBackColor = true;
            this.ButtonOpenServerFolder.Click += new System.EventHandler(this.ButtonOpenServerFolder_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(668, 431);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(291, 52);
            this.ButtonSave.TabIndex = 36;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDeleteServer
            // 
            this.ButtonDeleteServer.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonDeleteServer.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteServer.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteServer.Location = new System.Drawing.Point(668, 489);
            this.ButtonDeleteServer.Name = "ButtonDeleteServer";
            this.ButtonDeleteServer.Size = new System.Drawing.Size(289, 32);
            this.ButtonDeleteServer.TabIndex = 38;
            this.ButtonDeleteServer.Text = "Delete Server";
            this.ButtonDeleteServer.UseVisualStyleBackColor = false;
            this.ButtonDeleteServer.Click += new System.EventHandler(this.ButtonDeleteServer_Click);
            // 
            // ButtonFolderBrowsing3
            // 
            this.ButtonFolderBrowsing3.Location = new System.Drawing.Point(581, 461);
            this.ButtonFolderBrowsing3.Name = "ButtonFolderBrowsing3";
            this.ButtonFolderBrowsing3.Size = new System.Drawing.Size(42, 43);
            this.ButtonFolderBrowsing3.TabIndex = 41;
            this.ButtonFolderBrowsing3.Tag = "javaruntimepath";
            this.ButtonFolderBrowsing3.UseVisualStyleBackColor = true;
            this.ButtonFolderBrowsing3.Click += new System.EventHandler(this.ButtonFolderBrowsing_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(321, 438);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 27);
            this.label11.TabIndex = 40;
            this.label11.Text = "Java Runtime";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(321, 469);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 26);
            this.textBox3.TabIndex = 39;
            this.textBox3.Tag = "javaruntimepath";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(319, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Server Backups Path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxSpawnProtection
            // 
            this.CheckBoxSpawnProtection.Location = new System.Drawing.Point(797, 100);
            this.CheckBoxSpawnProtection.Name = "CheckBoxSpawnProtection";
            this.CheckBoxSpawnProtection.Size = new System.Drawing.Size(186, 34);
            this.CheckBoxSpawnProtection.TabIndex = 44;
            this.CheckBoxSpawnProtection.Tag = "";
            this.CheckBoxSpawnProtection.Text = "Spawn Protection";
            this.CheckBoxSpawnProtection.UseVisualStyleBackColor = true;
            this.CheckBoxSpawnProtection.CheckedChanged += new System.EventHandler(this.CheckBoxSpawnProtection_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(797, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 35);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Tag = "serverbackupson";
            this.checkBox1.Text = "Server Backups";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mkeq
            // 
            this.mkeq.Location = new System.Drawing.Point(956, 9);
            this.mkeq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mkeq.Name = "mkeq";
            this.mkeq.Size = new System.Drawing.Size(21, 22);
            this.mkeq.TabIndex = 46;
            this.mkeq.Tag = "tooltip";
            this.ToolTip.SetToolTip(this.mkeq, resources.GetString("mkeq.ToolTip"));
            // 
            // NumericSpawnProtection
            // 
            this.NumericSpawnProtection.Location = new System.Drawing.Point(797, 132);
            this.NumericSpawnProtection.Name = "NumericSpawnProtection";
            this.NumericSpawnProtection.Size = new System.Drawing.Size(162, 26);
            this.NumericSpawnProtection.TabIndex = 49;
            this.NumericSpawnProtection.Tag = "spawn-protection";
            this.NumericSpawnProtection.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(335, 27);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(160, 45);
            this.checkBox5.TabIndex = 51;
            this.checkBox5.Tag = "allow-flight";
            this.checkBox5.Text = "Allow Flight";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Location = new System.Drawing.Point(335, 59);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(114, 45);
            this.checkBox9.TabIndex = 52;
            this.checkBox9.Tag = "usegui";
            this.checkBox9.Text = "Use GUI";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(298, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 260);
            this.label12.TabIndex = 53;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(639, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 260);
            this.label13.TabIndex = 54;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(797, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(184, 34);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.Tag = "playerdatabackupson";
            this.checkBox3.Text = "Playerdata Backups";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(170, 91);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(105, 45);
            this.checkBox7.TabIndex = 58;
            this.checkBox7.Tag = "hardcore";
            this.checkBox7.Text = "Hardcore";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(170, 123);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(162, 45);
            this.checkBox4.TabIndex = 59;
            this.checkBox4.Tag = "enable-command-block";
            this.checkBox4.Text = "Command Blocks";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(780, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 131);
            this.label15.TabIndex = 60;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(168, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(802, 1);
            this.label14.TabIndex = 61;
            this.label14.Text = "label14";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 52);
            this.button1.TabIndex = 63;
            this.button1.Text = "Open Console";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Location = new System.Drawing.Point(335, 91);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(114, 45);
            this.checkBox8.TabIndex = 65;
            this.checkBox8.Tag = "upnpon";
            this.checkBox8.Text = "Use UPnP";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            // 
            // ServerEditPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(988, 541);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.NumericSpawnProtection);
            this.Controls.Add(this.mkeq);
            this.Controls.Add(this.CheckBoxSpawnProtection);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButtonFolderBrowsing3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ButtonDeleteServer);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ButtonOpenServerFolder);
            this.Controls.Add(this.CheckBoxCracked);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ComboBoxGamemode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonFolderBrowsing2);
            this.Controls.Add(this.ButtonFolderBrowsing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ServerEditPrompt";
            this.Text = " Server Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerEditPrompt_FormClosed);
            this.Load += new System.EventHandler(this.ServerEditPrompt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpawnProtection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.CheckBox checkBox8;

        private System.Windows.Forms.ToolTip ToolTip;

        private System.Windows.Forms.Label mkeq;

        private System.Windows.Forms.CheckBox CheckBoxSpawnProtection;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;

        private System.Windows.Forms.Button ButtonFolderBrowsing3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Button ButtonDeleteServer;

        private System.Windows.Forms.Button ButtonOpenServerFolder;
        private System.Windows.Forms.Button ButtonSave;

        private System.Windows.Forms.NumericUpDown numericUpDown3;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;

        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.CheckBox checkBox5;

        private System.Windows.Forms.CheckBox checkBox4;

        private System.Windows.Forms.ComboBox ComboBoxGamemode;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.CheckBox CheckBoxCracked;

        private System.Windows.Forms.Button ButtonFolderBrowsing;
        private System.Windows.Forms.Button ButtonFolderBrowsing2;

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxServerName;

        #endregion

        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.NumericUpDown NumericSpawnProtection;
    }
}