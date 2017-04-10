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
    public partial class ReferenceBox : UserControl, INotifyPropertyChanged
    {
        public ReferenceBox()
        {
            InitializeComponent();
            tboxItem.DataBindings.Add("Text", this, "SelectedItem");
        }

        public object DataSource
        {
            get { return bsList.DataSource; }
            set
            {
                bsList.DataSource = value;
                FillAutoCompleteList();
            }
        }

        private object selectedItem;

        public object SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
                OnSelectedItemChanged();
            }
        }

        private void FillAutoCompleteList()
        {
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            if (DataSource != null)
            {
                foreach (object item in bsList)
                {
                    stringCollection.Add(item.ToString());
                }
            }

            tboxItem.AutoCompleteCustomSource = stringCollection;
        }

        private PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (onPropertyChanged != null)
                onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        private EventHandler<ItemEventArgs> onSelectedItemChanged;

        public event EventHandler<ItemEventArgs> SelectedItemChanged
        {
            add { onSelectedItemChanged += value; }
            remove { onSelectedItemChanged -= value; }
        }

        private void OnSelectedItemChanged()
        {
            if (onSelectedItemChanged != null)
                onSelectedItemChanged(this, new ItemEventArgs(selectedItem));
        }

        private void tboxItem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tboxItem.Text))
            {
                SelectedItem = null;
                e.Cancel = false;
                return;
            }

            if (DataSource != null)
            {
                foreach (object item in bsList)
                {
                    if (string.Equals(item.ToString(), tboxItem.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        SelectedItem = item;
                        e.Cancel = false;
                        return;
                    }
                }
            }

            if (SelectedItem != null)
                tboxItem.Text = SelectedItem.ToString();
            else
                tboxItem.Clear();
            e.Cancel = false;
        }

        private void bsList_DataSourceChanged(object sender, EventArgs e)
        {
            FillAutoCompleteList();
        }
    }
}
