using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;

namespace EntryPoint
{
    public partial class PermitListItem : UserControl
    {
        public Permit Permit { get; private set; }

        private PermitListItem()
        {
            InitializeComponent();
        }

        public PermitListItem(Permit permit)
        {
            InitializeComponent();

            Permit = permit;

            ShowLabelsText();
        }

        private void ShowLabelsText()
        {
            lblVehicle.Text = Permit.Vehicle.ToString();
            lblDriver.Text = Permit.DriverName;
            lblCargo.Text = Permit.Cargo.ToString();
            lblPermitNumber.Text = Permit.FullNumber.ToString();
            lblPeriod.Text = Permit.ActivePeriod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaisePermitSelected();
        }

        private EventHandler<PermitSelectedEventArgs> onPermitSelected;

        public event EventHandler<PermitSelectedEventArgs> PermitSelected
        {
            add { onPermitSelected += value; }
            remove { onPermitSelected -= value; }
        }

        private void RaisePermitSelected()
        {
            if (onPermitSelected != null)
                onPermitSelected(this, new PermitSelectedEventArgs(Permit));
        }

    }
}
