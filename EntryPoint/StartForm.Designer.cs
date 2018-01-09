namespace EntryPoint
{
    partial class StartForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbutTruck = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbutPermit = new System.Windows.Forms.RadioButton();
            this.pnlKeyboard = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlKeyboard.SuspendLayout();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxNumber);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.rbutTruck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rbutPermit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(996, 120);
            this.panel1.TabIndex = 1;
            // 
            // tboxNumber
            // 
            this.tboxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxNumber.Location = new System.Drawing.Point(230, 10);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(756, 104);
            this.tboxNumber.TabIndex = 4;
            this.tboxNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(220, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 100);
            this.panel3.TabIndex = 6;
            // 
            // rbutTruck
            // 
            this.rbutTruck.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbutTruck.BackgroundImage = global::EntryPoint.Properties.Resources.truck_red;
            this.rbutTruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbutTruck.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbutTruck.Location = new System.Drawing.Point(120, 10);
            this.rbutTruck.Name = "rbutTruck";
            this.rbutTruck.Size = new System.Drawing.Size(100, 100);
            this.rbutTruck.TabIndex = 2;
            this.rbutTruck.TabStop = true;
            this.rbutTruck.UseVisualStyleBackColor = true;
            this.rbutTruck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(110, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 100);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // rbutPermit
            // 
            this.rbutPermit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbutPermit.BackgroundImage = global::EntryPoint.Properties.Resources.document;
            this.rbutPermit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbutPermit.Checked = true;
            this.rbutPermit.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbutPermit.Location = new System.Drawing.Point(10, 10);
            this.rbutPermit.Name = "rbutPermit";
            this.rbutPermit.Size = new System.Drawing.Size(100, 100);
            this.rbutPermit.TabIndex = 1;
            this.rbutPermit.TabStop = true;
            this.rbutPermit.UseVisualStyleBackColor = true;
            this.rbutPermit.Visible = false;
            this.rbutPermit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            // 
            // pnlKeyboard
            // 
            this.pnlKeyboard.Controls.Add(this.button1);
            this.pnlKeyboard.Controls.Add(this.button2);
            this.pnlKeyboard.Controls.Add(this.button3);
            this.pnlKeyboard.Controls.Add(this.button4);
            this.pnlKeyboard.Controls.Add(this.button5);
            this.pnlKeyboard.Controls.Add(this.button6);
            this.pnlKeyboard.Controls.Add(this.button7);
            this.pnlKeyboard.Controls.Add(this.button8);
            this.pnlKeyboard.Controls.Add(this.button9);
            this.pnlKeyboard.Controls.Add(this.button10);
            this.pnlKeyboard.Controls.Add(this.button11);
            this.pnlKeyboard.Controls.Add(this.btnClear);
            this.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKeyboard.Location = new System.Drawing.Point(0, 220);
            this.pnlKeyboard.Name = "pnlKeyboard";
            this.pnlKeyboard.Size = new System.Drawing.Size(336, 476);
            this.pnlKeyboard.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Tag = "7";
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(115, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Tag = "8";
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(225, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Tag = "9";
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(5, 115);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(115, 115);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(225, 115);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(5, 225);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 7;
            this.button7.TabStop = false;
            this.button7.Tag = "1";
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(115, 225);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 8;
            this.button8.TabStop = false;
            this.button8.Tag = "2";
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(225, 225);
            this.button9.Margin = new System.Windows.Forms.Padding(5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 9;
            this.button9.TabStop = false;
            this.button9.Tag = "3";
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(5, 335);
            this.button10.Margin = new System.Windows.Forms.Padding(5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 10;
            this.button10.TabStop = false;
            this.button10.Tag = "0";
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Image = global::EntryPoint.Properties.Resources.arrow_left_blue;
            this.button11.Location = new System.Drawing.Point(115, 335);
            this.button11.Margin = new System.Windows.Forms.Padding(5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 11;
            this.button11.TabStop = false;
            this.button11.Tag = "back";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.keyboardKeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Image = global::EntryPoint.Properties.Resources.arrow_left_blue;
            this.btnClear.Location = new System.Drawing.Point(225, 335);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 100);
            this.btnClear.TabIndex = 12;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "back";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::EntryPoint.Properties.Resources.WoodTrack;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Dock = System.Windows.Forms.DockStyle.Left;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(10, 10);
            this.button12.Margin = new System.Windows.Forms.Padding(10);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(232, 80);
            this.button12.TabIndex = 12;
            this.button12.TabStop = false;
            this.button12.Tag = "truck";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(336, 220);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(660, 476);
            this.resultPanel.TabIndex = 3;
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.btnFind);
            this.panelFind.Controls.Add(this.panel4);
            this.panelFind.Controls.Add(this.button12);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFind.Location = new System.Drawing.Point(0, 120);
            this.panelFind.Name = "panelFind";
            this.panelFind.Padding = new System.Windows.Forms.Padding(10);
            this.panelFind.Size = new System.Drawing.Size(996, 100);
            this.panelFind.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Image = global::EntryPoint.Properties.Resources.find;
            this.btnFind.Location = new System.Drawing.Point(262, 10);
            this.btnFind.Margin = new System.Windows.Forms.Padding(10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(724, 80);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "ПОИСК";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(242, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 80);
            this.panel4.TabIndex = 13;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 696);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.pnlKeyboard);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.panel1);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKeyboard.ResumeLayout(false);
            this.panelFind.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbutPermit;
        private System.Windows.Forms.RadioButton rbutTruck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.FlowLayoutPanel pnlKeyboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClear;
    }
}

