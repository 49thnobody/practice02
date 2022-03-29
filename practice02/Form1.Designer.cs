namespace practice02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea39 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTemperature = new System.Windows.Forms.TabPage();
            this.tabPagePressure = new System.Windows.Forms.TabPage();
            this.tabPageHumidity = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMinTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxTemperature = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateTemperature = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAddTemperature = new System.Windows.Forms.TextBox();
            this.buttonAddTemperature = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxTemperature = new System.Windows.Forms.ListBox();
            this.buttonResetTemperature = new System.Windows.Forms.Button();
            this.buttonDeleteTemperature = new System.Windows.Forms.Button();
            this.buttonDeletePressure = new System.Windows.Forms.Button();
            this.buttonResetPressure = new System.Windows.Forms.Button();
            this.listBoxPressure = new System.Windows.Forms.ListBox();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAddPressure = new System.Windows.Forms.Button();
            this.textBoxAddPressure = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGeneratePressure = new System.Windows.Forms.Button();
            this.numericUpDownMaxPressure = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinPressure = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteHumidity = new System.Windows.Forms.Button();
            this.buttonResetHumidity = new System.Windows.Forms.Button();
            this.listBoxHumidity = new System.Windows.Forms.ListBox();
            this.chartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAddHumidity = new System.Windows.Forms.Button();
            this.textBoxAddHumidity = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonGenerateHumidity = new System.Windows.Forms.Button();
            this.numericUpDownMaxHumidity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinHumidity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageTemperature.SuspendLayout();
            this.tabPagePressure.SuspendLayout();
            this.tabPageHumidity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTemperature)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTemperature);
            this.tabControl1.Controls.Add(this.tabPagePressure);
            this.tabControl1.Controls.Add(this.tabPageHumidity);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageTemperature
            // 
            this.tabPageTemperature.Controls.Add(this.buttonDeleteTemperature);
            this.tabPageTemperature.Controls.Add(this.buttonResetTemperature);
            this.tabPageTemperature.Controls.Add(this.listBoxTemperature);
            this.tabPageTemperature.Controls.Add(this.chartTemperature);
            this.tabPageTemperature.Controls.Add(this.groupBox2);
            this.tabPageTemperature.Controls.Add(this.groupBox1);
            this.tabPageTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemperature.Name = "tabPageTemperature";
            this.tabPageTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemperature.Size = new System.Drawing.Size(777, 452);
            this.tabPageTemperature.TabIndex = 0;
            this.tabPageTemperature.Text = "Температура";
            this.tabPageTemperature.UseVisualStyleBackColor = true;
            // 
            // tabPagePressure
            // 
            this.tabPagePressure.Controls.Add(this.buttonDeletePressure);
            this.tabPagePressure.Controls.Add(this.buttonResetPressure);
            this.tabPagePressure.Controls.Add(this.listBoxPressure);
            this.tabPagePressure.Controls.Add(this.chartPressure);
            this.tabPagePressure.Controls.Add(this.groupBox3);
            this.tabPagePressure.Controls.Add(this.groupBox4);
            this.tabPagePressure.Location = new System.Drawing.Point(4, 22);
            this.tabPagePressure.Name = "tabPagePressure";
            this.tabPagePressure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePressure.Size = new System.Drawing.Size(777, 452);
            this.tabPagePressure.TabIndex = 1;
            this.tabPagePressure.Text = "Давление";
            this.tabPagePressure.UseVisualStyleBackColor = true;
            // 
            // tabPageHumidity
            // 
            this.tabPageHumidity.Controls.Add(this.buttonDeleteHumidity);
            this.tabPageHumidity.Controls.Add(this.buttonResetHumidity);
            this.tabPageHumidity.Controls.Add(this.listBoxHumidity);
            this.tabPageHumidity.Controls.Add(this.chartHumidity);
            this.tabPageHumidity.Controls.Add(this.groupBox5);
            this.tabPageHumidity.Controls.Add(this.groupBox6);
            this.tabPageHumidity.Location = new System.Drawing.Point(4, 22);
            this.tabPageHumidity.Name = "tabPageHumidity";
            this.tabPageHumidity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHumidity.Size = new System.Drawing.Size(777, 452);
            this.tabPageHumidity.TabIndex = 2;
            this.tabPageHumidity.Text = "Влажность";
            this.tabPageHumidity.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenerateTemperature);
            this.groupBox1.Controls.Add(this.numericUpDownMaxTemperature);
            this.groupBox1.Controls.Add(this.numericUpDownMinTemperature);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(554, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мин.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мах.";
            // 
            // numericUpDownMinTemperature
            // 
            this.numericUpDownMinTemperature.Location = new System.Drawing.Point(40, 18);
            this.numericUpDownMinTemperature.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.numericUpDownMinTemperature.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownMinTemperature.Name = "numericUpDownMinTemperature";
            this.numericUpDownMinTemperature.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMinTemperature.TabIndex = 2;
            this.numericUpDownMinTemperature.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownMaxTemperature
            // 
            this.numericUpDownMaxTemperature.Location = new System.Drawing.Point(40, 41);
            this.numericUpDownMaxTemperature.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMaxTemperature.Minimum = new decimal(new int[] {
            29,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxTemperature.Name = "numericUpDownMaxTemperature";
            this.numericUpDownMaxTemperature.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMaxTemperature.TabIndex = 3;
            this.numericUpDownMaxTemperature.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonGenerateTemperature
            // 
            this.buttonGenerateTemperature.Location = new System.Drawing.Point(102, 18);
            this.buttonGenerateTemperature.Name = "buttonGenerateTemperature";
            this.buttonGenerateTemperature.Size = new System.Drawing.Size(109, 43);
            this.buttonGenerateTemperature.TabIndex = 4;
            this.buttonGenerateTemperature.Text = "Сгенерировать";
            this.buttonGenerateTemperature.UseVisualStyleBackColor = true;
            this.buttonGenerateTemperature.Click += new System.EventHandler(this.buttonGenerateTemperature_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddTemperature);
            this.groupBox2.Controls.Add(this.textBoxAddTemperature);
            this.groupBox2.Location = new System.Drawing.Point(554, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить значение";
            // 
            // textBoxAddTemperature
            // 
            this.textBoxAddTemperature.Location = new System.Drawing.Point(6, 20);
            this.textBoxAddTemperature.Name = "textBoxAddTemperature";
            this.textBoxAddTemperature.Size = new System.Drawing.Size(90, 20);
            this.textBoxAddTemperature.TabIndex = 0;
            // 
            // buttonAddTemperature
            // 
            this.buttonAddTemperature.Location = new System.Drawing.Point(102, 19);
            this.buttonAddTemperature.Name = "buttonAddTemperature";
            this.buttonAddTemperature.Size = new System.Drawing.Size(109, 23);
            this.buttonAddTemperature.TabIndex = 1;
            this.buttonAddTemperature.Text = "Добавить";
            this.buttonAddTemperature.UseVisualStyleBackColor = true;
            this.buttonAddTemperature.Click += new System.EventHandler(this.buttonAddTemperature_Click);
            // 
            // chartTemperature
            // 
            chartArea38.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea38);
            this.chartTemperature.Location = new System.Drawing.Point(7, 7);
            this.chartTemperature.Name = "chartTemperature";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Name = "Series1";
            this.chartTemperature.Series.Add(series38);
            this.chartTemperature.Size = new System.Drawing.Size(541, 439);
            this.chartTemperature.TabIndex = 2;
            // 
            // listBoxTemperature
            // 
            this.listBoxTemperature.FormattingEnabled = true;
            this.listBoxTemperature.Location = new System.Drawing.Point(554, 133);
            this.listBoxTemperature.Name = "listBoxTemperature";
            this.listBoxTemperature.Size = new System.Drawing.Size(217, 277);
            this.listBoxTemperature.TabIndex = 3;
            // 
            // buttonResetTemperature
            // 
            this.buttonResetTemperature.Location = new System.Drawing.Point(662, 416);
            this.buttonResetTemperature.Name = "buttonResetTemperature";
            this.buttonResetTemperature.Size = new System.Drawing.Size(109, 23);
            this.buttonResetTemperature.TabIndex = 4;
            this.buttonResetTemperature.Text = "Сбросить";
            this.buttonResetTemperature.UseVisualStyleBackColor = true;
            this.buttonResetTemperature.Click += new System.EventHandler(this.buttonResetTemperature_Click);
            // 
            // buttonDeleteTemperature
            // 
            this.buttonDeleteTemperature.Location = new System.Drawing.Point(554, 416);
            this.buttonDeleteTemperature.Name = "buttonDeleteTemperature";
            this.buttonDeleteTemperature.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteTemperature.TabIndex = 5;
            this.buttonDeleteTemperature.Text = "Удалить";
            this.buttonDeleteTemperature.UseVisualStyleBackColor = true;
            this.buttonDeleteTemperature.Click += new System.EventHandler(this.buttonDeleteTemperature_Click);
            // 
            // buttonDeletePressure
            // 
            this.buttonDeletePressure.Location = new System.Drawing.Point(553, 416);
            this.buttonDeletePressure.Name = "buttonDeletePressure";
            this.buttonDeletePressure.Size = new System.Drawing.Size(109, 23);
            this.buttonDeletePressure.TabIndex = 11;
            this.buttonDeletePressure.Text = "Удалить";
            this.buttonDeletePressure.UseVisualStyleBackColor = true;
            this.buttonDeletePressure.Click += new System.EventHandler(this.buttonDeletePressure_Click);
            // 
            // buttonResetPressure
            // 
            this.buttonResetPressure.Location = new System.Drawing.Point(661, 416);
            this.buttonResetPressure.Name = "buttonResetPressure";
            this.buttonResetPressure.Size = new System.Drawing.Size(109, 23);
            this.buttonResetPressure.TabIndex = 10;
            this.buttonResetPressure.Text = "Сбросить";
            this.buttonResetPressure.UseVisualStyleBackColor = true;
            this.buttonResetPressure.Click += new System.EventHandler(this.buttonResetPressure_Click);
            // 
            // listBoxPressure
            // 
            this.listBoxPressure.FormattingEnabled = true;
            this.listBoxPressure.Location = new System.Drawing.Point(553, 133);
            this.listBoxPressure.Name = "listBoxPressure";
            this.listBoxPressure.Size = new System.Drawing.Size(217, 277);
            this.listBoxPressure.TabIndex = 9;
            // 
            // chartPressure
            // 
            chartArea39.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea39);
            this.chartPressure.Location = new System.Drawing.Point(6, 7);
            this.chartPressure.Name = "chartPressure";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Name = "Series1";
            this.chartPressure.Series.Add(series39);
            this.chartPressure.Size = new System.Drawing.Size(541, 439);
            this.chartPressure.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddPressure);
            this.groupBox3.Controls.Add(this.textBoxAddPressure);
            this.groupBox3.Location = new System.Drawing.Point(553, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 47);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить значение";
            // 
            // buttonAddPressure
            // 
            this.buttonAddPressure.Location = new System.Drawing.Point(102, 19);
            this.buttonAddPressure.Name = "buttonAddPressure";
            this.buttonAddPressure.Size = new System.Drawing.Size(109, 23);
            this.buttonAddPressure.TabIndex = 1;
            this.buttonAddPressure.Text = "Добавить";
            this.buttonAddPressure.UseVisualStyleBackColor = true;
            this.buttonAddPressure.Click += new System.EventHandler(this.buttonAddPressure_Click);
            // 
            // textBoxAddPressure
            // 
            this.textBoxAddPressure.Location = new System.Drawing.Point(6, 20);
            this.textBoxAddPressure.Name = "textBoxAddPressure";
            this.textBoxAddPressure.Size = new System.Drawing.Size(90, 20);
            this.textBoxAddPressure.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonGeneratePressure);
            this.groupBox4.Controls.Add(this.numericUpDownMaxPressure);
            this.groupBox4.Controls.Add(this.numericUpDownMinPressure);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(553, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 67);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Генерация";
            // 
            // buttonGeneratePressure
            // 
            this.buttonGeneratePressure.Location = new System.Drawing.Point(102, 18);
            this.buttonGeneratePressure.Name = "buttonGeneratePressure";
            this.buttonGeneratePressure.Size = new System.Drawing.Size(109, 43);
            this.buttonGeneratePressure.TabIndex = 4;
            this.buttonGeneratePressure.Text = "Сгенерировать";
            this.buttonGeneratePressure.UseVisualStyleBackColor = true;
            this.buttonGeneratePressure.Click += new System.EventHandler(this.buttonGeneratePressure_Click);
            // 
            // numericUpDownMaxPressure
            // 
            this.numericUpDownMaxPressure.Location = new System.Drawing.Point(40, 41);
            this.numericUpDownMaxPressure.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMaxPressure.Minimum = new decimal(new int[] {
            29,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxPressure.Name = "numericUpDownMaxPressure";
            this.numericUpDownMaxPressure.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMaxPressure.TabIndex = 3;
            this.numericUpDownMaxPressure.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinPressure
            // 
            this.numericUpDownMinPressure.Location = new System.Drawing.Point(40, 18);
            this.numericUpDownMinPressure.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.numericUpDownMinPressure.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownMinPressure.Name = "numericUpDownMinPressure";
            this.numericUpDownMinPressure.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMinPressure.TabIndex = 2;
            this.numericUpDownMinPressure.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Мах.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Мин.";
            // 
            // buttonDeleteHumidity
            // 
            this.buttonDeleteHumidity.Location = new System.Drawing.Point(553, 416);
            this.buttonDeleteHumidity.Name = "buttonDeleteHumidity";
            this.buttonDeleteHumidity.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteHumidity.TabIndex = 11;
            this.buttonDeleteHumidity.Text = "Удалить";
            this.buttonDeleteHumidity.UseVisualStyleBackColor = true;
            this.buttonDeleteHumidity.Click += new System.EventHandler(this.buttonDeleteHumidity_Click);
            // 
            // buttonResetHumidity
            // 
            this.buttonResetHumidity.Location = new System.Drawing.Point(661, 416);
            this.buttonResetHumidity.Name = "buttonResetHumidity";
            this.buttonResetHumidity.Size = new System.Drawing.Size(109, 23);
            this.buttonResetHumidity.TabIndex = 10;
            this.buttonResetHumidity.Text = "Сбросить";
            this.buttonResetHumidity.UseVisualStyleBackColor = true;
            this.buttonResetHumidity.Click += new System.EventHandler(this.buttonResetHumidity_Click);
            // 
            // listBoxHumidity
            // 
            this.listBoxHumidity.FormattingEnabled = true;
            this.listBoxHumidity.Location = new System.Drawing.Point(553, 133);
            this.listBoxHumidity.Name = "listBoxHumidity";
            this.listBoxHumidity.Size = new System.Drawing.Size(217, 277);
            this.listBoxHumidity.TabIndex = 9;
            // 
            // chartHumidity
            // 
            chartArea37.Name = "ChartArea1";
            this.chartHumidity.ChartAreas.Add(chartArea37);
            this.chartHumidity.Location = new System.Drawing.Point(6, 7);
            this.chartHumidity.Name = "chartHumidity";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Name = "Series1";
            this.chartHumidity.Series.Add(series37);
            this.chartHumidity.Size = new System.Drawing.Size(541, 439);
            this.chartHumidity.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAddHumidity);
            this.groupBox5.Controls.Add(this.textBoxAddHumidity);
            this.groupBox5.Location = new System.Drawing.Point(553, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 47);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Добавить значение";
            // 
            // buttonAddHumidity
            // 
            this.buttonAddHumidity.Location = new System.Drawing.Point(102, 19);
            this.buttonAddHumidity.Name = "buttonAddHumidity";
            this.buttonAddHumidity.Size = new System.Drawing.Size(109, 23);
            this.buttonAddHumidity.TabIndex = 1;
            this.buttonAddHumidity.Text = "Добавить";
            this.buttonAddHumidity.UseVisualStyleBackColor = true;
            this.buttonAddHumidity.Click += new System.EventHandler(this.buttonAddHumidity_Click);
            // 
            // textBoxAddHumidity
            // 
            this.textBoxAddHumidity.Location = new System.Drawing.Point(6, 20);
            this.textBoxAddHumidity.Name = "textBoxAddHumidity";
            this.textBoxAddHumidity.Size = new System.Drawing.Size(90, 20);
            this.textBoxAddHumidity.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonGenerateHumidity);
            this.groupBox6.Controls.Add(this.numericUpDownMaxHumidity);
            this.groupBox6.Controls.Add(this.numericUpDownMinHumidity);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(553, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 67);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Генерация";
            // 
            // buttonGenerateHumidity
            // 
            this.buttonGenerateHumidity.Location = new System.Drawing.Point(102, 18);
            this.buttonGenerateHumidity.Name = "buttonGenerateHumidity";
            this.buttonGenerateHumidity.Size = new System.Drawing.Size(109, 43);
            this.buttonGenerateHumidity.TabIndex = 4;
            this.buttonGenerateHumidity.Text = "Сгенерировать";
            this.buttonGenerateHumidity.UseVisualStyleBackColor = true;
            this.buttonGenerateHumidity.Click += new System.EventHandler(this.buttonGenerateHumidity_Click);
            // 
            // numericUpDownMaxHumidity
            // 
            this.numericUpDownMaxHumidity.Location = new System.Drawing.Point(40, 41);
            this.numericUpDownMaxHumidity.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMaxHumidity.Minimum = new decimal(new int[] {
            29,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxHumidity.Name = "numericUpDownMaxHumidity";
            this.numericUpDownMaxHumidity.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMaxHumidity.TabIndex = 3;
            this.numericUpDownMaxHumidity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinHumidity
            // 
            this.numericUpDownMinHumidity.Location = new System.Drawing.Point(40, 18);
            this.numericUpDownMinHumidity.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.numericUpDownMinHumidity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownMinHumidity.Name = "numericUpDownMinHumidity";
            this.numericUpDownMinHumidity.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMinHumidity.TabIndex = 2;
            this.numericUpDownMinHumidity.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Мах.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Мин.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Температура, давление, влажность";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTemperature.ResumeLayout(false);
            this.tabPagePressure.ResumeLayout(false);
            this.tabPageHumidity.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTemperature)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHumidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTemperature;
        private System.Windows.Forms.TabPage tabPagePressure;
        private System.Windows.Forms.TabPage tabPageHumidity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGenerateTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDownMinTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddTemperature;
        private System.Windows.Forms.TextBox textBoxAddTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Button buttonDeleteTemperature;
        private System.Windows.Forms.Button buttonResetTemperature;
        private System.Windows.Forms.ListBox listBoxTemperature;
        private System.Windows.Forms.Button buttonDeletePressure;
        private System.Windows.Forms.Button buttonResetPressure;
        private System.Windows.Forms.ListBox listBoxPressure;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAddPressure;
        private System.Windows.Forms.TextBox textBoxAddPressure;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonGeneratePressure;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPressure;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteHumidity;
        private System.Windows.Forms.Button buttonResetHumidity;
        private System.Windows.Forms.ListBox listBoxHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumidity;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddHumidity;
        private System.Windows.Forms.TextBox textBoxAddHumidity;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonGenerateHumidity;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxHumidity;
        private System.Windows.Forms.NumericUpDown numericUpDownMinHumidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

