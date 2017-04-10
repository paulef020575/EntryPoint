namespace EntryPoint
{
    partial class InitializeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboxServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.lblEntryPoint = new System.Windows.Forms.Label();
            this.cboxEntryPoint = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // cboxServer
            // 
            this.cboxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxServer.FormattingEnabled = true;
            this.cboxServer.Location = new System.Drawing.Point(107, 12);
            this.cboxServer.Name = "cboxServer";
            this.cboxServer.Size = new System.Drawing.Size(341, 21);
            this.cboxServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "База данных";
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(107, 39);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(341, 20);
            this.tboxPath.TabIndex = 3;
            // 
            // lblEntryPoint
            // 
            this.lblEntryPoint.AutoSize = true;
            this.lblEntryPoint.Location = new System.Drawing.Point(29, 79);
            this.lblEntryPoint.Name = "lblEntryPoint";
            this.lblEntryPoint.Size = new System.Drawing.Size(62, 13);
            this.lblEntryPoint.TabIndex = 4;
            this.lblEntryPoint.Text = "Проходная";
            // 
            // cboxEntryPoint
            // 
            this.cboxEntryPoint.FormattingEnabled = true;
            this.cboxEntryPoint.Location = new System.Drawing.Point(107, 76);
            this.cboxEntryPoint.Name = "cboxEntryPoint";
            this.cboxEntryPoint.Size = new System.Drawing.Size(341, 21);
            this.cboxEntryPoint.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.LightGreen;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.Color.Green;
            this.buttonOK.Location = new System.Drawing.Point(10, 10);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(242, 80);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCancel.Location = new System.Drawing.Point(255, 13);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(236, 74);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "ОТМЕНА";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // InitializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cboxEntryPoint);
            this.Controls.Add(this.lblEntryPoint);
            this.Controls.Add(this.tboxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxServer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InitializeForm";
            this.Text = "Свойства подключения";
            this.Load += new System.EventHandler(this.InitializeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.Label lblEntryPoint;
        private System.Windows.Forms.ComboBox cboxEntryPoint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

    }
}