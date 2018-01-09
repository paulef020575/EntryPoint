using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntryControl.Classes;
using EntryPoint.Properties;
using System.Reflection;

namespace EntryPoint
{
    public partial class StartForm : Form
    {
        
        private EntryControlDatabase database;
        private EntryControl.Classes.EntryPoint entryPoint;

        public StartForm()
        {
            InitializeComponent();

            btnClear.Image = EntryControl.Resources.Images.Failed;

            database = InitializeDatabase();

            entryPoint = InitializeEntryPoint();

            Text = entryPoint.ToString();
        }

        private EntryControl.Classes.EntryPoint InitializeEntryPoint()
        {
            while (Settings.Default.EntryPoint == 0)
            {
                ShowInitializeForm();
            }

            return EntryControl.Classes.EntryPoint.Load(database, Settings.Default.EntryPoint);

        }

        private EntryControlDatabase InitializeDatabase()
        {
            try
            {
#if DEBUG
                return new EntryControlDatabase("localhost", @"C:\Prog\dispatcher\DISPATCHER.FDB", "sysdba11", "masterkey");
#endif
                return new EntryControlDatabase(Settings.Default.Server, Settings.Default.Path);
            }
            catch (Exception exc)
            {
                ShowInitializeForm();

                return new EntryControlDatabase(Settings.Default.Server, Settings.Default.Path);
            }
        }

        private void ShowInitializeForm()
        {
            InitializeForm form = new InitializeForm();

            if (form.ShowDialog() == DialogResult.Cancel)
                Environment.Exit(0);
        }

        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    if (e.Control)
                    {
                        ShowInitializeForm();
                        database = InitializeDatabase();
                        entryPoint = InitializeEntryPoint();
                    }
                    break;
            }    

        }

        private void keyboardKeyDown(object sender, EventArgs e)
        {
            Button btnKey = (Button)sender;

            if (btnKey.Tag != "back")
            {
                tboxNumber.Text += btnKey.Tag;
            }
            else
            {
                if (tboxNumber.Text.Length > 0)
                    tboxNumber.Text = tboxNumber.Text.Substring(0, tboxNumber.Text.Length - 1);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //if (rbutPermit.Checked)
            //    FindPermitByNum(tboxNumber.Text);

            //if (rbutTruck.Checked)
                FindPermitByVehicle(tboxNumber.Text);
        }

        private void FindPermitByVehicle(string p)
        {
            try
            {
                int number = int.Parse(p);

                ShowFindResult(Permit.LoadForVehicle(database, p));
            }
            catch (FormatException)
            {
                ShowFormatError();
            }
        }

        private void FindPermitByNum(string p)
        {
            try
            {
                int number = int.Parse(p);

                ShowFindResult(Permit.LoadByNumber(database, number));
            }
            catch (FormatException)
            {
                ShowFormatError();
            }
        }

        private void ShowFormatError()
        {
            ShowResultError(Message.FormatError);
        }

        private void ShowResultError(string message)
        {
            resultPanel.Controls.Clear();

            Label label = new Label();
            label.AutoSize = false;
            label.ForeColor = Color.Red;
            label.Text = message;
            label.Font = new Font(FontFamily.GenericMonospace, 36);
            label.Dock = DockStyle.Fill;
            resultPanel.Controls.Add(label);
        }

        private void ShowFindResult(List<Permit> permitList)
        {
            if (permitList.Count == 0)
                ShowResultError(Message.EmptyList);
            else
            {
                if (permitList.Count > 1)
                    ShowPermitList(permitList);
                else
                    ShowPermit(permitList[0]);
            }
        }

        private void ShowPermit(Permit permit)
        {
            resultPanel.Controls.Clear();

            PermitItemControl control = new PermitItemControl(database, permit, entryPoint);
            control.Dock = DockStyle.Fill;
            control.CloseControl += control_PermitClosed;
            resultPanel.Controls.Add(control);
        }

        private void ShowPermitList(List<Permit> permitList)
        {
            resultPanel.Controls.Clear();

            foreach (Permit permit in permitList)
            {
                PermitListItem control = new PermitListItem(permit);
                control.Dock = DockStyle.Top;
                control.PermitSelected += control_PermitSelected;

                resultPanel.Controls.Add(control);
            }

            Label label = new Label();
            label.Font = new Font(FontFamily.GenericMonospace, 36);
            label.Height = 64;
            label.Text = permitList.Count.ToString() + " док.:";
            label.Dock = DockStyle.Top;
            resultPanel.Controls.Add(label);

        }

        void control_PermitSelected(object sender, PermitSelectedEventArgs e)
        {
            ShowPermit(e.Permit);
        }

        void control_PermitClosed(object sender, MessageEventArgs e)
        {
            resultPanel.Controls.Clear();

            Label label = new Label();
            label.Font = new Font(FontFamily.GenericMonospace, 36);
            label.Text = e.Message;
            label.Dock = DockStyle.Fill;
            resultPanel.Controls.Add(label);

            tboxNumber.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateNewPermit();
        }

        private void CreateNewPermit()
        {
            resultPanel.Controls.Clear();

            CreatePermitControl control = new CreatePermitControl(database);
            control.Dock = DockStyle.Fill;
            control.ItemSaved += new EventHandler<ItemEventArgs>(newPermitSaved);
            control.CancelPermit += new EventHandler(newPermitCancel);
            resultPanel.Controls.Add(control);
        }

        void newPermitCancel(object sender, EventArgs e)
        {
            resultPanel.Controls.Clear();
        }

        void newPermitSaved(object sender, ItemEventArgs e)
        {
            ShowPermit(((Permit)e.Item).LoadCopy(database));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxNumber.Clear();
        }

    }
}
