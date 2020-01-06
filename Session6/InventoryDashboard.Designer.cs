﻿namespace Session6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spendList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mostUsedList = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.costlyAssetList = new System.Windows.Forms.DataGridView();
            this.inventCBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.languageBoc = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostUsedList)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costlyAssetList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spendList);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1001, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EM Spending by Department";
            // 
            // spendList
            // 
            this.spendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendList.Location = new System.Drawing.Point(4, 19);
            this.spendList.Margin = new System.Windows.Forms.Padding(4);
            this.spendList.Name = "spendList";
            this.spendList.RowHeadersWidth = 51;
            this.spendList.Size = new System.Drawing.Size(993, 152);
            this.spendList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pieChart);
            this.groupBox2.Location = new System.Drawing.Point(1025, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(581, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Spending Ratio";
            // 
            // pieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea3);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.pieChart.Legends.Add(legend3);
            this.pieChart.Location = new System.Drawing.Point(4, 19);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart.Name = "pieChart";
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(573, 281);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.barChart);
            this.groupBox3.Location = new System.Drawing.Point(1025, 326);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(870, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Department Spending";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // barChart
            // 
            chartArea4.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea4);
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.barChart.Legends.Add(legend4);
            this.barChart.Location = new System.Drawing.Point(4, 19);
            this.barChart.Margin = new System.Windows.Forms.Padding(4);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(862, 261);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mostUsedList);
            this.groupBox4.Location = new System.Drawing.Point(16, 197);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1001, 175);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monthy Report for Most-Used Parts";
            // 
            // mostUsedList
            // 
            this.mostUsedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostUsedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostUsedList.Location = new System.Drawing.Point(4, 19);
            this.mostUsedList.Margin = new System.Windows.Forms.Padding(4);
            this.mostUsedList.Name = "mostUsedList";
            this.mostUsedList.RowHeadersWidth = 51;
            this.mostUsedList.Size = new System.Drawing.Size(993, 152);
            this.mostUsedList.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.costlyAssetList);
            this.groupBox5.Location = new System.Drawing.Point(16, 379);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1001, 175);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthy Report of Costly Assets";
            // 
            // costlyAssetList
            // 
            this.costlyAssetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costlyAssetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costlyAssetList.Location = new System.Drawing.Point(4, 19);
            this.costlyAssetList.Margin = new System.Windows.Forms.Padding(4);
            this.costlyAssetList.Name = "costlyAssetList";
            this.costlyAssetList.RowHeadersWidth = 51;
            this.costlyAssetList.Size = new System.Drawing.Size(993, 152);
            this.costlyAssetList.TabIndex = 0;
            // 
            // inventCBtn
            // 
            this.inventCBtn.Location = new System.Drawing.Point(16, 577);
            this.inventCBtn.Margin = new System.Windows.Forms.Padding(4);
            this.inventCBtn.Name = "inventCBtn";
            this.inventCBtn.Size = new System.Drawing.Size(201, 28);
            this.inventCBtn.TabIndex = 5;
            this.inventCBtn.Text = "Inventory Control";
            this.inventCBtn.UseVisualStyleBackColor = true;
            this.inventCBtn.Click += new System.EventHandler(this.inventCBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(748, 577);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 28);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // languageBoc
            // 
            this.languageBoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBoc.FormattingEnabled = true;
            this.languageBoc.Location = new System.Drawing.Point(856, 580);
            this.languageBoc.Margin = new System.Windows.Forms.Padding(4);
            this.languageBoc.Name = "languageBoc";
            this.languageBoc.Size = new System.Drawing.Size(160, 24);
            this.languageBoc.TabIndex = 7;
            this.languageBoc.SelectedIndexChanged += new System.EventHandler(this.languageBoc_SelectedIndexChanged);
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 625);
            this.Controls.Add(this.languageBoc);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.inventCBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryDashboard";
            this.Text = "Inventory Dashboard";
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spendList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mostUsedList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costlyAssetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

