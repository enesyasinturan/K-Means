
namespace K_Means
{
    partial class FormKMeans
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKMeans));
            this.btnRastgeleUret = new System.Windows.Forms.Button();
            this.buttonKumele = new System.Windows.Forms.Button();
            this.nudMinDeger = new System.Windows.Forms.NumericUpDown();
            this.nudMaksDeger = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labeliterasyonSayisi = new System.Windows.Forms.Label();
            this.nudVeriSayisi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudKumeSayisi = new System.Windows.Forms.NumericUpDown();
            this.listBoxVeriler = new System.Windows.Forms.ListBox();
            this.listBoxKumeMerkezleri = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKumeBitis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVeriSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKumeSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRastgeleUret
            // 
            this.btnRastgeleUret.BackColor = System.Drawing.Color.Tomato;
            this.btnRastgeleUret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRastgeleUret.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgeleUret.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRastgeleUret.Location = new System.Drawing.Point(9, 163);
            this.btnRastgeleUret.Name = "btnRastgeleUret";
            this.btnRastgeleUret.Size = new System.Drawing.Size(196, 49);
            this.btnRastgeleUret.TabIndex = 0;
            this.btnRastgeleUret.Text = "RASTGELE ÜRET";
            this.btnRastgeleUret.UseVisualStyleBackColor = false;
            this.btnRastgeleUret.Click += new System.EventHandler(this.btnRastgeleUret_Click);
            // 
            // buttonKumele
            // 
            this.buttonKumele.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonKumele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKumele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKumele.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKumele.Location = new System.Drawing.Point(9, 499);
            this.buttonKumele.Name = "buttonKumele";
            this.buttonKumele.Size = new System.Drawing.Size(196, 49);
            this.buttonKumele.TabIndex = 8;
            this.buttonKumele.Text = "KÜMELE";
            this.buttonKumele.UseVisualStyleBackColor = false;
            this.buttonKumele.Click += new System.EventHandler(this.buttonKumele_Click);
            // 
            // nudMinDeger
            // 
            this.nudMinDeger.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMinDeger.Location = new System.Drawing.Point(30, 22);
            this.nudMinDeger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinDeger.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudMinDeger.Name = "nudMinDeger";
            this.nudMinDeger.Size = new System.Drawing.Size(62, 21);
            this.nudMinDeger.TabIndex = 35;
            this.nudMinDeger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinDeger.ValueChanged += new System.EventHandler(this.nudMinDeger_ValueChanged);
            // 
            // nudMaksDeger
            // 
            this.nudMaksDeger.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMaksDeger.Location = new System.Drawing.Point(115, 22);
            this.nudMaksDeger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaksDeger.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudMaksDeger.Name = "nudMaksDeger";
            this.nudMaksDeger.Size = new System.Drawing.Size(62, 21);
            this.nudMaksDeger.TabIndex = 36;
            this.nudMaksDeger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaksDeger.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Minimum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(115, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Maksimum";
            // 
            // labeliterasyonSayisi
            // 
            this.labeliterasyonSayisi.AutoSize = true;
            this.labeliterasyonSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeliterasyonSayisi.Location = new System.Drawing.Point(95, 581);
            this.labeliterasyonSayisi.Name = "labeliterasyonSayisi";
            this.labeliterasyonSayisi.Size = new System.Drawing.Size(19, 13);
            this.labeliterasyonSayisi.TabIndex = 30;
            this.labeliterasyonSayisi.Text = "---";
            // 
            // nudVeriSayisi
            // 
            this.nudVeriSayisi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudVeriSayisi.Location = new System.Drawing.Point(47, 74);
            this.nudVeriSayisi.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudVeriSayisi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVeriSayisi.Name = "nudVeriSayisi";
            this.nudVeriSayisi.Size = new System.Drawing.Size(116, 21);
            this.nudVeriSayisi.TabIndex = 38;
            this.nudVeriSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudVeriSayisi.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVeriSayisi.ValueChanged += new System.EventHandler(this.nudVeriSayisi_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(63, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "İTERASYON SAYISI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(71, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Küme Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(71, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Veri Sayısı";
            // 
            // nudKumeSayisi
            // 
            this.nudKumeSayisi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKumeSayisi.Location = new System.Drawing.Point(47, 127);
            this.nudKumeSayisi.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudKumeSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKumeSayisi.Name = "nudKumeSayisi";
            this.nudKumeSayisi.Size = new System.Drawing.Size(116, 21);
            this.nudKumeSayisi.TabIndex = 40;
            this.nudKumeSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKumeSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKumeSayisi.ValueChanged += new System.EventHandler(this.nudKumeSayisi_ValueChanged);
            // 
            // listBoxVeriler
            // 
            this.listBoxVeriler.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxVeriler.FormattingEnabled = true;
            this.listBoxVeriler.ItemHeight = 15;
            this.listBoxVeriler.Location = new System.Drawing.Point(9, 279);
            this.listBoxVeriler.Name = "listBoxVeriler";
            this.listBoxVeriler.Size = new System.Drawing.Size(83, 214);
            this.listBoxVeriler.TabIndex = 21;
            // 
            // listBoxKumeMerkezleri
            // 
            this.listBoxKumeMerkezleri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxKumeMerkezleri.FormattingEnabled = true;
            this.listBoxKumeMerkezleri.ItemHeight = 15;
            this.listBoxKumeMerkezleri.Location = new System.Drawing.Point(122, 279);
            this.listBoxKumeMerkezleri.Name = "listBoxKumeMerkezleri";
            this.listBoxKumeMerkezleri.Size = new System.Drawing.Size(83, 214);
            this.listBoxKumeMerkezleri.TabIndex = 54;
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(211, 1);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Blue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Veriler";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Fuchsia;
            series2.MarkerColor = System.Drawing.Color.Fuchsia;
            series2.MarkerImageTransparentColor = System.Drawing.Color.Fuchsia;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series2.Name = "KumeMerkezleri";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1151, 719);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Veriler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Kümeler";
            // 
            // labelKumeBitis
            // 
            this.labelKumeBitis.AutoSize = true;
            this.labelKumeBitis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKumeBitis.ForeColor = System.Drawing.Color.Lime;
            this.labelKumeBitis.Location = new System.Drawing.Point(5, 662);
            this.labelKumeBitis.Name = "labelKumeBitis";
            this.labelKumeBitis.Size = new System.Drawing.Size(0, 19);
            this.labelKumeBitis.TabIndex = 57;
            // 
            // FormKMeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1169, 704);
            this.Controls.Add(this.labelKumeBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBoxKumeMerkezleri);
            this.Controls.Add(this.buttonKumele);
            this.Controls.Add(this.listBoxVeriler);
            this.Controls.Add(this.nudMinDeger);
            this.Controls.Add(this.btnRastgeleUret);
            this.Controls.Add(this.nudMaksDeger);
            this.Controls.Add(this.nudKumeSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labeliterasyonSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudVeriSayisi);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKMeans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-Means";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVeriSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKumeSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRastgeleUret;
        private System.Windows.Forms.Button buttonKumele;
        private System.Windows.Forms.NumericUpDown nudMinDeger;
        private System.Windows.Forms.NumericUpDown nudMaksDeger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeliterasyonSayisi;
        private System.Windows.Forms.NumericUpDown nudVeriSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudKumeSayisi;
        private System.Windows.Forms.ListBox listBoxVeriler;
        private System.Windows.Forms.ListBox listBoxKumeMerkezleri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKumeBitis;
    }
}

