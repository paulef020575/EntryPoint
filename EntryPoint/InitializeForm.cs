using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryPoint.Properties;
using System.IO;
using EntryControl.Classes;

namespace EntryPoint
{
    public partial class InitializeForm : Form
    {
        public InitializeForm()
        {
            InitializeComponent();
        }

        private void InitializeForm_Load(object sender, EventArgs e)
        {
            ReadServerList();
            ReadSettings();

            ReadEntryPointList();
        }

        private void ReadEntryPointList()
        {
            try
            {
                EntryControlDatabase database = new EntryControlDatabase(Settings.Default.Server, Settings.Default.Path);
                cboxEntryPoint.DataSource = EntryControl.Classes.EntryPoint.LoadList(database);

                cboxEntryPoint.SelectedItem = new EntryControl.Classes.EntryPoint(Settings.Default.EntryPoint, "");
            }
            catch (Exception exc)
            {
                lblEntryPoint.Visible = false;
                cboxEntryPoint.Visible = false;
            }
        }

        private void ReadServerList()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = Path.Combine(path, "servers.txt");

            string[] servers = File.ReadAllLines(path);

            foreach (string serverName in servers)
                cboxServer.Items.Add(serverName);
        }

        private void ReadSettings()
        {
            cboxServer.Text = Settings.Default.Server;
            tboxPath.Text = Settings.Default.Path;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                TryToConnect();

                SaveSettings();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удается соединиться с базой данных");
            }
        }

        private void TryToConnect()
        {
            EntryControlDatabase database = new EntryControlDatabase(cboxServer.Text, tboxPath.Text);
        }

        private void SaveSettings()
        {
            Settings.Default.Server = cboxServer.Text;
            Settings.Default.Path = tboxPath.Text;

            if (cboxEntryPoint.Visible)
            {
                EntryControl.Classes.EntryPoint point = (EntryControl.Classes.EntryPoint)cboxEntryPoint.SelectedItem;
                Settings.Default.EntryPoint = point.Id;
            }

            Settings.Default.Save();
        }
    }
}
