namespace EntryPoint
{
    partial class PermitItemControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPermitNumber = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDriverContact = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialPermitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblMatPermitVehicle = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.ColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCannotExit = new System.Windows.Forms.Label();
            this.lblMaterialPermit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxComment = new System.Windows.Forms.TextBox();
            this.lboxPointList = new System.Windows.Forms.ListBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.materialPermitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel1.Controls.Add(this.lblEntryPoint, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPermitNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPeriod, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tboxComment, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lboxPointList, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.AutoSize = true;
            this.lblEntryPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEntryPoint.Location = new System.Drawing.Point(3, 210);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Size = new System.Drawing.Size(232, 150);
            this.lblEntryPoint.TabIndex = 9;
            this.lblEntryPoint.Text = "Разрешенные пункты пропуска";
            this.lblEntryPoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnEntry);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(241, 143);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 70);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::EntryPoint.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 64);
            this.btnPrint.TabIndex = 0;
            this.toolTips.SetToolTip(this.btnPrint, "Печать пропуска");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.LightGreen;
            this.btnEntry.BackgroundImage = global::EntryPoint.Properties.Resources.Entry;
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntry.Location = new System.Drawing.Point(120, 3);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(100, 64);
            this.btnEntry.TabIndex = 1;
            this.toolTips.SetToolTip(this.btnEntry, "Оформить въезд");
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExit.BackgroundImage = global::EntryPoint.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(238, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 64);
            this.btnExit.TabIndex = 2;
            this.toolTips.SetToolTip(this.btnExit, "Оформить выезд");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::EntryPoint.Properties.Resources.lock2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(356, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 64);
            this.button3.TabIndex = 3;
            this.toolTips.SetToolTip(this.button3, "Закрыть пропуск");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPermitNumber
            // 
            this.lblPermitNumber.AutoSize = true;
            this.lblPermitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPermitNumber.Location = new System.Drawing.Point(3, 0);
            this.lblPermitNumber.Name = "lblPermitNumber";
            this.lblPermitNumber.Size = new System.Drawing.Size(228, 70);
            this.lblPermitNumber.TabIndex = 1;
            this.lblPermitNumber.Text = "lblPermitNumber";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriod.Location = new System.Drawing.Point(3, 70);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(232, 70);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "lblActivePeriod";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblDriverContact, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCargo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDriver, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblVehicle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(241, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(473, 134);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblDriverContact
            // 
            this.lblDriverContact.AutoSize = true;
            this.lblDriverContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDriverContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverContact.Location = new System.Drawing.Point(239, 67);
            this.lblDriverContact.Name = "lblDriverContact";
            this.lblDriverContact.Size = new System.Drawing.Size(231, 67);
            this.lblDriverContact.TabIndex = 3;
            this.lblDriverContact.Text = "DriverPhone";
            this.lblDriverContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargo.Location = new System.Drawing.Point(3, 67);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(230, 67);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriver.Location = new System.Drawing.Point(239, 0);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(231, 67);
            this.lblDriver.TabIndex = 1;
            this.lblDriver.Text = "Driver";
            this.lblDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicle.Location = new System.Drawing.Point(3, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(230, 67);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "lblVehicle";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.materialPermitPanel);
            this.groupBox1.Controls.Add(this.lblMaterialPermit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 1);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Материальный пропуск";
            // 
            // materialPermitPanel
            // 
            this.materialPermitPanel.ColumnCount = 3;
            this.materialPermitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.materialPermitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.materialPermitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.materialPermitPanel.Controls.Add(this.label3, 0, 1);
            this.materialPermitPanel.Controls.Add(this.label2, 0, 0);
            this.materialPermitPanel.Controls.Add(this.lblPerson, 1, 0);
            this.materialPermitPanel.Controls.Add(this.lblMatPermitVehicle, 1, 1);
            this.materialPermitPanel.Controls.Add(this.dgvItemList, 2, 0);
            this.materialPermitPanel.Controls.Add(this.labelCannotExit, 0, 2);
            this.materialPermitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialPermitPanel.Location = new System.Drawing.Point(3, 42);
            this.materialPermitPanel.Name = "materialPermitPanel";
            this.materialPermitPanel.RowCount = 3;
            this.materialPermitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialPermitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialPermitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialPermitPanel.Size = new System.Drawing.Size(705, 142);
            this.materialPermitPanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Т/средство";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Предъявитель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(144, 0);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(51, 20);
            this.lblPerson.TabIndex = 2;
            this.lblPerson.Text = "label4";
            // 
            // lblMatPermitVehicle
            // 
            this.lblMatPermitVehicle.AutoSize = true;
            this.lblMatPermitVehicle.Location = new System.Drawing.Point(144, 47);
            this.lblMatPermitVehicle.Name = "lblMatPermitVehicle";
            this.lblMatPermitVehicle.Size = new System.Drawing.Size(51, 20);
            this.lblMatPermitVehicle.TabIndex = 3;
            this.lblMatPermitVehicle.Text = "label4";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaterial,
            this.ColumnMaterialUnit,
            this.ColumnQuantity,
            this.ColumnTonnage});
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Location = new System.Drawing.Point(285, 3);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.materialPermitPanel.SetRowSpan(this.dgvItemList, 3);
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(417, 136);
            this.dgvItemList.TabIndex = 4;
            // 
            // ColumnMaterial
            // 
            this.ColumnMaterial.DataPropertyName = "Material";
            this.ColumnMaterial.FillWeight = 200F;
            this.ColumnMaterial.HeaderText = "Груз";
            this.ColumnMaterial.Name = "ColumnMaterial";
            this.ColumnMaterial.ReadOnly = true;
            // 
            // ColumnMaterialUnit
            // 
            this.ColumnMaterialUnit.DataPropertyName = "MaterialUnit";
            this.ColumnMaterialUnit.FillWeight = 50F;
            this.ColumnMaterialUnit.HeaderText = "ед-ца";
            this.ColumnMaterialUnit.Name = "ColumnMaterialUnit";
            this.ColumnMaterialUnit.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.FillWeight = 50F;
            this.ColumnQuantity.HeaderText = "кол-во";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnTonnage
            // 
            this.ColumnTonnage.DataPropertyName = "Tonnage";
            this.ColumnTonnage.FillWeight = 50F;
            this.ColumnTonnage.HeaderText = "вес (тн)";
            this.ColumnTonnage.Name = "ColumnTonnage";
            this.ColumnTonnage.ReadOnly = true;
            // 
            // labelCannotExit
            // 
            this.labelCannotExit.AutoSize = true;
            this.materialPermitPanel.SetColumnSpan(this.labelCannotExit, 2);
            this.labelCannotExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCannotExit.ForeColor = System.Drawing.Color.Red;
            this.labelCannotExit.Location = new System.Drawing.Point(3, 94);
            this.labelCannotExit.Name = "labelCannotExit";
            this.labelCannotExit.Size = new System.Drawing.Size(276, 48);
            this.labelCannotExit.TabIndex = 5;
            this.labelCannotExit.Text = "Пропуск оформлен не полностью. Выезд невозможен";
            this.labelCannotExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaterialPermit
            // 
            this.lblMaterialPermit.AutoSize = true;
            this.lblMaterialPermit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaterialPermit.Location = new System.Drawing.Point(3, 22);
            this.lblMaterialPermit.Name = "lblMaterialPermit";
            this.lblMaterialPermit.Size = new System.Drawing.Size(51, 20);
            this.lblMaterialPermit.TabIndex = 0;
            this.lblMaterialPermit.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 126);
            this.label1.TabIndex = 7;
            this.label1.Text = "Комментарий";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tboxComment
            // 
            this.tboxComment.BackColor = System.Drawing.SystemColors.Window;
            this.tboxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxComment.Location = new System.Drawing.Point(241, 363);
            this.tboxComment.Multiline = true;
            this.tboxComment.Name = "tboxComment";
            this.tboxComment.ReadOnly = true;
            this.tboxComment.Size = new System.Drawing.Size(473, 120);
            this.tboxComment.TabIndex = 8;
            this.tboxComment.TabStop = false;
            // 
            // lboxPointList
            // 
            this.lboxPointList.DisplayMember = "Point";
            this.lboxPointList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxPointList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lboxPointList.FormattingEnabled = true;
            this.lboxPointList.ItemHeight = 20;
            this.lboxPointList.Location = new System.Drawing.Point(241, 213);
            this.lboxPointList.Name = "lboxPointList";
            this.lboxPointList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboxPointList.Size = new System.Drawing.Size(473, 144);
            this.lboxPointList.TabIndex = 10;
            this.lboxPointList.UseTabStops = false;
            // 
            // PermitItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PermitItemControl";
            this.Size = new System.Drawing.Size(717, 486);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.materialPermitPanel.ResumeLayout(false);
            this.materialPermitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label lblPermitNumber;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDriverContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaterialPermit;
        private System.Windows.Forms.TableLayoutPanel materialPermitPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblMatPermitVehicle;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label labelCannotExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaterialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonnage;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.ListBox lboxPointList;
    }
}
