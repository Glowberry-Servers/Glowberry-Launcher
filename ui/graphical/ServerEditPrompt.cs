﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using glowberry.api.server;
using glowberry.api.server.enumeration;
using glowberry.common.caches;
using glowberry.common.models;
using glowberry.utils;
using LaminariaCore_General.common;
using LaminariaCore_General.utils;
using Microsoft.WindowsAPICodePack.Dialogs;
using static glowberry.common.configuration.Constants;

namespace glowberry.ui.graphical
{
    /// <summary>
    /// This form aims to provide an interface to edit the settings of a server.
    /// </summary>
    public partial class ServerEditPrompt : Form
    {
        /// <summary>
        /// The server API instance to use with this editing prompt.
        /// </summary>
        private ServerEditing EditingAPI { get; set; }

        /// <summary>
        /// The values of the rolling backups that have been loaded into the form. This is useful
        /// for resetting the values if the user decides to disable and re-enable the rolling backups.
        /// </summary>
        private int[] LoadedRollingValues { get; set; } = new int[2];

        /// <summary>
        /// Main constructor for the ServerEditPrompt form. Initialises the form and loads the
        /// information from the server.properties file into the form.
        /// </summary>
        /// <param name="serverSection">The Server Section to use to edit the data.</param>
        public ServerEditPrompt(Section serverSection)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            EditingAPI = new ServerAPI().Editor(serverSection.SimpleName);
            
            // Loads the properties and settings into the form
            LoadToForm(EditingAPI.GetCurrentServerSettings());
            LoadedRollingValues[0] = EditingAPI.GetServerInformation().RollingServerBackups;
            LoadedRollingValues[1] = EditingAPI.GetServerInformation().RollingPlayerdataBackups;

            // Edits some values in the form that have to be manually placed
            CheckBoxCracked.Checked = EditingAPI.Check(ServerLogicChecks.IsCracked);
            CheckBoxSpawnProtection.Checked = EditingAPI.Check(ServerLogicChecks.IsSpawnProtectionEnabled);
            TextBoxServerName.Text = EditingAPI.GetServerName();
            
            CheckBoxRollingServerBackups.Checked = EditingAPI.GetServerInformation().RollingServerBackups > 0;
            CheckBoxRollingPlayerdataBackups.Checked = EditingAPI.GetServerInformation().RollingPlayerdataBackups > 0;
            NumericServerBackups.Enabled = CheckBoxRollingServerBackups.Checked;
            NumericPlayerdataBackups.Enabled = CheckBoxRollingPlayerdataBackups.Checked;
            
            CheckBoxStartOnBoot.Enabled = CheckBoxHandleFirewall.Enabled = PermissionUtils.IsUserAdmin();
            CheckBoxStartOnBoot.Checked = WindowsSchedulerUtils.IsServerInScheduler(EditingAPI.GetServerSection());

            // Loads the icons for the folder browsing buttons
            ButtonFolderBrowsing.Image = Image.FromFile(FileSystem.GetFirstDocumentNamed(Path.GetFileName(ConfigurationManager.AppSettings.Get("Asset.Icon.FolderBrowser"))));
            ButtonFolderBrowsing2.Image = Image.FromFile(FileSystem.GetFirstDocumentNamed(Path.GetFileName(ConfigurationManager.AppSettings.Get("Asset.Icon.FolderBrowser"))));
            ButtonFolderBrowsing3.Image = Image.FromFile(FileSystem.GetFirstDocumentNamed(Path.GetFileName(ConfigurationManager.AppSettings.Get("Asset.Icon.FolderBrowser"))));

            // Sets the info layout pictures
            foreach (Label label in Controls.OfType<Label>().Where(x => x.Tag != null && x.Tag.ToString().Equals("tooltip")).ToList())
            {
                label.BackgroundImage = Image.FromFile(FileSystem.GetFirstDocumentNamed(Path.GetFileName(ConfigurationManager.AppSettings.Get("Asset.Icon.Tooltip"))));
                label.BackgroundImageLayout = ImageLayout.Zoom;
            }
            
            // Disables (or enables) the additional backup settings
            CheckBoxPlayerdataBackups_CheckedChanged(null, null);
            CheckBoxServerBackups_CheckedChanged(null, null);
        }

