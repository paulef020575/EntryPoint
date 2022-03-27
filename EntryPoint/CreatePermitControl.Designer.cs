namespace EntryPoint
{
    partial class CreatePermitControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxLicensePlate = new System.Windows.Forms.TextBox();
            this.tboxVehicleMark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDocumentHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.pickTo = new System.Windows.Forms.DateTimePicker();
            this.pickFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.tboxDriverName = new System.Windows.Forms.TextBox();
            this.tboxContact = new System.Windows.Forms.TextBox();
            this.itemListPanel = new System.Windows.Forms.Panel();
            this.lboxPermitList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tboxComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.itemListPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tboxLicensePlate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboxVehicleMark, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDocumentHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelPeriod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboxCargo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxDriverName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tboxContact, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.itemListPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tboxComment, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tboxLicensePlate
            // 
            this.tboxLicensePlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxLicensePlate.Location = new System.Drawing.Point(203, 147);
            this.tboxLicensePlate.Name = "tboxLicensePlate";
            this.tboxLicensePlate.Size = new System.Drawing.Size(378, 26);
            this.tboxLicensePlate.TabIndex = 3;
            this.tboxLicensePlate.Validated += new System.EventHandler(this.tboxLicensePlate_Validated);
            // 
            // tboxVehicleMark
            // 
            this.tboxVehicleMark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxVehicleMark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxVehicleMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxVehicleMark.Location = new System.Drawing.Point(203, 115);
            this.tboxVehicleMark.Name = "tboxVehicleMark";
            this.tboxVehicleMark.Size = new System.Drawing.Size(378, 26);
            this.tboxVehicleMark.TabIndex = 2;
            this.tboxVehicleMark.Validating += new System.ComponentModel.CancelEventHandler(this.tboxVehicleMark_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 215);
            this.label8.TabIndex = 14;
            this.label8.Text = "Комментарий";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "№ телефона";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "ФИО водителя";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гос. номер";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Марка т/с";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пропуск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDocumentHeader
            // 
            this.lblDocumentHeader.AutoSize = true;
            this.lblDocumentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDocumentHeader.Location = new System.Drawing.Point(203, 0);
            this.lblDocumentHeader.Name = "lblDocumentHeader";
            this.lblDocumentHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblDocumentHeader.Size = new System.Drawing.Size(378, 40);
            this.lblDocumentHeader.TabIndex = 0;
            this.lblDocumentHeader.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Период действия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPeriod
            // 
            this.panelPeriod.Controls.Add(this.pickTo);
            this.panelPeriod.Controls.Add(this.pickFrom);
            this.panelPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPeriod.Location = new System.Drawing.Point(203, 43);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Padding = new System.Windows.Forms.Padding(3);
            this.panelPeriod.Size = new System.Drawing.Size(378, 32);
            this.panelPeriod.TabIndex = 0;
            // 
            // pickTo
            // 
            this.pickTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickTo.Location = new System.Drawing.Point(154, 3);
            this.pickTo.Name = "pickTo";
            this.pickTo.Size = new System.Drawing.Size(128, 26);
            this.pickTo.TabIndex = 1;
            // 
            // pickFrom
            // 
            this.pickFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.pickFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickFrom.Location = new System.Drawing.Point(3, 3);
            this.pickFrom.Name = "pickFrom";
            this.pickFrom.Size = new System.Drawing.Size(128, 26);
            this.pickFrom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Груз";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxCargo
            // 
            this.cboxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(203, 81);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(378, 28);
            this.cboxCargo.TabIndex = 1;
            this.cboxCargo.SelectedIndexChanged += new System.EventHandler(this.cboxCargo_SelectedIndexChanged);
            // 
            // tboxDriverName
            // 
            this.tboxDriverName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxDriverName.Location = new System.Drawing.Point(203, 179);
            this.tboxDriverName.Name = "tboxDriverName";
            this.tboxDriverName.Size = new System.Drawing.Size(378, 26);
            this.tboxDriverName.TabIndex = 4;
            // 
            // tboxContact
            // 
            this.tboxContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxContact.Location = new System.Drawing.Point(203, 211);
            this.tboxContact.Name = "tboxContact";
            this.tboxContact.Size = new System.Drawing.Size(378, 26);
            this.tboxContact.TabIndex = 5;
            // 
            // itemListPanel
            // 
            this.itemListPanel.Controls.Add(this.lboxPermitList);
            this.itemListPanel.Controls.Add(this.label9);
            this.itemListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListPanel.Location = new System.Drawing.Point(587, 3);
            this.itemListPanel.Name = "itemListPanel";
            this.tableLayoutPanel1.SetRowSpan(this.itemListPanel, 8);
            this.itemListPanel.Size = new System.Drawing.Size(300, 449);
            this.itemListPanel.TabIndex = 15;
            // 
            // lboxPermitList
            // 
            this.lboxPermitList.DisplayMember = "Vehicle";
            this.lboxPermitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxPermitList.FormattingEnabled = true;
            this.lboxPermitList.ItemHeight = 20;
            this.lboxPermitList.Location = new System.Drawing.Point(0, 26);
            this.lboxPermitList.Name = "lboxPermitList";
            this.lboxPermitList.Size = new System.Drawing.Size(300, 423);
            this.lboxPermitList.TabIndex = 0;
            this.lboxPermitList.DoubleClick += new System.EventHandler(this.lboxPermitList_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ранее приезжали:";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonSkip);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 458);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(884, 39);
            this.panel1.TabIndex = 18;
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Location = new System.Drawing.Point(507, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSkip.Location = new System.Drawing.Point(632, 2);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(125, 35);
            this.buttonSkip.TabIndex = 2;
            this.buttonSkip.Text = "Пропустить";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(757, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tboxComment
            // 
            this.tboxComment.AcceptsReturn = true;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Location = new System.Drawing.Point(203, 243);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.Size = new System.Drawing.Size(378, 209);
            this.tboxComment.TabIndex = 6;
            // 
            // CreatePermitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePermitControl";
            this.Size = new System.Drawing.Size(890, 500);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelPeriod.ResumeLayout(false);
            this.itemListPanel.ResumeLayout(false);
            this.itemListPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDocumentHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPeriod;
        private System.Windows.Forms.DateTimePicker pickTo;
        private System.Windows.Forms.DateTimePicker pickFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxDriverName;
        private System.Windows.Forms.Panel itemListPanel;
        private System.Windows.Forms.TextBox tboxLicensePlate;
        private System.Windows.Forms.TextBox tboxVehicleMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxContact;
        private System.Windows.Forms.ListBox lboxPermitList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.Button buttonSkip;
    }
}
