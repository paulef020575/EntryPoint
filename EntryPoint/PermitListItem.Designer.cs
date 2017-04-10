namespace EntryPoint
{
    partial class PermitListItem
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblPermitNumber = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Image = global::EntryPoint.Properties.Resources.check2;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVehicle.Location = new System.Drawing.Point(64, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(228, 55);
            this.lblVehicle.TabIndex = 1;
            this.lblVehicle.Text = "lblVehicle";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblPeriod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPermitNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDriver, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(292, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 64);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeriod.Location = new System.Drawing.Point(185, 32);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(177, 32);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "ActivePeriof";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCargo.Location = new System.Drawing.Point(3, 32);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(176, 32);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Груз";
            // 
            // lblPermitNumber
            // 
            this.lblPermitNumber.AutoSize = true;
            this.lblPermitNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPermitNumber.Location = new System.Drawing.Point(185, 0);
            this.lblPermitNumber.Name = "lblPermitNumber";
            this.lblPermitNumber.Size = new System.Drawing.Size(177, 32);
            this.lblPermitNumber.TabIndex = 1;
            this.lblPermitNumber.Text = "lblPermitNumber";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDriver.Location = new System.Drawing.Point(3, 0);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(176, 32);
            this.lblDriver.TabIndex = 0;
            this.lblDriver.Text = "lblDriver";
            // 
            // PermitListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.button1);
            this.Name = "PermitListItem";
            this.Size = new System.Drawing.Size(657, 64);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblPermitNumber;
        private System.Windows.Forms.Label lblDriver;
    }
}
