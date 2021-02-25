
namespace Currency_game_exchange
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericBuyCountRUB = new System.Windows.Forms.NumericUpDown();
            this.buyRubButton = new System.Windows.Forms.Button();
            this.numericBuyCountUsd = new System.Windows.Forms.NumericUpDown();
            this.buyUsdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyCountRUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyCountUsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(632, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericBuyCountRUB);
            this.panel1.Controls.Add(this.buyRubButton);
            this.panel1.Controls.Add(this.numericBuyCountUsd);
            this.panel1.Controls.Add(this.buyUsdButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RUB";
            // 
            // numericBuyCountRUB
            // 
            this.numericBuyCountRUB.Location = new System.Drawing.Point(284, 59);
            this.numericBuyCountRUB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericBuyCountRUB.Name = "numericBuyCountRUB";
            this.numericBuyCountRUB.Size = new System.Drawing.Size(168, 20);
            this.numericBuyCountRUB.TabIndex = 9;
            // 
            // buyRubButton
            // 
            this.buyRubButton.Location = new System.Drawing.Point(284, 3);
            this.buyRubButton.Name = "buyRubButton";
            this.buyRubButton.Size = new System.Drawing.Size(168, 43);
            this.buyRubButton.TabIndex = 8;
            this.buyRubButton.Text = "Buy RUB";
            this.buyRubButton.UseVisualStyleBackColor = true;
            this.buyRubButton.Click += new System.EventHandler(this.buyRubButton_Click);
            // 
            // numericBuyCountUsd
            // 
            this.numericBuyCountUsd.Location = new System.Drawing.Point(458, 59);
            this.numericBuyCountUsd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericBuyCountUsd.Name = "numericBuyCountUsd";
            this.numericBuyCountUsd.Size = new System.Drawing.Size(168, 20);
            this.numericBuyCountUsd.TabIndex = 7;
            // 
            // buyUsdButton
            // 
            this.buyUsdButton.Location = new System.Drawing.Point(458, 3);
            this.buyUsdButton.Name = "buyUsdButton";
            this.buyUsdButton.Size = new System.Drawing.Size(168, 43);
            this.buyUsdButton.TabIndex = 6;
            this.buyUsdButton.Text = "Buy USD";
            this.buyUsdButton.UseVisualStyleBackColor = true;
            this.buyUsdButton.Click += new System.EventHandler(this.buyUsdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "USD/RUB";
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Maximum = 75D;
            chartArea4.AxisY.Minimum = 73D;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 97);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Green;
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(800, 353);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyCountRUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyCountUsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyUsdButton;
        private System.Windows.Forms.NumericUpDown numericBuyCountUsd;
        private System.Windows.Forms.NumericUpDown numericBuyCountRUB;
        private System.Windows.Forms.Button buyRubButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

