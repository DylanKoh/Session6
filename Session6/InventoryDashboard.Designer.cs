namespace Session6
{
    partial class InventoryDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.inventCBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.languageBoc = new System.Windows.Forms.ComboBox();
            this.spendList = new System.Windows.Forms.DataGridView();
            this.mostUsedList = new System.Windows.Forms.DataGridView();
            this.costlyAssetList = new System.Windows.Forms.DataGridView();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostUsedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costlyAssetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spendList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EM Spending by Department";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pieChart);
            this.groupBox2.Location = new System.Drawing.Point(769, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Spending Ratio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.barChart);
            this.groupBox3.Location = new System.Drawing.Point(769, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Department Spending";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mostUsedList);
            this.groupBox4.Location = new System.Drawing.Point(12, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(751, 142);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monthy Report for Most-Used Parts";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.costlyAssetList);
            this.groupBox5.Location = new System.Drawing.Point(12, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(751, 142);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthy Report of Costly Assets";
            // 
            // inventCBtn
            // 
            this.inventCBtn.Location = new System.Drawing.Point(12, 469);
            this.inventCBtn.Name = "inventCBtn";
            this.inventCBtn.Size = new System.Drawing.Size(151, 23);
            this.inventCBtn.TabIndex = 5;
            this.inventCBtn.Text = "Inventory Control";
            this.inventCBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(561, 469);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // languageBoc
            // 
            this.languageBoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBoc.FormattingEnabled = true;
            this.languageBoc.Location = new System.Drawing.Point(642, 471);
            this.languageBoc.Name = "languageBoc";
            this.languageBoc.Size = new System.Drawing.Size(121, 21);
            this.languageBoc.TabIndex = 7;
            // 
            // spendList
            // 
            this.spendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendList.Location = new System.Drawing.Point(3, 16);
            this.spendList.Name = "spendList";
            this.spendList.Size = new System.Drawing.Size(745, 123);
            this.spendList.TabIndex = 0;
            // 
            // mostUsedList
            // 
            this.mostUsedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostUsedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostUsedList.Location = new System.Drawing.Point(3, 16);
            this.mostUsedList.Name = "mostUsedList";
            this.mostUsedList.Size = new System.Drawing.Size(745, 123);
            this.mostUsedList.TabIndex = 0;
            // 
            // costlyAssetList
            // 
            this.costlyAssetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costlyAssetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costlyAssetList.Location = new System.Drawing.Point(3, 16);
            this.costlyAssetList.Name = "costlyAssetList";
            this.costlyAssetList.Size = new System.Drawing.Size(745, 123);
            this.costlyAssetList.TabIndex = 0;
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(3, 16);
            this.pieChart.Name = "pieChart";
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(430, 228);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart1";
            // 
            // barChart
            // 
            chartArea2.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea2);
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.barChart.Legends.Add(legend2);
            this.barChart.Location = new System.Drawing.Point(3, 16);
            this.barChart.Name = "barChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.barChart.Series.Add(series2);
            this.barChart.Size = new System.Drawing.Size(430, 212);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "chart1";
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 508);
            this.Controls.Add(this.languageBoc);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.inventCBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryDashboard";
            this.Text = "Inventory Dashboard";
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spendList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostUsedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costlyAssetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button inventCBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox languageBoc;
        private System.Windows.Forms.DataGridView spendList;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataGridView mostUsedList;
        private System.Windows.Forms.DataGridView costlyAssetList;
    }
}

