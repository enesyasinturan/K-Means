
namespace K_Means
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRastgeleUret = new System.Windows.Forms.Button();
            this.listBoxKume1 = new System.Windows.Forms.ListBox();
            this.listBoxKume2 = new System.Windows.Forms.ListBox();
            this.labelKume1 = new System.Windows.Forms.Label();
            this.labelKume2 = new System.Windows.Forms.Label();
            this.buttonKumele = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxVeriler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKumeSayisi2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKumeSayisi1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labeliterasyonSayisi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinDeger = new System.Windows.Forms.NumericUpDown();
            this.nudMaksDeger = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudVeriSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudKumeSayisi = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.labelToplamx1 = new System.Windows.Forms.Label();
            this.labelToplamy1 = new System.Windows.Forms.Label();
            this.labelToplamx2 = new System.Windows.Forms.Label();
            this.labelToplamy2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKumeMerkezi2 = new System.Windows.Forms.Label();
            this.labelKumeMerkezi1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVeriSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKumeSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRastgeleUret
            // 
            this.btnRastgeleUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgeleUret.Location = new System.Drawing.Point(88, 218);
            this.btnRastgeleUret.Name = "btnRastgeleUret";
            this.btnRastgeleUret.Size = new System.Drawing.Size(203, 45);
            this.btnRastgeleUret.TabIndex = 0;
            this.btnRastgeleUret.Text = "Rastgele Üret";
            this.btnRastgeleUret.UseVisualStyleBackColor = true;
            this.btnRastgeleUret.Click += new System.EventHandler(this.btnRastgeleUret_Click);
            // 
            // listBoxKume1
            // 
            this.listBoxKume1.FormattingEnabled = true;
            this.listBoxKume1.Location = new System.Drawing.Point(424, 31);
            this.listBoxKume1.Name = "listBoxKume1";
            this.listBoxKume1.Size = new System.Drawing.Size(71, 173);
            this.listBoxKume1.TabIndex = 4;
            // 
            // listBoxKume2
            // 
            this.listBoxKume2.FormattingEnabled = true;
            this.listBoxKume2.Location = new System.Drawing.Point(562, 28);
            this.listBoxKume2.Name = "listBoxKume2";
            this.listBoxKume2.Size = new System.Drawing.Size(70, 173);
            this.listBoxKume2.TabIndex = 5;
            // 
            // labelKume1
            // 
            this.labelKume1.AutoSize = true;
            this.labelKume1.Location = new System.Drawing.Point(438, 12);
            this.labelKume1.Name = "labelKume1";
            this.labelKume1.Size = new System.Drawing.Size(43, 13);
            this.labelKume1.TabIndex = 6;
            this.labelKume1.Text = "Küme 1";
            // 
            // labelKume2
            // 
            this.labelKume2.AutoSize = true;
            this.labelKume2.Location = new System.Drawing.Point(575, 9);
            this.labelKume2.Name = "labelKume2";
            this.labelKume2.Size = new System.Drawing.Size(43, 13);
            this.labelKume2.TabIndex = 7;
            this.labelKume2.Text = "Küme 2";
            // 
            // buttonKumele
            // 
            this.buttonKumele.Location = new System.Drawing.Point(676, 20);
            this.buttonKumele.Name = "buttonKumele";
            this.buttonKumele.Size = new System.Drawing.Size(156, 45);
            this.buttonKumele.TabIndex = 8;
            this.buttonKumele.Text = "Kümele";
            this.buttonKumele.UseVisualStyleBackColor = true;
            this.buttonKumele.Click += new System.EventHandler(this.buttonKumele_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 306);
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
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Name = "KumeMerkezleri";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Lime;
            series3.MarkerColor = System.Drawing.Color.Lime;
            series3.MarkerImageTransparentColor = System.Drawing.Color.Lime;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Kume1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerImageTransparentColor = System.Drawing.Color.Red;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Kume2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(691, 364);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // listBoxVeriler
            // 
            this.listBoxVeriler.FormattingEnabled = true;
            this.listBoxVeriler.Location = new System.Drawing.Point(12, 12);
            this.listBoxVeriler.Name = "listBoxVeriler";
            this.listBoxVeriler.Size = new System.Drawing.Size(67, 251);
            this.listBoxVeriler.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Üretilecek Rastgele Veri";
            // 
            // labelKumeSayisi2
            // 
            this.labelKumeSayisi2.AutoSize = true;
            this.labelKumeSayisi2.Location = new System.Drawing.Point(559, 224);
            this.labelKumeSayisi2.Name = "labelKumeSayisi2";
            this.labelKumeSayisi2.Size = new System.Drawing.Size(35, 13);
            this.labelKumeSayisi2.TabIndex = 28;
            this.labelKumeSayisi2.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Küme Veri Sayısı";
            // 
            // labelKumeSayisi1
            // 
            this.labelKumeSayisi1.AutoSize = true;
            this.labelKumeSayisi1.Location = new System.Drawing.Point(421, 227);
            this.labelKumeSayisi1.Name = "labelKumeSayisi1";
            this.labelKumeSayisi1.Size = new System.Drawing.Size(35, 13);
            this.labelKumeSayisi1.TabIndex = 26;
            this.labelKumeSayisi1.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Küme Veri Sayısı";
            // 
            // labeliterasyonSayisi
            // 
            this.labeliterasyonSayisi.AutoSize = true;
            this.labeliterasyonSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeliterasyonSayisi.Location = new System.Drawing.Point(729, 108);
            this.labeliterasyonSayisi.Name = "labeliterasyonSayisi";
            this.labeliterasyonSayisi.Size = new System.Drawing.Size(41, 13);
            this.labeliterasyonSayisi.TabIndex = 30;
            this.labeliterasyonSayisi.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "İTERASYON SAYISI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Üretilecek Verilerin Değer Aralıkları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Min";
            // 
            // nudMinDeger
            // 
            this.nudMinDeger.Location = new System.Drawing.Point(88, 52);
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
            this.nudMinDeger.Size = new System.Drawing.Size(62, 20);
            this.nudMinDeger.TabIndex = 35;
            this.nudMinDeger.ValueChanged += new System.EventHandler(this.nudMinDeger_ValueChanged);
            // 
            // nudMaksDeger
            // 
            this.nudMaksDeger.Location = new System.Drawing.Point(189, 52);
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
            this.nudMaksDeger.Size = new System.Drawing.Size(62, 20);
            this.nudMaksDeger.TabIndex = 36;
            this.nudMaksDeger.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Maks";
            // 
            // nudVeriSayisi
            // 
            this.nudVeriSayisi.Location = new System.Drawing.Point(88, 108);
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
            this.nudVeriSayisi.Size = new System.Drawing.Size(62, 20);
            this.nudVeriSayisi.TabIndex = 38;
            this.nudVeriSayisi.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudVeriSayisi.ValueChanged += new System.EventHandler(this.nudVeriSayisi_ValueChanged);
            // 
            // nudKumeSayisi
            // 
            this.nudKumeSayisi.Enabled = false;
            this.nudKumeSayisi.Location = new System.Drawing.Point(88, 176);
            this.nudKumeSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKumeSayisi.Name = "nudKumeSayisi";
            this.nudKumeSayisi.Size = new System.Drawing.Size(62, 20);
            this.nudKumeSayisi.TabIndex = 40;
            this.nudKumeSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Küme Sayısı";
            // 
            // labelToplamx1
            // 
            this.labelToplamx1.AutoSize = true;
            this.labelToplamx1.Location = new System.Drawing.Point(421, 263);
            this.labelToplamx1.Name = "labelToplamx1";
            this.labelToplamx1.Size = new System.Drawing.Size(35, 13);
            this.labelToplamx1.TabIndex = 41;
            this.labelToplamx1.Text = "label3";
            // 
            // labelToplamy1
            // 
            this.labelToplamy1.AutoSize = true;
            this.labelToplamy1.Location = new System.Drawing.Point(421, 290);
            this.labelToplamy1.Name = "labelToplamy1";
            this.labelToplamy1.Size = new System.Drawing.Size(35, 13);
            this.labelToplamy1.TabIndex = 42;
            this.labelToplamy1.Text = "label3";
            // 
            // labelToplamx2
            // 
            this.labelToplamx2.AutoSize = true;
            this.labelToplamx2.Location = new System.Drawing.Point(559, 263);
            this.labelToplamx2.Name = "labelToplamx2";
            this.labelToplamx2.Size = new System.Drawing.Size(35, 13);
            this.labelToplamx2.TabIndex = 43;
            this.labelToplamx2.Text = "label3";
            // 
            // labelToplamy2
            // 
            this.labelToplamy2.AutoSize = true;
            this.labelToplamy2.Location = new System.Drawing.Point(559, 290);
            this.labelToplamy2.Name = "labelToplamy2";
            this.labelToplamy2.Size = new System.Drawing.Size(35, 13);
            this.labelToplamy2.TabIndex = 44;
            this.labelToplamy2.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Küme Merkezi 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Küme Merkezi 1";
            // 
            // labelKumeMerkezi2
            // 
            this.labelKumeMerkezi2.AutoSize = true;
            this.labelKumeMerkezi2.Location = new System.Drawing.Point(322, 131);
            this.labelKumeMerkezi2.Name = "labelKumeMerkezi2";
            this.labelKumeMerkezi2.Size = new System.Drawing.Size(83, 13);
            this.labelKumeMerkezi2.TabIndex = 49;
            this.labelKumeMerkezi2.Text = "Küme Merkezi 2";
            // 
            // labelKumeMerkezi1
            // 
            this.labelKumeMerkezi1.AutoSize = true;
            this.labelKumeMerkezi1.Location = new System.Drawing.Point(322, 59);
            this.labelKumeMerkezi1.Name = "labelKumeMerkezi1";
            this.labelKumeMerkezi1.Size = new System.Drawing.Size(83, 13);
            this.labelKumeMerkezi1.TabIndex = 48;
            this.labelKumeMerkezi1.Text = "Küme Merkezi 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 672);
            this.Controls.Add(this.labelKumeMerkezi2);
            this.Controls.Add(this.labelKumeMerkezi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelToplamy2);
            this.Controls.Add(this.labelToplamx2);
            this.Controls.Add(this.labelToplamy1);
            this.Controls.Add(this.labelToplamx1);
            this.Controls.Add(this.nudKumeSayisi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudVeriSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudMaksDeger);
            this.Controls.Add(this.nudMinDeger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeliterasyonSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelKumeSayisi2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelKumeSayisi1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxVeriler);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonKumele);
            this.Controls.Add(this.labelKume2);
            this.Controls.Add(this.labelKume1);
            this.Controls.Add(this.listBoxKume2);
            this.Controls.Add(this.listBoxKume1);
            this.Controls.Add(this.btnRastgeleUret);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVeriSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKumeSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRastgeleUret;
        private System.Windows.Forms.ListBox listBoxKume1;
        private System.Windows.Forms.ListBox listBoxKume2;
        private System.Windows.Forms.Label labelKume1;
        private System.Windows.Forms.Label labelKume2;
        private System.Windows.Forms.Button buttonKumele;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBoxVeriler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKumeSayisi2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelKumeSayisi1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labeliterasyonSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinDeger;
        private System.Windows.Forms.NumericUpDown nudMaksDeger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudVeriSayisi;
        private System.Windows.Forms.NumericUpDown nudKumeSayisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelToplamx1;
        private System.Windows.Forms.Label labelToplamy1;
        private System.Windows.Forms.Label labelToplamx2;
        private System.Windows.Forms.Label labelToplamy2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKumeMerkezi2;
        private System.Windows.Forms.Label labelKumeMerkezi1;
    }
}

