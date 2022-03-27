using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryPoint.Wood
{
    public partial class WoodVolumeControl : UserControl
    {
        public WoodVolumeControl()
        {
            InitializeComponent();

            lboxOwnVehicles.Items.Add("МБ а100аа");
            lboxOwnVehicles.Items.Add("МБ а101аа");
            lboxOwnVehicles.Items.Add("Краз в200вв");
            lboxOwnVehicles.Items.Add("Сису е300ее");
        }
    }
}
