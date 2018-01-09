using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EntryPoint.Properties;

namespace EntryPoint
{
    public partial class CreatePermitControl : UserControl
    {
        private EntryControlDatabase Database;

        private BindingList<VehicleMark> markList;

        private VehicleMark selectedVehicleMark;

        public Permit Permit
        {
            get { return (Permit)bsDocument.DataSource; }
            set { bsDocument.DataSource = value; }
        }

        private CreatePermitControl()
        {
            InitializeComponent();
        }

        public CreatePermitControl(EntryControlDatabase database)
            : this()
        {
            Database = database;

            PreloadData();
            AddBindings();

            Permit = CreateNewPermit();
        }

        private void AddBindings()
        {
            lblDocumentHeader.DataBindings.Add("Text", bsDocument, "Header", true, DataSourceUpdateMode.OnPropertyChanged);
            pickFrom.DataBindings.Add("Value", bsDocument, "DateFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            pickTo.DataBindings.Add("Value", bsDocument, "DateTo", true, DataSourceUpdateMode.OnPropertyChanged);
            cboxCargo.DataBindings.Add("SelectedItem", bsDocument, "Cargo", true, DataSourceUpdateMode.OnPropertyChanged);

            tboxDriverName.DataBindings.Add("Text", bsDocument, "DriverName", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxContact.DataBindings.Add("Text", bsDocument, "Contact", true, DataSourceUpdateMode.OnPropertyChanged);
            tboxComment.DataBindings.Add("Text", bsDocument, "Comment", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void PreloadData()
        {
            cboxCargo.DataSource = Cargo.LoadListForEntryPoint(Database);
            LoadMarkList();
        }

        private void LoadMarkList()
        {
            markList = new BindingList<VehicleMark>(VehicleMark.LoadList(Database));
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            foreach (VehicleMark mark in markList)
                stringCollection.Add(mark.ToString());
            tboxVehicleMark.AutoCompleteCustomSource = stringCollection;
        }

        private EntryControl.Classes.Permit CreateNewPermit()
        {
            Permit permit = new Permit();

            permit.Creator = EntryControlDatabase.EntryPointUser;

            permit.Period = DateTime.Today.Year;
            permit.PermitState = new EnumerationItem(1, "временный");
            permit.DateFrom = DateTime.Today;
            permit.DateTo = DateTime.Today.AddDays(1);
            permit.DocNumber = Permit.GetPermitNumber(Database, permit.Period);
            permit.Cargo = EntryControlDatabase.WoodCargo;
            permit.IsMultiEntry = false;

            List<PermitPoint> pointList = permit.GetPointList(Database);
            int currentPointId = Settings.Default.EntryPoint;

            EntryControl.Classes.EntryPoint currentPoint = EntryControl.Classes.EntryPoint.Load(Database, currentPointId);
            permit.Comment = "Создан на проходной " + currentPoint.ToString() + Environment.NewLine + "Объем л/мат: ";

            foreach (PermitPoint item in pointList)
                if (item.Point.Id == currentPointId)
                    item.IsAllowed = true;

            return permit;
        }

 
        private void tboxVehicleMark_Validating(object sender, CancelEventArgs e)
        {
            if (markList != null)
            {
                selectedVehicleMark = GetVehicleMark(tboxVehicleMark.Text);
                if (selectedVehicleMark == null)
                {
                    tboxVehicleMark.Clear();
                }

                lboxPermitList.DataSource = LoadPreviousPermit();
            }
        }

        private VehicleMark GetVehicleMark(string markName)
        {
            foreach (VehicleMark mark in markList)
            {
                if (string.Equals(mark.ToString(), markName, StringComparison.CurrentCultureIgnoreCase))
                    return mark;
            }

            return null;
        }

        private void cboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxPermitList.DataSource = LoadPreviousPermit();
        }

        private List<Permit> LoadPreviousPermit()
        {
            if (Permit != null && Database != null)
                return Permit.LoadList(Database, (Cargo)cboxCargo.SelectedItem, selectedVehicleMark, tboxLicensePlate.Text);
            
            return null;
        }

        private void tboxLicensePlate_Validated(object sender, EventArgs e)
        {
            lboxPermitList.DataSource = LoadPreviousPermit();
        }

        private void lboxPermitList_DoubleClick(object sender, EventArgs e)
        {
            if (lboxPermitList.SelectedItem != null)
            {
                Permit.SetProperties((Permit)lboxPermitList.SelectedItem);
                Vehicle vehicle = Permit.Vehicle.LoadCopy(Database);
                tboxVehicleMark.Text = vehicle.VehicleMark.ToString();
                tboxLicensePlate.Text = vehicle.LicensePlate;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Permit.Vehicle == null
                || Permit.Vehicle.Equals(Vehicle.Empty))
            {
                Permit.Vehicle = FindVehicle();
            }

            if (CheckProperties())
                SavePermit();
        }

        private bool CheckProperties()
        {
            bool result = true;

            if (Permit.Vehicle == null)
            {
                tboxLicensePlate.BackColor = Color.LightSalmon;
                result = false;
            }

            if (Permit.DriverName == null || Permit.DriverName.Length == 0)
            {
                tboxDriverName.BackColor = Color.LightSalmon;
                result = false;
            }

            return result;
        }

        private void SavePermit()
        {
            Permit.Save(Database);
            OnItemSaved();
        }

        private Vehicle FindVehicle()
        {
            List<Vehicle> vehicleList = Vehicle.LoadList(Database, null, selectedVehicleMark, tboxLicensePlate.Text);

            if (vehicleList.Count == 1)
            {
                Vehicle vehicle = vehicleList[0].LoadCopy(Database);
                tboxVehicleMark.Text = vehicle.VehicleMark.ToString();
                tboxLicensePlate.Text = vehicle.LicensePlate;
                return vehicleList[0];
            }

            if (vehicleList.Count == 0)
                return CreateNewVehicle();

            if (vehicleList.Count > 0)
                MessageBox.Show("Найдено несколько Т/С с указанным гос. номером. Уточните номер Т/С");
  
            return null;
        }

        private Vehicle CreateNewVehicle()
        {
            if (selectedVehicleMark == null)
            {
                MessageBox.Show("Не указана марка Т/С");
                tboxVehicleMark.Select();
                return null;
            }

            if (tboxLicensePlate.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не указан номер Т/С");
                tboxLicensePlate.Select(0, tboxLicensePlate.Text.Length);
                return null;
            }

            int n = 0;
            if (int.TryParse(tboxLicensePlate.Text, out n))
            {
                MessageBox.Show("Неверный формат номера Т/С");
                tboxLicensePlate.Select(0, tboxLicensePlate.Text.Length);
                return null;
            }

            if (MessageBox.Show("Не найдено Т/С с указанным гос. номером. Создать? (ВНИМАНИЕ: убедитесь, что номер ТС указан полностью)",
                                selectedVehicleMark.ToString() + " " + tboxLicensePlate.Text, 
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.VehicleMark = selectedVehicleMark;
                vehicle.LicensePlate = tboxLicensePlate.Text;

                vehicle.Save(Database);
                return vehicle;
            }
            else
            {
                tboxLicensePlate.Select(0, tboxLicensePlate.Text.Length);
                return null;
            }
        }

        #region ItemSaved event

        private EventHandler<ItemEventArgs> onItemSaved;

        public event EventHandler<ItemEventArgs> ItemSaved
        {
            add { onItemSaved += value; }
            remove { onItemSaved -= value; }
        }

        private void OnItemSaved()
        {
            if (onItemSaved != null)
                onItemSaved(this, new ItemEventArgs(Permit));
        }

        #endregion

        #region CancelPermit event

        private EventHandler onCancelPermit;

        public event EventHandler CancelPermit
        {
            add { onCancelPermit += value; }
            remove { onCancelPermit -= value; }
        }

        private void OnCancelPermit()
        {
            if (onCancelPermit != null)
                onCancelPermit(this, EventArgs.Empty);
        }

        #endregion

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OnCancelPermit();
        }

    }
}
