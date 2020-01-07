namespace Session6
{
    partial class InventoryControl
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
            this.assetBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allocateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.aMethodBox = new System.Windows.Forms.ComboBox();
            this.amtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.warehouseBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allocatedList = new System.Windows.Forms.DataGridView();
            this.assignBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.assignedList = new System.Windows.Forms.DataGridView();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allocatedList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Name (EM Number): ";
            // 
            // assetBox
            // 
            this.assetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assetBox.FormattingEnabled = true;
            this.assetBox.Location = new System.Drawing.Point(204, 7);
            this.assetBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assetBox.Name = "assetBox";
            this.assetBox.Size = new System.Drawing.Size(543, 24);
            this.assetBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date: ";
            // 
            // dateBox
            // 
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBox.Location = new System.Drawing.Point(952, 9);
            this.dateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(323, 22);
            this.dateBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allocateBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.aMethodBox);
            this.groupBox1.Controls.Add(this.amtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.partBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.warehouseBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1256, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for parts:";
            // 
            // allocateBtn
            // 
            this.allocateBtn.Location = new System.Drawing.Point(1148, 75);
            this.allocateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allocateBtn.Name = "allocateBtn";
            this.allocateBtn.Size = new System.Drawing.Size(100, 28);
            this.allocateBtn.TabIndex = 8;
            this.allocateBtn.Text = "Allocate";
            this.allocateBtn.UseVisualStyleBackColor = true;
            this.allocateBtn.Click += new System.EventHandler(this.allocateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Allocation Method: ";
            // 
            // aMethodBox
            // 
            this.aMethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aMethodBox.FormattingEnabled = true;
            this.aMethodBox.Location = new System.Drawing.Point(912, 78);
            this.aMethodBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aMethodBox.Name = "aMethodBox";
            this.aMethodBox.Size = new System.Drawing.Size(160, 24);
            this.aMethodBox.TabIndex = 6;
            // 
            // amtBox
            // 
            this.amtBox.Location = new System.Drawing.Point(615, 78);
            this.amtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amtBox.Name = "amtBox";
            this.amtBox.Size = new System.Drawing.Size(112, 22);
            this.amtBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount: ";
            // 
            // partBox
            // 
            this.partBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partBox.FormattingEnabled = true;
            this.partBox.Location = new System.Drawing.Point(100, 78);
            this.partBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(383, 24);
            this.partBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Part Name: ";
            // 
            // warehouseBox
            // 
            this.warehouseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warehouseBox.FormattingEnabled = true;
            this.warehouseBox.Location = new System.Drawing.Point(107, 28);
            this.warehouseBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warehouseBox.Name = "warehouseBox";
            this.warehouseBox.Size = new System.Drawing.Size(383, 24);
            this.warehouseBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Warehouse: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.allocatedList);
            this.groupBox2.Controls.Add(this.assignBtn);
            this.groupBox2.Location = new System.Drawing.Point(20, 171);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1256, 185);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allocated Parts";
            // 
            // allocatedList
            // 
            this.allocatedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allocatedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allocatedList.Location = new System.Drawing.Point(4, 19);
            this.allocatedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allocatedList.Name = "allocatedList";
            this.allocatedList.RowHeadersWidth = 51;
            this.allocatedList.Size = new System.Drawing.Size(928, 162);
            this.allocatedList.TabIndex = 0;
            // 
            // assignBtn
            // 
            this.assignBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.assignBtn.Location = new System.Drawing.Point(932, 19);
            this.assignBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(320, 162);
            this.assignBtn.TabIndex = 1;
            this.assignBtn.Text = "+ Assign to EM";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.assignedList);
            this.groupBox3.Location = new System.Drawing.Point(20, 363);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1256, 247);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assigned Parts";
            // 
            // assignedList
            // 
            this.assignedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignedList.Location = new System.Drawing.Point(4, 19);
            this.assignedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignedList.Name = "assignedList";
            this.assignedList.RowHeadersWidth = 51;
            this.assignedList.Size = new System.Drawing.Size(1248, 224);
            this.assignedList.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(464, 636);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 28);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(735, 636);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 679);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assetBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryControl";
            this.Text = "Inventory Control";
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allocatedList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox assetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox partBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox warehouseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button allocateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox aMethodBox;
        private System.Windows.Forms.TextBox amtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView allocatedList;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView assignedList;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}