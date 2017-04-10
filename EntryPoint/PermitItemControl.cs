using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System.IO;

namespace EntryPoint
{
    public partial class PermitItemControl : UserControl
    {
        public Permit Permit { get; private set; }
        public EntryControl.Classes.EntryPoint EntryPoint { get; private set; }
        public EntryControlDatabase Database { get; private set; }

        private MaterialPermit materialPermit;

        private PermitItemControl()
        {
            InitializeComponent();
            dgvItemList.AutoGenerateColumns = false;
            //dgvMoving.AutoGenerateColumns = false;
        }

        public PermitItemControl(EntryControlDatabase database, Permit permit, EntryControl.Classes.EntryPoint entryPoint)
            : this()
        {
            Database = database;
            Permit = permit;
            EntryPoint = entryPoint;


            ShowLabelTexts();
        }

        private void ShowLabelTexts()
        {
            lblPermitNumber.Text = Permit.ShortNumber;
            lblPeriod.Text = Permit.ActivePeriod;
            lblEntryPoint.Text = "Допустимые пункты пропуска: " + Permit.EntryPoint.ToString();

            lblVehicle.Text = Permit.Vehicle.ToString();
            lblDriver.Text = Permit.DriverName;
            lblCargo.Text = Permit.Cargo.ToString();
            lblDriverContact.Text = Permit.Contact;

            tboxComment.Text = Permit.GetComment(Database);

            if (Permit.EntryPoint.Equals(EntryControl.Classes.EntryPoint.Empty)
                || Permit.EntryPoint.Equals(EntryPoint))
            {
                lblEntryPoint.ForeColor = SystemColors.ControlText;
                btnEntry.Enabled = true;
            }
            else
            {
                lblEntryPoint.ForeColor = Color.Red;
                btnEntry.Enabled = false;
            }

            btnEntry.Enabled = (btnEntry.Enabled && DateTime.Now >= Permit.DateFrom && DateTime.Today <= Permit.DateTo);


            if (DateTime.Today >= Permit.DateFrom && DateTime.Today <= Permit.DateTo)
                lblPeriod.ForeColor = SystemColors.WindowText;
            else
                lblPeriod.ForeColor = Color.Red;

            if (btnEntry.Enabled)
                btnEntry.BackColor = Color.LightGreen;
            else
                btnEntry.BackColor = SystemColors.Control;


            //dgvMoving.DataSource = PermitMoving.LoadList(Database, Permit);
            materialPermit = Permit.GetMaterialPermit(Database);
            if (materialPermit != null)
            {
                lblMaterialPermit.Text = materialPermit.ToString();
                ShowMaterialPermit();
            }
            else
            {
                lblMaterialPermit.Text = "Не прикреплен";
                materialPermitPanel.Visible = false;
            }

            if (materialPermit != null && !materialPermit.CanExit)
            {
                labelCannotExit.Visible = true;
                btnExit.Enabled = false;
            }
            else
            {
                labelCannotExit.Visible = false;
            }

            if (btnExit.Enabled)
                btnExit.BackColor = Color.LightSalmon;
            else
                btnExit.BackColor = SystemColors.Control;
        }

        private void ShowMaterialPermit()
        {
            lblPerson.Text = materialPermit.Person;
            lblMatPermitVehicle.Text = materialPermit.VehicleMark + " " + materialPermit.LicensePlate;

            dgvItemList.DataSource = materialPermit.GetItemList(Database);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPermit();
        }

        private void PrintPermit()
        {
            StiReport report = new StiReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = Path.Combine(path, "Permit.mrt");

            report.Load(fileName);
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiFirebirdDatabase("EntryDatabase", Database.ConnectionString));
            report.Compile();
            report["permitId"] = Permit.Id;
            report.Show();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            CreateEntry();
        }

        private void CreateEntry()
        {
            PermitMoving moving = PermitMoving.CreateEntry(Permit);
            moving.EntryPoint = EntryPoint;
            moving.MovingTime = DateTime.Now;
            moving.User = User.Empty;
            moving.Save(Database);

            RaiseCloseControl("Пропуск " + Permit.ShortNumber + ": НА ТЕРРИТОРИИ С " + moving.MovingTime.ToString("dd.MM.yyyy HH:mm"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateExit();
        }

        private void CreateExit()
        {
            if (materialPermit != null)
                materialPermit.SetEntry(Database, EntryPoint, DateTime.Now);

            PermitMoving moving = PermitMoving.CreateExit(Permit);
            moving.EntryPoint = EntryPoint;
            moving.MovingTime = DateTime.Now;
            moving.User = User.Empty;
            moving.Save(Database);

            if (Permit.IsMultiEntry && Permit.DateTo >= DateTime.Today)
                RaiseCloseControl("Пропуск " + Permit.ShortNumber + ": ВЫЕЗД " + moving.MovingTime.ToString("dd.MM.yyyy HH:mm"));
            else
                ClosePermit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClosePermit();
        }

        private void ClosePermit()
        {
            PermitMoving moving1 = Permit.Close(EntryPoint, User.Empty);
            moving1.Save(Database);

            RaiseCloseControl("Пропуск " + Permit.ShortNumber + ": ЗАКРЫТ " + moving1.MovingTime.ToString("dd.MM.yyyy HH:mm"));
        }



        private EventHandler<MessageEventArgs> onCloseControl;

        public event EventHandler<MessageEventArgs> CloseControl
        {
            add { onCloseControl += value; }
            remove { onCloseControl -= value; }
        }

        private void RaiseCloseControl(string message)
        {
            if (onCloseControl != null)
                onCloseControl(this, new MessageEventArgs(message));
        }


       
    }
}