        /// <summary>
        /// Constructor for the ServerEditPrompt form. Used to build the fields of the form.
        /// </summary>
        private ServerEditPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns a list of all the tags that are used in the editor.
        /// These correspond to the names of the keys in the server.properties file.
        /// </summary>
        /// <returns>List(String) of all the tags in lowercase</returns>
        public static List<string> GetTags()
        {
            List<string> tags = new ();

            // Gets all the tags from the fields in the ServerEditPrompt class filtering out empty ones
            foreach (FieldInfo field in typeof(ServerEditPrompt).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Control control = field.GetValue(new ServerEditPrompt()) as Control;
                if (control?.Tag == null || control.Tag.ToString() == string.Empty) continue;

                tags.Add(control.Tag.ToString());
            }
            
            return tags;
        }
        
        /// <summary>
        /// Switches the focus to the first label in the form when the form is loaded, so that nothing
        /// is selected.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ServerEditPrompt_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
        }

        /// <summary>
        /// Collects all the information from the form and returns it as a dictionary.
        /// </summary>
        /// <returns>A dictionary containing all the settings in the form as a dictionary</returns>
        private Dictionary<string, string> FormToDictionary()
        {
            Dictionary<string, string> formInformation = new ();

            // Gets the information from the valid controls, excluding the buttons and the checkboxes,
            // and adds it them to the dictionary
            Controls.OfType<Control>()
                .Where(x => x.GetType() != typeof(CheckBox) && x.GetType() != typeof(Button) && x.GetType() != typeof(Label) 
                            && x.Tag != null && x.Tag.ToString() != string.Empty).ToList()
                .ForEach(x => formInformation.Add(x.Tag.ToString(), x.Text));

            // Does the same, but specifically for checkboxes, since they have to be parsed for booleans
            Controls.OfType<CheckBox>()
                .Where(x => x.Tag != null && x.Tag.ToString() != string.Empty).ToList()
                .ForEach(x => formInformation.Add(x.Tag.ToString(), x.Checked.ToString().ToLower()));

            // Inverts the online mode since the checkbox is named "Cracked" (Opposite of online mode), and
            // sets the spawn protection to 0 if it is disabled in the form
            formInformation["online-mode"] = (!bool.Parse(formInformation["online-mode"])).ToString().ToLower();
            if (!CheckBoxSpawnProtection.Checked) formInformation["spawn-protection"] = "0";

            // These two are exceptions just used as pointers internally, and this is the best way to remove them
            formInformation.Remove("server");
            formInformation.Remove("playerdata");
            
            return formInformation;
        }

        /// <summary>
        /// Loads a dictionary with information coming from the server.properties file into the
        /// fields inside of the ServerEditPrompt form. Every key is mapped to a tag existing in every
        /// Text, Combo and Numeric box.
        /// </summary>
        /// <param name="dictionaryToLoad">The dictionary to load into the form</param>
        private void LoadToForm(Dictionary<string, string> dictionaryToLoad)
        {
            foreach (KeyValuePair<string, string> item in dictionaryToLoad)
            {
                // Finds the control with the same tag as the key in the dictionary
                Control control = Controls.OfType<Control>()
                    .Where(x => x.GetType() != typeof(Button) && x.Tag != null)
                    .FirstOrDefault(x => x.Tag.ToString().Equals(item.Key));
                
                if (control == null) continue;

                // If the control is a checkbox, we have to parse the value to a boolean, otherwise we
                // just set the text of the control to the value.
                if (control.GetType() == typeof(CheckBox))
                    ((CheckBox)control).Checked = bool.Parse(item.Value);
                
                else control.Text = item.Value;
            }
        }

        /// <summary>
        /// Creates a new process, opening the server's folder.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ButtonOpenServerFolder_Click(object sender, EventArgs e)
        {
            Process.Start(EditingAPI.GetServerSection().SectionFullPath);
        }

        /// <summary>
        /// Saves the current form's properties into the server.properties file and closes the form.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Gets the necessary resources to edit save the server's properties and settings
            string newServerSectionPath = Path.GetDirectoryName(EditingAPI.GetServerSection().SectionFullPath) + "/" + TextBoxServerName.Text;

            try
            {
                _ = new ServerInformation().Update(FormToDictionary());  // Serves as a sanity check for the form values
                EditingAPI.UpdateServerSettings(FormToDictionary());
            }
            
            catch (SystemException)
            {
                MessageBox.Show(@"One or more fields are incorrectly filled. Please correct them and try again.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Renames the server's folder to the new name if it changed.
            if (!EditingAPI.GetServerSection().SectionFullPath.EqualsPath(newServerSectionPath))
            {
                ServerList.INSTANCE.RemoveFromList(EditingAPI.GetServerName());
                EditingAPI.ChangeServerName(TextBoxServerName.Text);
                ServerList.INSTANCE.AddServerToList(EditingAPI.GetServerSection());
            }
            
            // Checks if the server needs to be either added or removed from the startup schedule
            if (CheckBoxStartOnBoot.Checked) WindowsSchedulerUtils.AddServerToTaskScheduler(EditingAPI.GetServerSection());
            else WindowsSchedulerUtils.RemoveServerFromTaskScheduler(EditingAPI.GetServerSection());

            Close();
        }
 
        /// <summary>
        /// Turns the spawn protection numeric box on and off depending on the state of the checkbox.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CheckBoxSpawnProtection_CheckedChanged(object sender, EventArgs e)
        {
            NumericSpawnProtection.Visible = CheckBoxSpawnProtection.Checked;
        }

        /// <summary>
        /// Allows the user to delete the server from the list, and deletes the directory from disk.
        /// This is done after receiving confirmation from the user.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ButtonDeleteServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this server?", @"Delete server",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // Removes the server from the list, deletes the directory and closes the form.
                ServerList.INSTANCE.RemoveFromList(EditingAPI.GetServerName());
                EditingAPI.DeleteServer();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"An error occurred while deleting the server: " + exception.Message, @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens a folder browser dialog bound to a given TextBox in its Tag, and allows the user to select
        /// a folder to use as the server's backup path.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ButtonFolderBrowsing_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox boundTextBox =
                Controls.OfType<TextBox>().First(x => x.Tag.ToString() == button.Tag.ToString());

            CommonOpenFileDialog fileDialog = new CommonOpenFileDialog { IsFolderPicker = true };;
            if (fileDialog.ShowDialog() == CommonFileDialogResult.Ok) boundTextBox.Text = fileDialog.FileName;
        }

        /// <summary>
        /// Refreshes the grid after every edit to any server's properties and settings.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ServerEditPrompt_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerList.INSTANCE.SortGrid();
        }

        /// <summary>
        /// Unlocks the rolling backups numeric box when the checkbox is checked, and locks it when it is not.
        /// Upon unlocking, the numeric box's minimum is set to 1 and upon locking, to -1, aswell as the value.
        /// </summary>
        private void HandleCheckBoxRollingBackupsNumeric(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox) sender;

            foreach (NumericUpDown numericBox in Controls.OfType<NumericUpDown>())
            {
                // If the numeric box's name doesn't contain the tag of the checkbox, skip it.
                if (!numericBox.Name.ToLower().Contains(checkBox.Tag.ToString())) continue;
                if (numericBox.Name.Contains("Delay")) continue;
                
                numericBox.Enabled = checkBox.Checked;
                numericBox.Minimum = checkBox.Checked ? 1 : -1;
                
                // If the numeric box is not visible, save the value to the loaded values array before resetting it.
                if (!numericBox.Visible) LoadedRollingValues[checkBox.Tag.ToString() == "server" ? 0 : 1] = (int)numericBox.Value;

                // Loads the value from the rolling backups, and calculates the definite value to set based on the minimum
                int loadedValue = LoadedRollingValues[checkBox.Tag.ToString() == "server" ? 0 : 1];
                int definiteValue = loadedValue >= numericBox.Minimum ? loadedValue : (int)numericBox.Minimum;
                
                numericBox.Value = checkBox.Checked ? numericBox.Value = definiteValue : numericBox.Value = -1;
            }
        }

        /// <summary>
        /// Changes the enabled status of the extra server backups information
        /// to match the checked state of the server backups checkbox.
        /// </summary>
        private void CheckBoxServerBackups_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxRollingServerBackups.Enabled = NumericServerBackups.Enabled =
                LabelServerDelay.Enabled = CheckBoxServerBackups.Checked;
            
            NumericServerBackups.Enabled = CheckBoxRollingServerBackups.Checked;
        }


        /// <summary>
        /// Changes the enabled status of the extra playerdata backups information
        /// to match the checked state of the playerdata backups checkbox.
        /// </summary>
        private void CheckBoxPlayerdataBackups_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxRollingPlayerdataBackups.Enabled = NumericPlayerdataBackups.Enabled =
                LabelPlayerdataDelay.Enabled = CheckBoxPlayerdataBackups.Checked;
            
            NumericPlayerdataBackups.Enabled = CheckBoxRollingPlayerdataBackups.Checked;
        }
    }
}