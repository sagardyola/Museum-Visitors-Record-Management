namespace Museum
{
    partial class Form1
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
            this.lblFName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCardNoExit = new System.Windows.Forms.Button();
            this.txtCardNoExit = new System.Windows.Forms.TextBox();
            this.lblCardNoExit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCardNoValue = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCardNoOld = new System.Windows.Forms.Button();
            this.lblCardNoOld = new System.Windows.Forms.Label();
            this.txtCardNoOld = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTotalVisitors = new System.Windows.Forms.Label();
            this.lblTotalVisitorsNum = new System.Windows.Forms.Label();
            this.lblTotalDuration = new System.Windows.Forms.Label();
            this.lblTotalDurationNum = new System.Windows.Forms.Label();
            this.comboReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.lblChartDuration = new System.Windows.Forms.Label();
            this.lblChartVisitors = new System.Windows.Forms.Label();
            this.chartDuration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVisitors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDailyInfo = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(31, 71);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBrowse);
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Location = new System.Drawing.Point(12, 534);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 69);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Import";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(21, 35);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(140, 20);
            this.txtBrowse.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(167, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Import";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCardNoExit);
            this.groupBox3.Controls.Add(this.txtCardNoExit);
            this.groupBox3.Controls.Add(this.lblCardNoExit);
            this.groupBox3.Location = new System.Drawing.Point(12, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Out Visitor";
            // 
            // btnCardNoExit
            // 
            this.btnCardNoExit.Location = new System.Drawing.Point(142, 57);
            this.btnCardNoExit.Name = "btnCardNoExit";
            this.btnCardNoExit.Size = new System.Drawing.Size(75, 23);
            this.btnCardNoExit.TabIndex = 3;
            this.btnCardNoExit.Text = "Check Out";
            this.btnCardNoExit.UseVisualStyleBackColor = true;
            this.btnCardNoExit.Click += new System.EventHandler(this.btnCardNoExit_Click);
            // 
            // txtCardNoExit
            // 
            this.txtCardNoExit.Location = new System.Drawing.Point(142, 27);
            this.txtCardNoExit.Name = "txtCardNoExit";
            this.txtCardNoExit.Size = new System.Drawing.Size(100, 20);
            this.txtCardNoExit.TabIndex = 2;
            // 
            // lblCardNoExit
            // 
            this.lblCardNoExit.AutoSize = true;
            this.lblCardNoExit.Location = new System.Drawing.Point(31, 34);
            this.lblCardNoExit.Name = "lblCardNoExit";
            this.lblCardNoExit.Size = new System.Drawing.Size(69, 13);
            this.lblCardNoExit.TabIndex = 1;
            this.lblCardNoExit.Text = "Card Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCardNoValue);
            this.groupBox2.Controls.Add(this.lblCardNo);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.lblFName);
            this.groupBox2.Controls.Add(this.lblLName);
            this.groupBox2.Controls.Add(this.lblContact);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.txtOccupation);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.lblOccupation);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 279);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check In Visitor";
            // 
            // lblCardNoValue
            // 
            this.lblCardNoValue.AutoSize = true;
            this.lblCardNoValue.Location = new System.Drawing.Point(139, 35);
            this.lblCardNoValue.Name = "lblCardNoValue";
            this.lblCardNoValue.Size = new System.Drawing.Size(0, 13);
            this.lblCardNoValue.TabIndex = 16;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(31, 35);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(69, 13);
            this.lblCardNo.TabIndex = 15;
            this.lblCardNo.Text = "Card Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(142, 163);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 9;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(31, 105);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(31, 170);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(84, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact Number";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(167, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(142, 199);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(100, 20);
            this.txtOccupation.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(75, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Check In";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email address";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(142, 64);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 6;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(31, 206);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 5;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(142, 98);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCardNoOld);
            this.groupBox1.Controls.Add(this.lblCardNoOld);
            this.groupBox1.Controls.Add(this.txtCardNoOld);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Visitor";
            // 
            // btnCardNoOld
            // 
            this.btnCardNoOld.Location = new System.Drawing.Point(142, 57);
            this.btnCardNoOld.Name = "btnCardNoOld";
            this.btnCardNoOld.Size = new System.Drawing.Size(75, 23);
            this.btnCardNoOld.TabIndex = 14;
            this.btnCardNoOld.Text = "Go";
            this.btnCardNoOld.UseVisualStyleBackColor = true;
            this.btnCardNoOld.Click += new System.EventHandler(this.btnCardNoOld_Click);
            // 
            // lblCardNoOld
            // 
            this.lblCardNoOld.AutoSize = true;
            this.lblCardNoOld.Location = new System.Drawing.Point(31, 28);
            this.lblCardNoOld.Name = "lblCardNoOld";
            this.lblCardNoOld.Size = new System.Drawing.Size(69, 13);
            this.lblCardNoOld.TabIndex = 12;
            this.lblCardNoOld.Text = "Card Number";
            // 
            // txtCardNoOld
            // 
            this.txtCardNoOld.Location = new System.Drawing.Point(142, 25);
            this.txtCardNoOld.Name = "txtCardNoOld";
            this.txtCardNoOld.Size = new System.Drawing.Size(100, 20);
            this.txtCardNoOld.TabIndex = 13;
            this.txtCardNoOld.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 30, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTotalVisitors
            // 
            this.lblTotalVisitors.AutoSize = true;
            this.lblTotalVisitors.Location = new System.Drawing.Point(1082, 36);
            this.lblTotalVisitors.Name = "lblTotalVisitors";
            this.lblTotalVisitors.Size = new System.Drawing.Size(70, 13);
            this.lblTotalVisitors.TabIndex = 21;
            this.lblTotalVisitors.Text = "Total Visitors:";
            this.lblTotalVisitors.Visible = false;
            // 
            // lblTotalVisitorsNum
            // 
            this.lblTotalVisitorsNum.AutoSize = true;
            this.lblTotalVisitorsNum.Location = new System.Drawing.Point(1189, 39);
            this.lblTotalVisitorsNum.Name = "lblTotalVisitorsNum";
            this.lblTotalVisitorsNum.Size = new System.Drawing.Size(0, 13);
            this.lblTotalVisitorsNum.TabIndex = 22;
            this.lblTotalVisitorsNum.Visible = false;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.Location = new System.Drawing.Point(1082, 58);
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(74, 13);
            this.lblTotalDuration.TabIndex = 23;
            this.lblTotalDuration.Text = "Total Duration";
            this.lblTotalDuration.Visible = false;
            // 
            // lblTotalDurationNum
            // 
            this.lblTotalDurationNum.AutoSize = true;
            this.lblTotalDurationNum.Location = new System.Drawing.Point(1189, 58);
            this.lblTotalDurationNum.Name = "lblTotalDurationNum";
            this.lblTotalDurationNum.Size = new System.Drawing.Size(0, 13);
            this.lblTotalDurationNum.TabIndex = 24;
            this.lblTotalDurationNum.Visible = false;
            // 
            // comboReportType
            // 
            this.comboReportType.FormattingEnabled = true;
            this.comboReportType.Items.AddRange(new object[] {
            "Daily",
            "Weekly"});
            this.comboReportType.Location = new System.Drawing.Point(421, 28);
            this.comboReportType.Name = "comboReportType";
            this.comboReportType.Size = new System.Drawing.Size(188, 21);
            this.comboReportType.TabIndex = 25;
            this.comboReportType.SelectedIndexChanged += new System.EventHandler(this.comboReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(304, 36);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(99, 13);
            this.lblReportType.TabIndex = 26;
            this.lblReportType.Text = "Select Report Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Location = new System.Drawing.Point(300, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 512);
            this.tabControl1.TabIndex = 33;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.dataGridView1);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(956, 486);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.lblDailyInfo);
            this.tabGraph.Controls.Add(this.lblChartDuration);
            this.tabGraph.Controls.Add(this.lblChartVisitors);
            this.tabGraph.Controls.Add(this.chartDuration);
            this.tabGraph.Controls.Add(this.chartVisitors);
            this.tabGraph.Location = new System.Drawing.Point(4, 22);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(956, 486);
            this.tabGraph.TabIndex = 1;
            this.tabGraph.Text = "Graph";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // lblChartDuration
            // 
            this.lblChartDuration.AutoSize = true;
            this.lblChartDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartDuration.Location = new System.Drawing.Point(615, 422);
            this.lblChartDuration.Name = "lblChartDuration";
            this.lblChartDuration.Size = new System.Drawing.Size(93, 25);
            this.lblChartDuration.TabIndex = 38;
            this.lblChartDuration.Text = "Duration";
            this.lblChartDuration.Visible = false;
            // 
            // lblChartVisitors
            // 
            this.lblChartVisitors.AutoSize = true;
            this.lblChartVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartVisitors.Location = new System.Drawing.Point(152, 422);
            this.lblChartVisitors.Name = "lblChartVisitors";
            this.lblChartVisitors.Size = new System.Drawing.Size(83, 25);
            this.lblChartVisitors.TabIndex = 37;
            this.lblChartVisitors.Text = "Visitors";
            this.lblChartVisitors.Visible = false;
            // 
            // chartDuration
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDuration.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDuration.Legends.Add(legend1);
            this.chartDuration.Location = new System.Drawing.Point(482, 20);
            this.chartDuration.Name = "chartDuration";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDuration.Series.Add(series1);
            this.chartDuration.Size = new System.Drawing.Size(444, 384);
            this.chartDuration.TabIndex = 35;
            this.chartDuration.Text = "Duration";
            this.chartDuration.Visible = false;
            // 
            // chartVisitors
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVisitors.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVisitors.Legends.Add(legend2);
            this.chartVisitors.Location = new System.Drawing.Point(22, 20);
            this.chartVisitors.Name = "chartVisitors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVisitors.Series.Add(series2);
            this.chartVisitors.Size = new System.Drawing.Size(444, 384);
            this.chartVisitors.TabIndex = 36;
            this.chartVisitors.Text = "Visitors";
            this.chartVisitors.Visible = false;
            // 
            // lblDailyInfo
            // 
            this.lblDailyInfo.AutoSize = true;
            this.lblDailyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyInfo.Location = new System.Drawing.Point(17, 20);
            this.lblDailyInfo.Name = "lblDailyInfo";
            this.lblDailyInfo.Size = new System.Drawing.Size(409, 25);
            this.lblDailyInfo.TabIndex = 39;
            this.lblDailyInfo.Text = "Graph is only available for Weekly Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.comboReportType);
            this.Controls.Add(this.lblTotalDurationNum);
            this.Controls.Add(this.lblTotalDuration);
            this.Controls.Add(this.lblTotalVisitorsNum);
            this.Controls.Add(this.lblTotalVisitors);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museum Visitor\'s Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.tabGraph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtCardNoOld;
        private System.Windows.Forms.Label lblCardNoOld;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCardNoExit;
        private System.Windows.Forms.TextBox txtCardNoExit;
        private System.Windows.Forms.Label lblCardNoExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCardNoOld;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblTotalVisitors;
        private System.Windows.Forms.Label lblTotalVisitorsNum;
        private System.Windows.Forms.Label lblTotalDuration;
        private System.Windows.Forms.Label lblTotalDurationNum;
        private System.Windows.Forms.ComboBox comboReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblCardNoValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDuration;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisitors;
        private System.Windows.Forms.Label lblChartDuration;
        private System.Windows.Forms.Label lblChartVisitors;
        private System.Windows.Forms.Label lblDailyInfo;
    }
}

