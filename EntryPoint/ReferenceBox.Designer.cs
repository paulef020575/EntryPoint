namespace EntryPoint
{
    partial class ReferenceBox
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
            this.btnSelectFromList = new System.Windows.Forms.Button();
            this.tboxItem = new System.Windows.Forms.TextBox();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFromList
            // 
            this.btnSelectFromList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectFromList.Location = new System.Drawing.Point(383, 0);
            this.btnSelectFromList.Name = "btnSelectFromList";
            this.btnSelectFromList.Size = new System.Drawing.Size(25, 21);
            this.btnSelectFromList.TabIndex = 0;
            this.btnSelectFromList.TabStop = false;
            this.btnSelectFromList.Text = "...";
            this.btnSelectFromList.UseVisualStyleBackColor = true;
            // 
            // tboxItem
            // 
            this.tboxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxItem.Location = new System.Drawing.Point(0, 0);
            this.tboxItem.Name = "tboxItem";
            this.tboxItem.Size = new System.Drawing.Size(383, 20);
            this.tboxItem.TabIndex = 1;
            this.tboxItem.Validating += new System.ComponentModel.CancelEventHandler(this.tboxItem_Validating);
            // 
            // bsList
            // 
            this.bsList.DataSourceChanged += new System.EventHandler(this.bsList_DataSourceChanged);
            // 
            // ReferenceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxItem);
            this.Controls.Add(this.btnSelectFromList);
            this.Name = "ReferenceBox";
            this.Size = new System.Drawing.Size(408, 21);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFromList;
        private System.Windows.Forms.TextBox tboxItem;
        private System.Windows.Forms.BindingSource bsList;
    }
}
